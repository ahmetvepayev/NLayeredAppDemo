namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbxAddUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddUnitsInStock = new System.Windows.Forms.Label();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitsInStock = new System.Windows.Forms.Label();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AllowUserToAddRows = false;
            this.dgwProduct.AllowUserToDeleteRows = false;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 207);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(997, 302);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(997, 83);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye gore ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(101, 31);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(230, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(35, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 101);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(997, 100);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Urun adina gore ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(101, 43);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(230, 22);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(35, 46);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(60, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Urun adi:";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.cbxAddCategory);
            this.gbxAddProduct.Controls.Add(this.btnAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxAddUnitsInStock);
            this.gbxAddProduct.Controls.Add(this.tbxAddUnitPrice);
            this.gbxAddProduct.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductName);
            this.gbxAddProduct.Controls.Add(this.lblAddUnitsInStock);
            this.gbxAddProduct.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblAddUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblAddCategory);
            this.gbxAddProduct.Controls.Add(this.lblAddProductName);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 525);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(438, 182);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Yeni urun ekle";
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(10, 102);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(187, 24);
            this.cbxAddCategory.TabIndex = 4;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(247, 146);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(171, 30);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbxAddUnitsInStock
            // 
            this.tbxAddUnitsInStock.Location = new System.Drawing.Point(247, 104);
            this.tbxAddUnitsInStock.Name = "tbxAddUnitsInStock";
            this.tbxAddUnitsInStock.Size = new System.Drawing.Size(171, 22);
            this.tbxAddUnitsInStock.TabIndex = 9;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(10, 153);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(187, 22);
            this.tbxAddUnitPrice.TabIndex = 8;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(247, 42);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(171, 22);
            this.tbxAddQuantityPerUnit.TabIndex = 6;
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(10, 42);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(187, 22);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // lblAddUnitsInStock
            // 
            this.lblAddUnitsInStock.AutoSize = true;
            this.lblAddUnitsInStock.Location = new System.Drawing.Point(244, 84);
            this.lblAddUnitsInStock.Name = "lblAddUnitsInStock";
            this.lblAddUnitsInStock.Size = new System.Drawing.Size(72, 16);
            this.lblAddUnitsInStock.TabIndex = 4;
            this.lblAddUnitsInStock.Text = "Stok adedi";
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(244, 22);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(75, 16);
            this.lblAddQuantityPerUnit.TabIndex = 3;
            this.lblAddQuantityPerUnit.Text = "Birim adedi";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(7, 133);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(36, 16);
            this.lblAddUnitPrice.TabIndex = 2;
            this.lblAddUnitPrice.Text = "Fiyat";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(6, 75);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(57, 16);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Kategori";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(7, 22);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(57, 16);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Urun adi";
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitsInStock);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateUnitsInStock);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(571, 525);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(438, 182);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Urun guncelle";
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(10, 102);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(187, 24);
            this.cbxUpdateCategory.TabIndex = 4;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(247, 146);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(171, 30);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Guncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(247, 104);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(171, 22);
            this.tbxUpdateUnitsInStock.TabIndex = 9;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(10, 153);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(187, 22);
            this.tbxUpdateUnitPrice.TabIndex = 8;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(247, 42);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(171, 22);
            this.tbxUpdateQuantityPerUnit.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(10, 42);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(187, 22);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateUnitsInStock
            // 
            this.lblUpdateUnitsInStock.AutoSize = true;
            this.lblUpdateUnitsInStock.Location = new System.Drawing.Point(244, 84);
            this.lblUpdateUnitsInStock.Name = "lblUpdateUnitsInStock";
            this.lblUpdateUnitsInStock.Size = new System.Drawing.Size(72, 16);
            this.lblUpdateUnitsInStock.TabIndex = 4;
            this.lblUpdateUnitsInStock.Text = "Stok adedi";
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(244, 22);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(75, 16);
            this.lblUpdateQuantityPerUnit.TabIndex = 3;
            this.lblUpdateQuantityPerUnit.Text = "Birim adedi";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(7, 133);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(36, 16);
            this.lblUpdateUnitPrice.TabIndex = 2;
            this.lblUpdateUnitPrice.Text = "Fiyat";
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(6, 75);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(57, 16);
            this.lblUpdateCategory.TabIndex = 1;
            this.lblUpdateCategory.Text = "Kategori";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(7, 22);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(57, 16);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Urun adi";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(475, 525);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 38);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 719);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddUnitsInStock;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbxAddUnitsInStock;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateUnitsInStock;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Button btnRemove;
    }
}

