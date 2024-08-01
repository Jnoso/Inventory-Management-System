using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Project.classes;

namespace Inventory_Project
{
    public partial class ModifyProduct : Form
    {
        private Form1 mainForm;
        BindingList<Part> initializeAssoPart = new BindingList<Part>();
        BindingList<Part> holdPart = new BindingList<Part>();


        public ModifyProduct(Form1 form1)
        {
            InitializeComponent();

            //Set top dgv similar to main screen
            mainForm = form1;
            dgvModProdAll.DataSource = mainForm.dgvPart.DataSource;

            //Fill up TextBox and Associated Parts
            FillFormData();

            //Create a Copy of the Original Data to Restore if Cancel Btn is Clicked
            foreach (Part part in initializeAssoPart)
            {
                holdPart.Add(part);
            }
        }

        private void partsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvModProdAll.ClearSelection();
            dgvModProdAsso.ClearSelection();
        }

        //Cancel Button Click Event
        //Clears the altered DataGridView List
        //Stores the Original DataGridView List Back to the Product
        //Closes Modify Product Window
        private void modProdCancBtnClick(object sender, EventArgs e)
        {
            Product product = Inventory.LookUpProduct(int.Parse(modifyProductIdText.Text));

            //Clear the altered Associated Parts Table
            for (int i = initializeAssoPart.Count - 1; i>=0; i--)
            {
                initializeAssoPart.RemoveAt(i);
            }

            //Copies back the Original Associated Parts Table
            foreach (Part part in holdPart)
            {
                product.AddAssociatedPart(part);
            }
            dgvModProdAsso.DataSource = initializeAssoPart;
            Close();
        }

        //Search Button Click Event
        private void modProdSrchBtnClick(object sender, EventArgs e)
        {
            string searchUserInput = modifyProductSearchBox.Text.ToLower();
            Part searchPart = Inventory.allParts.FirstOrDefault(p => p.Name.ToLower().Contains(searchUserInput));

            if (searchPart != null)
            {
                int selectedPartId = (int)searchPart.PartId;
                Part matchingPart = Inventory.LookUpPart(selectedPartId);

                foreach (DataGridViewRow row in dgvModProdAll.Rows)
                {
                    Part part = row.DataBoundItem as Part;
                    if (part.PartId == matchingPart.PartId)
                    {
                        dgvModProdAll.CurrentCell = row.Cells[0];
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        //Add Button Click Event
        private void modProdAddBtn(object sender, EventArgs e)
        {
            Product product = Inventory.LookUpProduct(int.Parse(modifyProductIdText.Text));
            //Error Check
            if (dgvModProdAll.CurrentRow == null || dgvModProdAll.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a part to Add.");
                return;
            }
            //Add part to Bottom DGV
            else
            {
                int partId = (int)dgvModProdAll.CurrentRow.Cells["PartId"].Value;
                Part selectedPart = Inventory.LookUpPart(partId);
                product.AddAssociatedPart(selectedPart);
            }
        }

        //Delete Button Click Event
        private void modProdDelBtnClick(object sender, EventArgs e)
        {
            Product product = Inventory.LookUpProduct(int.Parse(modifyProductIdText.Text));
            //Error Check
            if (dgvModProdAsso.CurrentRow == null || dgvModProdAsso.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a part to Delete.");
                return;
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Delete Part?", "Delete", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    int partId = (int)dgvModProdAsso.CurrentRow.Cells["PartId"].Value;
                    bool isDeleted = product.RemoveAssociatedPart(partId);

                    if (isDeleted)
                    {
                        Part selectedPart = product.LookUpAssociatedPart(partId);
                        initializeAssoPart.Remove(selectedPart);
                        dgvModProdAsso.Refresh();

                        MessageBox.Show("Part has been deleted");
                        dgvModProdAsso.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete part");
                    }
                }
                else if (dialogresult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Save Button Click Event
        private void modProdSaveBtnClick(object sender, EventArgs e)
        {
            int productId = int.Parse(modifyProductIdText.Text);
            string textName = modifyProductNameBox.Text;
            int textInv = int.Parse(modifyProductInventoryBox.Text);
            decimal textPrice = Math.Round(decimal.Parse(modifyProductPriceBox.Text), 2, MidpointRounding.AwayFromZero);
            int textMin = int.Parse(modifyProductMinBox.Text);
            int textMax = int.Parse(modifyProductMaxBox.Text);
            Product product = Inventory.LookUpProduct(int.Parse(modifyProductIdText.Text));

            //Error Checks Max and Min value
            if (textMax < textMin)
            {
                MessageBox.Show("Maximum is less than minimum. Please correct your minimum and maximum values.");
                return;
            }

            //Error Checks Inventory Value with Max/Min Value
            if (textInv > textMax || textInv < textMin)
            {
                MessageBox.Show("Inventory value is out of the minimum and maximum value. Please correct your inventory value.");
                return;
            }

            var changedProduct = new Product(productId, textName, textInv, textPrice, textMin, textMax);
            foreach (Part part in initializeAssoPart)
            {
                changedProduct.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(productId, changedProduct);
            
            mainForm.dgvProduct.Refresh();
            Close();


        }

        //Name TextBox Change Event
        private void modProdNameBoxChng(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Inventory TextBox Change Event
        private void modProdInvTextChng(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Price TextBox Change Event
        private void modProdPriceTextChng(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Min TextBox Change Event
        private void modProdMinTextChng(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Max TextBox Change Event
        private void modProdMaxTextChng(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Method to Fill Modify Product TextBox
        //When form initializes
        public void FillFormData()
        {
            int productId = (int)mainForm.dgvProduct.CurrentRow.Cells["ProductID"].Value;

            //Fill up textbox
            foreach (var product in Inventory.allProducts)
            {
                if (productId == product.ProductID)
                {
                    modifyProductIdText.Text = productId.ToString();
                    modifyProductNameBox.Text = product.Name;
                    modifyProductInventoryBox.Text = product.InStock.ToString();
                    modifyProductPriceBox.Text = product.Price.ToString();
                    modifyProductMinBox.Text = product.Min.ToString();
                    modifyProductMaxBox.Text = product.Max.ToString();
                }
            }

            //Lookup Product and Populate Associated Part DGV
            Product matchingProduct = Inventory.LookUpProduct(productId);
            initializeAssoPart = matchingProduct.AssociatedParts;

            

            dgvModProdAsso.DataSource = initializeAssoPart;

        }

        //Method to Enable/Disable Save Btn
        //Depending on TextBox Error Checks
        private void EnableSaveBtnCheck()
        {
            bool allValid = true;

            if (string.IsNullOrEmpty(modifyProductNameBox.Text))
            {
                allValid = false;
                modifyProductNameBox.BackColor = Color.Red;
            }
            else
            {
                modifyProductNameBox.BackColor = SystemColors.Window;
            }

            int userInv;
            if (int.TryParse(modifyProductInventoryBox.Text, out userInv))
            {
                modifyProductInventoryBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyProductInventoryBox.BackColor = Color.Red;
                allValid = false;
            }

            decimal userPrice;
            if (decimal.TryParse(modifyProductPriceBox.Text, out userPrice))
            {
                modifyProductPriceBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyProductPriceBox.BackColor = Color.Red;
                allValid = false;
            }

            int userMin;
            if (int.TryParse(modifyProductMinBox.Text, out userMin))
            {
                modifyProductMinBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyProductMinBox.BackColor = Color.Red;
                allValid = false;
            }

            int userMax;
            if (int.TryParse(modifyProductMaxBox.Text, out userMax))
            {
                modifyProductMaxBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyProductMaxBox.BackColor = Color.Red;
                allValid = false;
            }

            modifyProductSaveBtn.Enabled = allValid;
        }

    }
}
