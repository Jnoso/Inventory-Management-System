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
            if (dgvPart.CurrentRow == null || dgvPart.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a Part to Modify.");
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
            if (dgvPart.CurrentRow == null || dgvPart.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a Part to Delete.");
                return;
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Delete Part?", "Delete", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    int partid = (int)dgvPart.CurrentRow.Cells["PartId"].Value;
                    Part selectedPart = Inventory.LookUpPart(partid);
                    Part inAssociatedPart = null;

                    //Loop through all product to check if part is in that product's
                    //AssociatedPart BindingList
                    for (int i = 0; i<dgvProduct.Rows.Count; i++)
                    {
                        Product product = Inventory.LookUpProduct(i+1);
                        if (product != null)
                        {
                            inAssociatedPart = product.LookUpAssociatedPart(partid);

                            if (inAssociatedPart != null)
                            {
                                break;
                            }
                        }
                    }

                    if (selectedPart != null && inAssociatedPart == null)
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
                    else if (selectedPart != null && inAssociatedPart != null)
                    {
                        MessageBox.Show("Item is in Product's Associated Part. Can not delete");
                        return;
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
                int selectedPartId = (int)searchPart.PartId;
                Part matchingPart = Inventory.LookUpPart(selectedPartId);

                foreach (DataGridViewRow row in dgvPart.Rows)
                {
                    Part part = row.DataBoundItem as Part;
                    if (part.PartId == matchingPart.PartId)
                    {
                        dgvPart.CurrentCell = row.Cells[0];
                        row.Selected = true;
                        break;
                    }
                }


            }
        }

        //Search Product Button Event
        private void prodSrchBtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productsTextBox.Text))
            {
                MessageBox.Show("Please Type into the search box.");
                return;
            }

            string searchUserProdInput = productsTextBox.Text.ToLower();
            Product searchProduct = Inventory.allProducts.FirstOrDefault(q => q.Name.ToLower().Contains(searchUserProdInput));

            if (searchProduct != null)
            {
                int selectedProductId = (int)searchProduct.ProductID;

                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    Product product = row.DataBoundItem as Product;
                    if (product.ProductID == selectedProductId)
                    {
                        dgvProduct.CurrentCell = row.Cells[0];
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

        //Modify Product Button Click Event
        private void modProdBtnClick(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null || dgvProduct.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a Product to Modify.");
                return;
            }
            else
            {
                ModifyProduct modifyProduct = new ModifyProduct(this);
                modifyProduct.Show();
            }
        }

        //Delete Product Button Click Event
        private void delProdBtnClick(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null || dgvProduct.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a Product to Delete.");
                return;
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Delete Product?", "Delete", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    int selectedProductId = (int)dgvProduct.CurrentRow.Cells["ProductID"].Value;
                    Product selectedProduct = Inventory.LookUpProduct(selectedProductId);

                    if (selectedProduct != null)
                    {
                        bool deleted = Inventory.RemoveProduct(selectedProductId);

                        if (deleted)
                        {
                            Inventory.allProducts.Remove(selectedProduct);
                            MessageBox.Show("Product has been deleted.");
                            dgvProduct.ClearSelection();
                            dgvProduct.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete product.");
                        }
                    }
                }
                else if(dialogresult == DialogResult.No)
                {
                    return;
                }
            }
        }

        


    }
}
