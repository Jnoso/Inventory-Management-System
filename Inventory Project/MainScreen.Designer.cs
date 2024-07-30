namespace Inventory_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            partSearchButton = new Button();
            partsID = new TextBox();
            productsID = new TextBox();
            productSearchButton = new Button();
            addPartBtn = new Button();
            modifyPartBtn = new Button();
            delPartBtn = new Button();
            delProductBtn = new Button();
            modifyProductBtn = new Button();
            addProductBtn = new Button();
            exitMainBtn = new Button();
            dgvPart = new DataGridView();
            dgvProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(485, 46);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 3;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(771, 110);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 4;
            label3.Text = "Products";
            // 
            // partSearchButton
            // 
            partSearchButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            partSearchButton.Location = new Point(457, 106);
            partSearchButton.Name = "partSearchButton";
            partSearchButton.Size = new Size(59, 27);
            partSearchButton.TabIndex = 5;
            partSearchButton.Text = "Search";
            partSearchButton.UseVisualStyleBackColor = true;
            partSearchButton.Click += partSrchBtn;
            // 
            // partsID
            // 
            partsID.Location = new Point(534, 106);
            partsID.Name = "partsID";
            partsID.Size = new Size(180, 27);
            partsID.TabIndex = 6;
            // 
            // productsID
            // 
            productsID.Location = new Point(1293, 110);
            productsID.Name = "productsID";
            productsID.Size = new Size(180, 27);
            productsID.TabIndex = 8;
            // 
            // productSearchButton
            // 
            productSearchButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            productSearchButton.Location = new Point(1216, 110);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(59, 27);
            productSearchButton.TabIndex = 7;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = true;
            // 
            // addPartBtn
            // 
            addPartBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addPartBtn.Location = new Point(531, 539);
            addPartBtn.Name = "addPartBtn";
            addPartBtn.Size = new Size(57, 30);
            addPartBtn.TabIndex = 9;
            addPartBtn.Text = "Add";
            addPartBtn.UseVisualStyleBackColor = true;
            addPartBtn.Click += addPartClick;
            // 
            // modifyPartBtn
            // 
            modifyPartBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            modifyPartBtn.Location = new Point(594, 539);
            modifyPartBtn.Name = "modifyPartBtn";
            modifyPartBtn.Size = new Size(57, 30);
            modifyPartBtn.TabIndex = 10;
            modifyPartBtn.Text = "Modify";
            modifyPartBtn.UseVisualStyleBackColor = true;
            modifyPartBtn.Click += addPartModBtn;
            // 
            // delPartBtn
            // 
            delPartBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            delPartBtn.Location = new Point(657, 539);
            delPartBtn.Name = "delPartBtn";
            delPartBtn.Size = new Size(57, 30);
            delPartBtn.TabIndex = 11;
            delPartBtn.Text = "Delete";
            delPartBtn.UseVisualStyleBackColor = true;
            delPartBtn.Click += delPartBtnClick;
            // 
            // delProductBtn
            // 
            delProductBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            delProductBtn.Location = new Point(1416, 539);
            delProductBtn.Name = "delProductBtn";
            delProductBtn.Size = new Size(57, 30);
            delProductBtn.TabIndex = 14;
            delProductBtn.Text = "Delete";
            delProductBtn.UseVisualStyleBackColor = true;
            // 
            // modifyProductBtn
            // 
            modifyProductBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            modifyProductBtn.Location = new Point(1353, 539);
            modifyProductBtn.Name = "modifyProductBtn";
            modifyProductBtn.Size = new Size(57, 30);
            modifyProductBtn.TabIndex = 13;
            modifyProductBtn.Text = "Modify";
            modifyProductBtn.UseVisualStyleBackColor = true;
            // 
            // addProductBtn
            // 
            addProductBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductBtn.Location = new Point(1290, 539);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(57, 30);
            addProductBtn.TabIndex = 12;
            addProductBtn.Text = "Add";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtnClick;
            // 
            // exitMainBtn
            // 
            exitMainBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            exitMainBtn.Location = new Point(1416, 592);
            exitMainBtn.Name = "exitMainBtn";
            exitMainBtn.Size = new Size(57, 30);
            exitMainBtn.TabIndex = 15;
            exitMainBtn.Text = "Exit";
            exitMainBtn.UseVisualStyleBackColor = true;
            exitMainBtn.Click += exitBtnClick;
            // 
            // dgvPart
            // 
            dgvPart.AllowUserToAddRows = false;
            dgvPart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPart.Location = new Point(12, 145);
            dgvPart.MultiSelect = false;
            dgvPart.Name = "dgvPart";
            dgvPart.ReadOnly = true;
            dgvPart.RowHeadersVisible = false;
            dgvPart.RowHeadersWidth = 51;
            dgvPart.RowTemplate.Height = 29;
            dgvPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPart.Size = new Size(702, 376);
            dgvPart.TabIndex = 16;
            dgvPart.DataBindingComplete += partsBindingComplete;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(771, 145);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(702, 376);
            dgvProduct.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 695);
            Controls.Add(dgvProduct);
            Controls.Add(dgvPart);
            Controls.Add(exitMainBtn);
            Controls.Add(delProductBtn);
            Controls.Add(modifyProductBtn);
            Controls.Add(addProductBtn);
            Controls.Add(delPartBtn);
            Controls.Add(modifyPartBtn);
            Controls.Add(addPartBtn);
            Controls.Add(productsID);
            Controls.Add(productSearchButton);
            Controls.Add(partsID);
            Controls.Add(partSearchButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dgvPart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button partSearchButton;
        private TextBox partsID;
        private TextBox productsID;
        private Button productSearchButton;
        private Button addPartBtn;
        private Button modifyPartBtn;
        private Button delPartBtn;
        private Button delProductBtn;
        private Button modifyProductBtn;
        private Button addProductBtn;
        private Button exitMainBtn;
        public DataGridView dgvPart;
        public DataGridView dgvProduct;
    }
}
