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
    public partial class ModifyPart : Form
    {
        private Form1 mainForm;
        public ModifyPart(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            FillTextBox();

        }

        //Cancel Btn Click Event
        private void modifyPartCanBtn(object sender, EventArgs e)
        {
            Close();
        }

        //Method to fill Modify TextBoxes when it first Initializes
        public void FillTextBox()
        {

            //Take selected Row's Part Id from MainScreen(Form1)
            int partid = (int)mainForm.dgvPart.CurrentRow.Cells["PartId"].Value;

            //Return the InHouse/OutSource value using Method InHouseOutSource
            string selection = InHouseOutSource(partid, out string typeOfSource);

            foreach (var part in Inventory.allParts)
            {
                //Initializes the field boxes with the selected row data
                if (part.PartId == partid)
                {
                    modifyIdTextBox.Text = partid.ToString();
                    modifyNameTextBox.Text = part.Name;
                    modifyInvTextBox.Text = part.InStock.ToString();
                    modifyCostTextBox.Text = part.Price.ToString();
                    modifyMaxTextBox.Text = part.Max.ToString();
                    modifyMinTextBox.Text = part.Min.ToString();

                    //checks if it is InHouse or OutSource and changes bottom label and radial button.
                    if (typeOfSource == "InHouse")
                    {
                        modifyInHouseRadial.Checked = true;
                        modifyOutsorRadial.Checked = false;
                        modifyPartLabelChange.Text = "Machine ID";
                        modifySourceTextBox.Text = selection;
                    }
                    else if (typeOfSource == "OutSource")
                    {
                        modifyOutsorRadial.Checked = true;
                        modifyInHouseRadial.Checked = false;
                        modifyPartLabelChange.Text = "Company Name";
                        modifySourceTextBox.Text = selection;
                    }
                }
            }
        }

        //Method to see if selected datagridview part is InHouse or OutSource
        private static string InHouseOutSource(int partid, out string typeOfSource)
        {
            foreach (var part in Inventory.allParts)
            {
                if (part.PartId == partid)
                {
                    if (part is OutSource outSourcePart)
                    {
                        typeOfSource = "OutSource";
                        return outSourcePart.OutSourceCompanyName;
                    }
                    else if (part is InHouse inHousePart)
                    {
                        typeOfSource = "InHouse";
                        return inHousePart.InHouseMachineId.ToString();
                    }
                }
            }
            typeOfSource = "InHouse";
            return null;
        }

        //When Name Text is Changed
        private void modifyNameText(object sender, EventArgs e)
        {
            CheckTextBoxValid();
        }

        //When Inventory Text is Changed
        private void modInvText(object sender, EventArgs e)
        {
            CheckTextBoxValid();
        }

        //When Price/Cost Text is Changed
        private void modCostBox(object sender, EventArgs e)
        {
            CheckTextBoxValid();
        }

        //When Max Text is Changed
        private void modMaxText(object sender, EventArgs e)
        {
            CheckTextBoxValid();
        }

        //When Min Text is Changed
        private void modMinText(object sender, EventArgs e)
        {
            CheckTextBoxValid();
        }

        //When InHouse/OutSource Text is Changed
        private void modSourceBox(object sender, EventArgs e)
        {
            CheckTextBoxValid();
        }

        //Method for Checking Each Text box
        private void CheckTextBoxValid()
        {
            bool allTextValid = true;

            //Checks Name Textbox
            if (string.IsNullOrEmpty(modifyNameTextBox.Text))
            {
                modifyNameTextBox.BackColor = Color.Red;
                allTextValid = false;
            }
            else
            {
                modifyNameTextBox.BackColor = SystemColors.Window;
            }

            //Checks Inventory Textbox
            int userInv;
            if (int.TryParse(modifyInvTextBox.Text, out userInv))
            {
                modifyInvTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyInvTextBox.BackColor = Color.Red;
                allTextValid = false;
            }

            //Checks Price/Cost Textbox
            decimal userPrice;
            if (decimal.TryParse(modifyCostTextBox.Text, out userPrice))
            {
                modifyCostTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyCostTextBox.BackColor = Color.Red;
                allTextValid = false;
            }

            //Checks Max Textbox
            int userMax;
            if (int.TryParse(modifyMaxTextBox.Text, out userMax))
            {
                modifyMaxTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyMaxTextBox.BackColor = Color.Red;
                allTextValid = false;
            }

            //Checks Min Textbox
            int userMin;
            if (int.TryParse(modifyMinTextBox.Text, out userMin))
            {
                modifyMinTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                modifyMinTextBox.BackColor = Color.Red;
                allTextValid = false;
            }

            //Checks Radial Button and TextBox
            if (modifyInHouseRadial.Checked == true)
            {
                int userMachineId;
                if (int.TryParse(modifySourceTextBox.Text, out userMachineId))
                {
                    modifySourceTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    modifySourceTextBox.BackColor = Color.Red;
                    allTextValid = false;
                }
            }
            else if (modifyOutsorRadial.Checked == true)
            {
                if (string.IsNullOrEmpty(modifySourceTextBox.Text))
                {
                    modifySourceTextBox.BackColor = Color.Red;
                    allTextValid = false;
                }
                else
                {
                    modifySourceTextBox.BackColor = SystemColors.Window;
                }
            }

            modifyPartSaveButton.Enabled = allTextValid;
        }

        //When OutSource Radial Button is Clicked
        private void modOutsourceRadial(object sender, EventArgs e)
        {
            modifyPartLabelChange.Text = "Company Name";
            CheckTextBoxValid();
        }

        //When InHouse Radial Button is Clicked
        private void modInHouseRadialClick(object sender, EventArgs e)
        {
            modifyPartLabelChange.Text = "Machine ID";
            CheckTextBoxValid();
        }

        //Save Button Click Event
        private void modSaveBtnClick(object sender, EventArgs e)
        {
            int partid = int.Parse(modifyIdTextBox.Text);
            string textName = modifyNameTextBox.Text;
            int textInv = int.Parse(modifyInvTextBox.Text);
            decimal textPrice = decimal.Parse(modifyCostTextBox.Text);
            int textMin = int.Parse(modifyMinTextBox.Text);
            int textMax = int.Parse(modifyMaxTextBox.Text);

            //Error Check
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

            //Create new InHouse Parameters and update it to the current selected part
            if (modifyInHouseRadial.Checked == true)
            {
                var changedInHousePart = new InHouse(partid, textName, textInv, decimal.Round(textPrice, 2, MidpointRounding.AwayFromZero),
                    textMin, textMax, int.Parse(modifySourceTextBox.Text));
                Inventory.UpdatePart(partid, changedInHousePart);
                mainForm.dgvPart.Refresh();
                Close();
            }
            //Create new Outsource Parameters and update it to the current selected part
            else if (modifyOutsorRadial.Checked == true)
            {
                var changedOutsourcePart = new OutSource(partid, textName, textInv, decimal.Round(textPrice, 2, MidpointRounding.AwayFromZero),
                    textMin, textMax, modifySourceTextBox.Text);
                Inventory.UpdatePart(partid, changedOutsourcePart);
                mainForm.dgvPart.Refresh();
                Close();
            }
        }
    }
}
