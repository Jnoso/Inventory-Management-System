namespace Inventory_Project
{
    partial class ModifyPart
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
            modifyPartCancelButton = new Button();
            modifyPartSaveButton = new Button();
            modifyPartLabelChange = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            modifyCostTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            modifyMinTextBox = new TextBox();
            modifyMaxTextBox = new TextBox();
            modifySourceTextBox = new TextBox();
            modifyInvTextBox = new TextBox();
            modifyNameTextBox = new TextBox();
            modifyIdTextBox = new TextBox();
            modifyOutsorRadial = new RadioButton();
            modifyInHouseRadial = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // modifyPartCancelButton
            // 
            modifyPartCancelButton.Location = new Point(375, 366);
            modifyPartCancelButton.Name = "modifyPartCancelButton";
            modifyPartCancelButton.Size = new Size(63, 37);
            modifyPartCancelButton.TabIndex = 37;
            modifyPartCancelButton.Text = "Cancel";
            modifyPartCancelButton.UseVisualStyleBackColor = true;
            modifyPartCancelButton.Click += modifyPartCanBtn;
            // 
            // modifyPartSaveButton
            // 
            modifyPartSaveButton.Location = new Point(296, 366);
            modifyPartSaveButton.Name = "modifyPartSaveButton";
            modifyPartSaveButton.Size = new Size(63, 37);
            modifyPartSaveButton.TabIndex = 36;
            modifyPartSaveButton.Text = "Save";
            modifyPartSaveButton.UseVisualStyleBackColor = true;
            modifyPartSaveButton.Click += modSaveBtnClick;
            // 
            // modifyPartLabelChange
            // 
            modifyPartLabelChange.AutoSize = true;
            modifyPartLabelChange.ImageAlign = ContentAlignment.MiddleRight;
            modifyPartLabelChange.Location = new Point(42, 309);
            modifyPartLabelChange.Name = "modifyPartLabelChange";
            modifyPartLabelChange.Size = new Size(84, 20);
            modifyPartLabelChange.TabIndex = 35;
            modifyPartLabelChange.Text = "Machine ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 266);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 34;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 266);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 33;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(52, 222);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 32;
            label5.Text = "Price / Cost";
            // 
            // modifyCostTextBox
            // 
            modifyCostTextBox.Location = new Point(164, 219);
            modifyCostTextBox.Name = "modifyCostTextBox";
            modifyCostTextBox.Size = new Size(153, 27);
            modifyCostTextBox.TabIndex = 31;
            modifyCostTextBox.TextChanged += modCostBox;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(66, 177);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 30;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(87, 126);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 29;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 77);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 28;
            label2.Text = "ID";
            // 
            // modifyMinTextBox
            // 
            modifyMinTextBox.Location = new Point(348, 263);
            modifyMinTextBox.Name = "modifyMinTextBox";
            modifyMinTextBox.Size = new Size(78, 27);
            modifyMinTextBox.TabIndex = 27;
            modifyMinTextBox.TextChanged += modMinText;
            // 
            // modifyMaxTextBox
            // 
            modifyMaxTextBox.Location = new Point(164, 263);
            modifyMaxTextBox.Name = "modifyMaxTextBox";
            modifyMaxTextBox.Size = new Size(78, 27);
            modifyMaxTextBox.TabIndex = 26;
            modifyMaxTextBox.TextChanged += modMaxText;
            // 
            // modifySourceTextBox
            // 
            modifySourceTextBox.Location = new Point(164, 306);
            modifySourceTextBox.Name = "modifySourceTextBox";
            modifySourceTextBox.Size = new Size(153, 27);
            modifySourceTextBox.TabIndex = 25;
            modifySourceTextBox.TextChanged += modSourceBox;
            // 
            // modifyInvTextBox
            // 
            modifyInvTextBox.Location = new Point(164, 174);
            modifyInvTextBox.Name = "modifyInvTextBox";
            modifyInvTextBox.Size = new Size(153, 27);
            modifyInvTextBox.TabIndex = 24;
            modifyInvTextBox.TextChanged += modInvText;
            // 
            // modifyNameTextBox
            // 
            modifyNameTextBox.Location = new Point(164, 123);
            modifyNameTextBox.Name = "modifyNameTextBox";
            modifyNameTextBox.Size = new Size(153, 27);
            modifyNameTextBox.TabIndex = 23;
            modifyNameTextBox.TextChanged += modifyNameText;
            // 
            // modifyIdTextBox
            // 
            modifyIdTextBox.Location = new Point(164, 74);
            modifyIdTextBox.Name = "modifyIdTextBox";
            modifyIdTextBox.ReadOnly = true;
            modifyIdTextBox.Size = new Size(153, 27);
            modifyIdTextBox.TabIndex = 22;
            // 
            // modifyOutsorRadial
            // 
            modifyOutsorRadial.AutoSize = true;
            modifyOutsorRadial.Location = new Point(253, 14);
            modifyOutsorRadial.Name = "modifyOutsorRadial";
            modifyOutsorRadial.Size = new Size(106, 24);
            modifyOutsorRadial.TabIndex = 21;
            modifyOutsorRadial.Text = "Outsourced";
            modifyOutsorRadial.UseVisualStyleBackColor = true;
            modifyOutsorRadial.Click += modOutsourceRadial;
            // 
            // modifyInHouseRadial
            // 
            modifyInHouseRadial.AutoSize = true;
            modifyInHouseRadial.Checked = true;
            modifyInHouseRadial.Location = new Point(135, 14);
            modifyInHouseRadial.Name = "modifyInHouseRadial";
            modifyInHouseRadial.Size = new Size(90, 24);
            modifyInHouseRadial.TabIndex = 20;
            modifyInHouseRadial.TabStop = true;
            modifyInHouseRadial.Text = "In-House";
            modifyInHouseRadial.UseVisualStyleBackColor = true;
            modifyInHouseRadial.Click += modInHouseRadialClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 19;
            label1.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(modifyPartCancelButton);
            Controls.Add(modifyPartSaveButton);
            Controls.Add(modifyPartLabelChange);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(modifyCostTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modifyMinTextBox);
            Controls.Add(modifyMaxTextBox);
            Controls.Add(modifySourceTextBox);
            Controls.Add(modifyInvTextBox);
            Controls.Add(modifyNameTextBox);
            Controls.Add(modifyIdTextBox);
            Controls.Add(modifyOutsorRadial);
            Controls.Add(modifyInHouseRadial);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modifyPartCancelButton;
        private Button modifyPartSaveButton;
        private Label modifyPartLabelChange;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox modifyCostTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox modifyMinTextBox;
        private TextBox modifyMaxTextBox;
        private TextBox modifySourceTextBox;
        private TextBox modifyInvTextBox;
        private TextBox modifyNameTextBox;
        private TextBox modifyIdTextBox;
        private RadioButton modifyOutsorRadial;
        private RadioButton modifyInHouseRadial;
        private Label label1;
    }
}