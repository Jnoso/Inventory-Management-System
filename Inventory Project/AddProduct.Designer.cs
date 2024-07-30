namespace Inventory_Project
{
    partial class AddProduct
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
            label2 = new Label();
            addProductSearchBtn = new Button();
            addProductSearchBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            addProductIdText = new TextBox();
            addProductNameBox = new TextBox();
            addProductInventoryBox = new TextBox();
            addProductPriceBox = new TextBox();
            addProductMaxBox = new TextBox();
            addProductMinBox = new TextBox();
            label9 = new Label();
            addProductAddBtn = new Button();
            addProductDelBtn = new Button();
            addProductSaveBtn = new Button();
            addProductCancBtn = new Button();
            dgvAddProdAll = new DataGridView();
            dgvAddProdAsso = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAddProdAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddProdAsso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(143, 31);
            label1.TabIndex = 2;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 70);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 3;
            label2.Text = "All candidate Parts";
            // 
            // addProductSearchBtn
            // 
            addProductSearchBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductSearchBtn.Location = new Point(615, 42);
            addProductSearchBtn.Name = "addProductSearchBtn";
            addProductSearchBtn.Size = new Size(61, 29);
            addProductSearchBtn.TabIndex = 4;
            addProductSearchBtn.Text = "Search";
            addProductSearchBtn.UseVisualStyleBackColor = true;
            // 
            // addProductSearchBox
            // 
            addProductSearchBox.Location = new Point(693, 43);
            addProductSearchBox.Name = "addProductSearchBox";
            addProductSearchBox.Size = new Size(229, 27);
            addProductSearchBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 242);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 293);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 348);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Inventory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 395);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 9;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 452);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 10;
            label7.Text = "Max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 452);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 11;
            label8.Text = "Min";
            // 
            // addProductIdText
            // 
            addProductIdText.Location = new Point(146, 242);
            addProductIdText.Name = "addProductIdText";
            addProductIdText.ReadOnly = true;
            addProductIdText.Size = new Size(195, 27);
            addProductIdText.TabIndex = 12;
            // 
            // addProductNameBox
            // 
            addProductNameBox.Location = new Point(146, 293);
            addProductNameBox.Name = "addProductNameBox";
            addProductNameBox.Size = new Size(195, 27);
            addProductNameBox.TabIndex = 13;
            addProductNameBox.TextChanged += addProductNameTextChange;
            // 
            // addProductInventoryBox
            // 
            addProductInventoryBox.Location = new Point(146, 345);
            addProductInventoryBox.Name = "addProductInventoryBox";
            addProductInventoryBox.Size = new Size(195, 27);
            addProductInventoryBox.TabIndex = 14;
            addProductInventoryBox.TextChanged += addInvTextBoxChange;
            // 
            // addProductPriceBox
            // 
            addProductPriceBox.Location = new Point(146, 392);
            addProductPriceBox.Name = "addProductPriceBox";
            addProductPriceBox.Size = new Size(195, 27);
            addProductPriceBox.TabIndex = 15;
            addProductPriceBox.TextChanged += addProdPriceTextBoxChange;
            // 
            // addProductMaxBox
            // 
            addProductMaxBox.Location = new Point(95, 449);
            addProductMaxBox.Name = "addProductMaxBox";
            addProductMaxBox.Size = new Size(105, 27);
            addProductMaxBox.TabIndex = 16;
            addProductMaxBox.TextChanged += addProdMaxTextBoxChange;
            // 
            // addProductMinBox
            // 
            addProductMinBox.Location = new Point(278, 449);
            addProductMinBox.Name = "addProductMinBox";
            addProductMinBox.Size = new Size(105, 27);
            addProductMinBox.TabIndex = 17;
            addProductMinBox.TextChanged += addProdMinTextBoxChange;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(437, 348);
            label9.Name = "label9";
            label9.Size = new Size(204, 17);
            label9.TabIndex = 18;
            label9.Text = "Parts Associated with this Product";
            // 
            // addProductAddBtn
            // 
            addProductAddBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductAddBtn.Location = new Point(848, 319);
            addProductAddBtn.Name = "addProductAddBtn";
            addProductAddBtn.Size = new Size(56, 29);
            addProductAddBtn.TabIndex = 20;
            addProductAddBtn.Text = "Add";
            addProductAddBtn.UseVisualStyleBackColor = true;
            addProductAddBtn.Click += addPartToAssoPart;
            // 
            // addProductDelBtn
            // 
            addProductDelBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductDelBtn.Location = new Point(848, 602);
            addProductDelBtn.Name = "addProductDelBtn";
            addProductDelBtn.Size = new Size(56, 29);
            addProductDelBtn.TabIndex = 21;
            addProductDelBtn.Text = "Delete";
            addProductDelBtn.UseVisualStyleBackColor = true;
            addProductDelBtn.Click += delAssoPartBtn;
            // 
            // addProductSaveBtn
            // 
            addProductSaveBtn.Enabled = false;
            addProductSaveBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductSaveBtn.Location = new Point(772, 637);
            addProductSaveBtn.Name = "addProductSaveBtn";
            addProductSaveBtn.Size = new Size(56, 29);
            addProductSaveBtn.TabIndex = 22;
            addProductSaveBtn.Text = "Save";
            addProductSaveBtn.UseVisualStyleBackColor = true;
            addProductSaveBtn.Click += addProdSaveBtnClick;
            // 
            // addProductCancBtn
            // 
            addProductCancBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductCancBtn.Location = new Point(848, 637);
            addProductCancBtn.Name = "addProductCancBtn";
            addProductCancBtn.Size = new Size(56, 29);
            addProductCancBtn.TabIndex = 23;
            addProductCancBtn.Text = "Cancel";
            addProductCancBtn.UseVisualStyleBackColor = true;
            addProductCancBtn.Click += addProdCancBtnClick;
            // 
            // dgvAddProdAll
            // 
            dgvAddProdAll.AllowUserToAddRows = false;
            dgvAddProdAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddProdAll.Location = new Point(437, 90);
            dgvAddProdAll.MultiSelect = false;
            dgvAddProdAll.Name = "dgvAddProdAll";
            dgvAddProdAll.ReadOnly = true;
            dgvAddProdAll.RowHeadersVisible = false;
            dgvAddProdAll.RowHeadersWidth = 51;
            dgvAddProdAll.RowTemplate.Height = 29;
            dgvAddProdAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddProdAll.Size = new Size(485, 213);
            dgvAddProdAll.TabIndex = 24;
            // 
            // dgvAddProdAsso
            // 
            dgvAddProdAsso.AllowUserToAddRows = false;
            dgvAddProdAsso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddProdAsso.Location = new Point(437, 368);
            dgvAddProdAsso.MultiSelect = false;
            dgvAddProdAsso.Name = "dgvAddProdAsso";
            dgvAddProdAsso.ReadOnly = true;
            dgvAddProdAsso.RowHeadersVisible = false;
            dgvAddProdAsso.RowHeadersWidth = 51;
            dgvAddProdAsso.RowTemplate.Height = 29;
            dgvAddProdAsso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddProdAsso.Size = new Size(485, 223);
            dgvAddProdAsso.TabIndex = 25;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 678);
            Controls.Add(dgvAddProdAsso);
            Controls.Add(dgvAddProdAll);
            Controls.Add(addProductCancBtn);
            Controls.Add(addProductSaveBtn);
            Controls.Add(addProductDelBtn);
            Controls.Add(addProductAddBtn);
            Controls.Add(label9);
            Controls.Add(addProductMinBox);
            Controls.Add(addProductMaxBox);
            Controls.Add(addProductPriceBox);
            Controls.Add(addProductInventoryBox);
            Controls.Add(addProductNameBox);
            Controls.Add(addProductIdText);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addProductSearchBox);
            Controls.Add(addProductSearchBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dgvAddProdAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddProdAsso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button addProductSearchBtn;
        private TextBox addProductSearchBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox addProductIdText;
        private TextBox addProductNameBox;
        private TextBox addProductInventoryBox;
        private TextBox addProductPriceBox;
        private TextBox addProductMaxBox;
        private TextBox addProductMinBox;
        private Label label9;
        private Button addProductAddBtn;
        private Button addProductDelBtn;
        private Button addProductSaveBtn;
        private Button addProductCancBtn;
        private DataGridView dgvAddProdAll;
        private DataGridView dgvAddProdAsso;
    }
}