using Inventory_Project.classes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inventory_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Populates the Grid with Example Part/Product
            Inventory.PopulateGrid();

            //Links the DataGrid Parts with BindingList<Part>
            dgvPart.DataSource = Inventory.allParts;

            //Links the DataGrid Products with BindingList<Product>
            dgvProduct.DataSource = Inventory.allProducts;
        }

        //clear selection when form loads.
        private void partsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPart.ClearSelection();
            dgvProduct.ClearSelection();
        }

        //When Exit Button is Clicked
        private void exitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        //When Add is clicked for Parts
        private void addPartClick(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        //Modify Part Button Click Event
        private void addPartModBtn(object sender, EventArgs e)
        {

            //check if part is selected
            if (dgvPart.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please make a selection.");
                return;
            }
            else
            {
                ModifyPart modifyPartWindow = new ModifyPart(this);
                modifyPartWindow.Show();
            }

        }

        //Delete Part Button Event
        private void delPartBtnClick(object sender, EventArgs e)
        {
            if (dgvPart.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please make a selection.");
                return;
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Delete Part?", "Delete", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    int partid = (int)dgvPart.CurrentRow.Cells["PartId"].Value;
                    Part selectedPart = Inventory.allParts.FirstOrDefault(x => x.PartId == partid);

                    if (selectedPart != null)
                    {
                        bool isDeleted = Inventory.DeletePart(selectedPart);
                        if (isDeleted)
                        {
                            MessageBox.Show("Item has been deleted");
                            dgvPart.ClearSelection();
                            dgvPart.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete item");
                        }
                    }

                }
                else if (dialogresult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Search Part Button Event
        private void partSrchBtn(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partsID.Text))
            {
                MessageBox.Show("Please Type into the search box");
                return;
            }


            string searchUserInput = partsID.Text.ToLower();
            Part searchPart = Inventory.allParts.FirstOrDefault(p => p.Name.ToLower().Contains(searchUserInput));

            if (searchPart != null)
            {
                int selectedPartId = Inventory.LookUpPart(searchPart);

                foreach (DataGridViewRow row in dgvPart.Rows)
                {
                    if (((int)row.Cells["PartId"].Value == selectedPartId))
                    {
                        dgvPart.CurrentCell = row.Cells[0];
                        row.Selected = true;
                        break;
                    }
                }


            }
        }

        //Add Product Button Click Event
        private void addProductBtnClick(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.Show();
        }
    }
}
