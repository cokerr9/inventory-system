namespace inventory_system.View
{
    partial class uc_Purchase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPurchaseId = new System.Windows.Forms.Label();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.lblAccessory = new System.Windows.Forms.Label();
            this.cboxAccessory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboxBrand = new System.Windows.Forms.ComboBox();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboxSupplier = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgPurchase = new System.Windows.Forms.DataGridView();
            this.colPurchaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccessory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Sienna;
            this.lblTitle.Location = new System.Drawing.Point(460, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Purchase";
            // 
            // lblPurchaseId
            // 
            this.lblPurchaseId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPurchaseId.AutoSize = true;
            this.lblPurchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseId.Location = new System.Drawing.Point(80, 95);
            this.lblPurchaseId.Name = "lblPurchaseId";
            this.lblPurchaseId.Size = new System.Drawing.Size(130, 25);
            this.lblPurchaseId.TabIndex = 1;
            this.lblPurchaseId.Text = "Purchase ID";
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseId.Location = new System.Drawing.Point(80, 125);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(440, 34);
            this.txtPurchaseId.TabIndex = 2;
            // 
            // lblAccessory
            // 
            this.lblAccessory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccessory.AutoSize = true;
            this.lblAccessory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessory.Location = new System.Drawing.Point(80, 175);
            this.lblAccessory.Name = "lblAccessory";
            this.lblAccessory.Size = new System.Drawing.Size(175, 25);
            this.lblAccessory.TabIndex = 3;
            this.lblAccessory.Text = "Accessory Name";
            // 
            // cboxAccessory
            // 
            this.cboxAccessory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxAccessory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAccessory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAccessory.FormattingEnabled = true;
            this.cboxAccessory.Location = new System.Drawing.Point(80, 205);
            this.cboxAccessory.Name = "cboxAccessory";
            this.cboxAccessory.Size = new System.Drawing.Size(440, 37);
            this.cboxAccessory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(80, 255);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(162, 25);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category Name";
            // 
            // cboxCategory
            // 
            this.cboxCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(80, 285);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(440, 37);
            this.cboxCategory.TabIndex = 6;
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(80, 335);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(131, 25);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Brand Name";
            // 
            // cboxBrand
            // 
            this.cboxBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBrand.FormattingEnabled = true;
            this.cboxBrand.Location = new System.Drawing.Point(80, 365);
            this.cboxBrand.Name = "cboxBrand";
            this.cboxBrand.Size = new System.Drawing.Size(440, 37);
            this.cboxBrand.TabIndex = 8;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(80, 415);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(154, 25);
            this.lblPurchaseDate.TabIndex = 9;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(80, 445);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(440, 34);
            this.dtpPurchaseDate.TabIndex = 10;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(600, 95);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(154, 25);
            this.lblSupplier.TabIndex = 11;
            this.lblSupplier.Text = "Supplier Name";
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSupplier.FormattingEnabled = true;
            this.cboxSupplier.Location = new System.Drawing.Point(600, 125);
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.Size = new System.Drawing.Size(440, 37);
            this.cboxSupplier.TabIndex = 12;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(600, 175);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(140, 25);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Unit Price ($)";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(600, 205);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(440, 34);
            this.txtUnitPrice.TabIndex = 14;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(600, 255);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(93, 25);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(600, 285);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(440, 34);
            this.txtQty.TabIndex = 16;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(600, 335);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(147, 25);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "Total Price ($)";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(600, 365);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(440, 34);
            this.txtTotalPrice.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(235, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 44);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(405, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(575, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(745, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 44);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dgPurchase
            // 
            this.dgPurchase.AllowUserToAddRows = false;
            this.dgPurchase.AllowUserToDeleteRows = false;
            this.dgPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPurchaseId,
            this.colAccessory,
            this.colSupplier,
            this.colCategory,
            this.colBrand,
            this.colUnitPrice,
            this.colQty,
            this.colTotal,
            this.colPurchaseDate});
            this.dgPurchase.Location = new System.Drawing.Point(80, 570);
            this.dgPurchase.Name = "dgPurchase";
            this.dgPurchase.ReadOnly = true;
            this.dgPurchase.RowHeadersWidth = 51;
            this.dgPurchase.RowTemplate.Height = 24;
            this.dgPurchase.Size = new System.Drawing.Size(960, 280);
            this.dgPurchase.TabIndex = 23;
            // 
            // colPurchaseId
            // 
            this.colPurchaseId.DataPropertyName = "PurchaseId";
            this.colPurchaseId.HeaderText = "Purchase ID";
            this.colPurchaseId.MinimumWidth = 6;
            this.colPurchaseId.Name = "colPurchaseId";
            this.colPurchaseId.ReadOnly = true;
            // 
            // colAccessory
            // 
            this.colAccessory.DataPropertyName = "AccesoryId";
            this.colAccessory.HeaderText = "Accessory";
            this.colAccessory.MinimumWidth = 6;
            this.colAccessory.Name = "colAccessory";
            this.colAccessory.ReadOnly = true;
            // 
            // colSupplier
            // 
            this.colSupplier.DataPropertyName = "SupplierId";
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.MinimumWidth = 6;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "CategoryId";
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "BrandId";
            this.colBrand.HeaderText = "Brand";
            this.colBrand.MinimumWidth = 6;
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price ($)";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Total ($)";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.DataPropertyName = "Purchase_date";
            this.colPurchaseDate.HeaderText = "Purchase Date";
            this.colPurchaseDate.MinimumWidth = 6;
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.ReadOnly = true;
            // 
            // uc_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPurchase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.cboxSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.cboxBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboxAccessory);
            this.Controls.Add(this.lblAccessory);
            this.Controls.Add(this.txtPurchaseId);
            this.Controls.Add(this.lblPurchaseId);
            this.Controls.Add(this.lblTitle);
            this.Name = "uc_Purchase";
            this.Size = new System.Drawing.Size(1146, 893);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPurchaseId;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.Label lblAccessory;
        private System.Windows.Forms.ComboBox cboxAccessory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboxBrand;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboxSupplier;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccessory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseDate;
    }
}
