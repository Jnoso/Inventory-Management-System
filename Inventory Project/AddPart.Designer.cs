namespace Inventory_Project
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            addInHouseRadial = new RadioButton();
            addOutsorRadial = new RadioButton();
            addIdTextBox = new TextBox();
            addNameTextBox = new TextBox();
            addInvTextBox = new TextBox();
            addSourceTextBox = new TextBox();
            addMaxTextBox = new TextBox();
            addMinTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addCostTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            addPartLabelChange = new Label();
            addPartSaveButton = new Button();
            addPartCancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // addInHouseRadial
            // 
            addInHouseRadial.AutoSize = true;
            addInHouseRadial.Checked = true;
            addInHouseRadial.Location = new Point(135, 14);
            addInHouseRadial.Name = "addInHouseRadial";
            addInHouseRadial.Size = new Size(90, 24);
            addInHouseRadial.TabIndex = 1;
            addInHouseRadial.TabStop = true;
            addInHouseRadial.Text = "In-House";
            addInHouseRadial.UseVisualStyleBackColor = true;
            addInHouseRadial.Click += addInRadBtn;
            // 
            // addOutsorRadial
            // 
            addOutsorRadial.AutoSize = true;
            addOutsorRadial.Location = new Point(253, 14);
            addOutsorRadial.Name = "addOutsorRadial";
            addOutsorRadial.Size = new Size(106, 24);
            addOutsorRadial.TabIndex = 2;
            addOutsorRadial.Text = "Outsourced";
            addOutsorRadial.UseVisualStyleBackColor = true;
            addOutsorRadial.Click += addOutRadialBtn;
            // 
            // addIdTextBox
            // 
            addIdTextBox.Location = new Point(164, 74);
            addIdTextBox.Name = "addIdTextBox";
            addIdTextBox.ReadOnly = true;
            addIdTextBox.Size = new Size(153, 27);
            addIdTextBox.TabIndex = 3;
            // 
            // addNameTextBox
            // 
            addNameTextBox.Location = new Point(164, 123);
            addNameTextBox.Name = "addNameTextBox";
            addNameTextBox.Size = new Size(153, 27);
            addNameTextBox.TabIndex = 4;
            addNameTextBox.TextChanged += addNameText;
            // 
            // addInvTextBox
            // 
            addInvTextBox.Location = new Point(164, 174);
            addInvTextBox.Name = "addInvTextBox";
            addInvTextBox.Size = new Size(153, 27);
            addInvTextBox.TabIndex = 5;
            addInvTextBox.TextChanged += addInvText;
            // 
            // addSourceTextBox
            // 
            addSourceTextBox.Location = new Point(164, 306);
            addSourceTextBox.Name = "addSourceTextBox";
            addSourceTextBox.Size = new Size(153, 27);
            addSourceTextBox.TabIndex = 6;
            addSourceTextBox.TextChanged += addRadialBtnBox;
            // 
            // addMaxTextBox
            // 
            addMaxTextBox.Location = new Point(164, 263);
            addMaxTextBox.Name = "addMaxTextBox";
            addMaxTextBox.Size = new Size(78, 27);
            addMaxTextBox.TabIndex = 7;
            addMaxTextBox.TextChanged += addMaxText;
            // 
            // addMinTextBox
            // 
            addMinTextBox.Location = new Point(348, 263);
            addMinTextBox.Name = "addMinTextBox";
            addMinTextBox.Size = new Size(78, 27);
            addMinTextBox.TabIndex = 8;
            addMinTextBox.TextChanged += addMinText;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 77);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 9;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(87, 126);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(66, 177);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 11;
            label4.Text = "Inventory";
            // 
            // addCostTextBox
            // 
            addCostTextBox.Location = new Point(164, 219);
            addCostTextBox.Name = "addCostTextBox";
            addCostTextBox.Size = new Size(153, 27);
            addCostTextBox.TabIndex = 12;
            addCostTextBox.TextChanged += addPriceText;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(52, 222);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 13;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 266);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 14;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 266);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 15;
            label7.Text = "Min";
            // 
            // addPartLabelChange
            // 
            addPartLabelChange.AutoSize = true;
            addPartLabelChange.ImageAlign = ContentAlignment.MiddleRight;
            addPartLabelChange.Location = new Point(33, 309);
            addPartLabelChange.Name = "addPartLabelChange";
            addPartLabelChange.Size = new Size(84, 20);
            addPartLabelChange.TabIndex = 16;
            addPartLabelChange.Text = "Machine ID";
            // 
            // addPartSaveButton
            // 
            addPartSaveButton.Enabled = false;
            addPartSaveButton.Location = new Point(296, 366);
            addPartSaveButton.Name = "addPartSaveButton";
            addPartSaveButton.Size = new Size(63, 37);
            addPartSaveButton.TabIndex = 17;
            addPartSaveButton.Text = "Save";
            addPartSaveButton.UseVisualStyleBackColor = true;
            addPartSaveButton.Click += addPartSaveBtn;
            // 
            // addPartCancelButton
            // 
            addPartCancelButton.Location = new Point(375, 366);
            addPartCancelButton.Name = "addPartCancelButton";
            addPartCancelButton.Size = new Size(63, 37);
            addPartCancelButton.TabIndex = 18;
            addPartCancelButton.Text = "Cancel";
            addPartCancelButton.UseVisualStyleBackColor = true;
            addPartCancelButton.Click += addPartCancel;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(addPartCancelButton);
            Controls.Add(addPartSaveButton);
            Controls.Add(addPartLabelChange);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(addCostTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addMinTextBox);
            Controls.Add(addMaxTextBox);
            Controls.Add(addSourceTextBox);
            Controls.Add(addInvTextBox);
            Controls.Add(addNameTextBox);
            Controls.Add(addIdTextBox);
            Controls.Add(addOutsorRadial);
            Controls.Add(addInHouseRadial);
            Controls.Add(label1);
            Name = "AddPart";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton addInHouseRadial;
        private RadioButton addOutsorRadial;
        private TextBox addIdTextBox;
        private TextBox addNameTextBox;
        private TextBox addInvTextBox;
        private TextBox addSourceTextBox;
        private TextBox addMaxTextBox;
        private TextBox addMinTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox addCostTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label addPartLabelChange;
        private Button addPartSaveButton;
        private Button addPartCancelButton;
    }
}