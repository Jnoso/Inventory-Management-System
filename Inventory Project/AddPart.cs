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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            addNameTextBox.BackColor = Color.Red;
            addInvTextBox.BackColor = Color.Red;
            addCostTextBox.BackColor = Color.Red;
            addMaxTextBox.BackColor = Color.Red;
            addMinTextBox.BackColor = Color.Red;
            addSourceTextBox.BackColor = Color.Red;
        }

        //Cancel Button Click Event
        private void addPartCancel(object sender, EventArgs e)
        {
            Close();
        }

        //Name TextBox Change Color and Disable Save Button
        private void addNameText(object sender, EventArgs e)
        {
            CheckTextboxValid();
        }

        //Inventory TextBox Change Color and Disable Save Button
        private void addInvText(object sender, EventArgs e)
        {
            CheckTextboxValid();
        }

        //Price/Cost TextBox Change Color and Disable Save Button
        private void addPriceText(object sender, EventArgs e)
        {
            CheckTextboxValid();
        }

        //Max TextBox Change Color and Disable Save Button
        private void addMaxText(object sender, EventArgs e)
        {
            CheckTextboxValid();
        }

        //Min TextBox Change Color and Disable Save Button
        private void addMinText(object sender, EventArgs e)
        {
            CheckTextboxValid();
        }

        //InHouse or OutSource Text Box and Disable Save Button
        private void addRadialBtnBox(object sender, EventArgs e)
        {
            CheckTextboxValid();
        }

        //Function to check if all textbox are valid and Enables Save Button
        private void CheckTextboxValid()
        {
            bool allValid = true;

            //Checks Name TextBox
            if (string.IsNullOrEmpty(addNameTextBox.Text))
            {
                addNameTextBox.BackColor = Color.Red;
                allValid = false;

            }
            else
            {
                addNameTextBox.BackColor = SystemColors.Window;
            }

            //Checks Inventory TextBox
            int userInv;
            if (int.TryParse(addInvTextBox.Text, out userInv))
            {
                addInvTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                addInvTextBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Price/Cost TextBox
            decimal userPrice;
            if (decimal.TryParse(addCostTextBox.Text, out userPrice))
            {
                addCostTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                addCostTextBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Max TextBox
            int userMax;
            if (int.TryParse(addMaxTextBox.Text, out userMax))
            {
                addMaxTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                addMaxTextBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Min TextBox
            int userMin;
            if (int.TryParse(addMinTextBox.Text, out userMin))
            {
                addMinTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                addMinTextBox.BackColor = Color.Red;
                allValid = false;
            }

            //Checks Radial Button Selected
            if (addInHouseRadial.Checked == true)
            {
                int userMachineId;
                if (int.TryParse(addSourceTextBox.Text, out userMachineId))
                {
                    addSourceTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    addSourceTextBox.BackColor = Color.Red;
                    allValid = false;
                }
            }
            else if (addOutsorRadial.Checked == true)
            {
                if (string.IsNullOrEmpty(addSourceTextBox.Text))
                {
                    addSourceTextBox.BackColor = Color.Red;
                    allValid = false;
                }
                else
                {
                    addSourceTextBox.BackColor = SystemColors.Window;
                }
            }

            addPartSaveButton.Enabled = allValid;
        }

        //OutSource Radial Button Click Event
        private void addOutRadialBtn(object sender, EventArgs e)
        {
            addPartLabelChange.Text = "Company Name";
            CheckTextboxValid();
        }

        //InHouse Radial Button Click Event
        private void addInRadBtn(object sender, EventArgs e)
        {
            addPartLabelChange.Text = "Machine ID";
            CheckTextboxValid();
        }

        //Save Button Event
        private void addPartSaveBtn(object sender, EventArgs e)
        {
            string textName = addNameTextBox.Text;
            int textInv = int.Parse(addInvTextBox.Text);
            decimal textPrice = decimal.Parse(addCostTextBox.Text);
            int textMin = int.Parse(addMinTextBox.Text);
            int textMax = int.Parse(addMaxTextBox.Text);
            
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
            
            
            //Create InHouse parameter and add it to BindingList allParts
            if (addInHouseRadial.Checked == true)
            {
                var inHousePart = new InHouse((Inventory.allParts.Count + 1), textName, textInv, decimal.Round(textPrice, 2, MidpointRounding.AwayFromZero)
                    , textMin, textMax, int.Parse(addSourceTextBox.Text));
                Inventory.PartAdd(inHousePart);
                Close();
            }

            //Create OutSource parameter and add it to BindingList allParts
            else if (addOutsorRadial.Checked == true)
            {
                var outSourcePart = new OutSource((Inventory.allParts.Count + 1), textName, textInv, decimal.Round(textPrice, 2, MidpointRounding.AwayFromZero),
                    textMin, textMax, (addSourceTextBox.Text));
                Inventory.PartAdd(outSourcePart);
                Close();
            }
        }
    }
}
