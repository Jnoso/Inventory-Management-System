using Inventory_Project.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Project
{
    public partial class AddProduct : Form
    {
        private Form1 mainForm;
        BindingList<Part> tempParts = new BindingList<Part>();

        public AddProduct(Form1 form1)
        {

            InitializeComponent();

            //Take Form1 DGV and Set it to All Parts DGV
            mainForm = form1;
            dgvAddProdAll.DataSource = mainForm.dgvPart.DataSource;

            //Create new bindinglist for AssociatedParts 
            dgvAddProdAsso.DataSource = tempParts;

            //Initially Set Textbox Color to Red
            addProductNameBox.BackColor = Color.Red;
            addProductInventoryBox.BackColor = Color.Red;
            addProductPriceBox.BackColor = Color.Red;
            addProductMaxBox.BackColor = Color.Red;
            addProductMinBox.BackColor = Color.Red;
        }

        //Cancel Btn Clicked
        private void addProdCancBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        //Checks Text Change in Name TextBox
        private void addProductNameTextChange(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Checks Text Change in Inventory Textbox
        private void addInvTextBoxChange(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Checks Text Change in Price Textbox
        private void addProdPriceTextBoxChange(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Checks Text Change in Max Textbox
        private void addProdMaxTextBoxChange(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //Checks Text Change in Min Textbox
        private void addProdMinTextBoxChange(object sender, EventArgs e)
        {
            EnableSaveBtnCheck();
        }

        //When Add Btn is Pressed to Move to Associate Part List
        private void addPartToAssoPart(object sender, EventArgs e)
        {

            //Error Check to see if Row is Selected
            if (dgvAddProdAll.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a Part to Add");
                return;
            }
            //Take selected Part from Top Table and Place it in Bottom Table
            else
            {
                int partId = (int)dgvAddProdAll.CurrentRow.Cells["PartId"].Value;
                Part selectedPart = Inventory.allParts.FirstOrDefault(x => x.PartId == partId);
                tempParts.Add(selectedPart);
            }
        }

        //Delete Btn Event. Remove from Associated Part List
        private void delAssoPartBtn(object sender, EventArgs e)
        {
            if (dgvAddProdAsso.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a Part to Delete");
                return;
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Delete Part?", "Delete", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    int partId = (int)dgvAddProdAsso.CurrentRow.Cells["PartId"].Value;
                    Part selectedPart = tempParts.FirstOrDefault(x => x.PartId == partId);
                    tempParts.Remove(selectedPart);
                }
                else if (dialogresult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Save Button Click Event
        private void addProdSaveBtnClick(object sender, EventArgs e)
        {
            string textName = addProductNameBox.Text;
            int textInv = int.Parse(addProductInventoryBox.Text);
            decimal textPrice = Math.Round(decimal.Parse(addProductPriceBox.Text), 2, MidpointRounding.AwayFromZero);
            int textMin = int.Parse(addProductMinBox.Text);
            int textMax = int.Parse(addProductMaxBox.Text);

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

            //Create Product
            Product newProduct = new Product((Inventory.allProducts.Count + 1), textName, textInv, textPrice, textMin, textMax);

            //Populate Associated Parts for the new product
            foreach (Part part in tempParts)
            {
                newProduct.AddAssociatedPart(part);
            }

            //Populate Product DataGridView in Main Screen
            Inventory.AddProduct(newProduct);

            Close();
        }


        //Method to Check to Enable "Save" Button
        private void EnableSaveBtnCheck()
        {
            bool allValid = true;

            //Checks Name TextBox
            if (string.IsNullOrEmpty(addProductNameBox.Text))
            {
                addProductNameBox.BackColor = Color.Red;
                allValid = false;

            }
            else
            {
                addProductNameBox.BackColor = SystemColors.Window;
            }

            //Checks Inventory TextBox
            int userInv;
            if (int.TryParse(addProductInventoryBox.Text, out userInv))
            {
                addProductInventoryBox.BackColor = SystemColors.Window;
            }
            else
            {
                addProductInventoryBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Price/Cost TextBox
            decimal userPrice;
            if (decimal.TryParse(addProductPriceBox.Text, out userPrice))
            {
                addProductPriceBox.BackColor = SystemColors.Window;
            }
            else
            {
                addProductPriceBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Max TextBox
            int userMax;
            if (int.TryParse(addProductMaxBox.Text, out userMax))
            {
                addProductMaxBox.BackColor = SystemColors.Window;
            }
            else
            {
                addProductMaxBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Min TextBox
            int userMin;
            if (int.TryParse(addProductMinBox.Text, out userMin))
            {
                addProductMinBox.BackColor = SystemColors.Window;
            }
            else
            {
                addProductMinBox.BackColor = Color.Red;
                allValid = false;
            }

            addProductSaveBtn.Enabled = allValid;
        }
    }
}
