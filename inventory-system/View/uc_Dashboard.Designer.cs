namespace inventory_system.View
{
    partial class uc_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cardAccessories = new System.Windows.Forms.Panel();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblTotalAccessories = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.cardCategories = new System.Windows.Forms.Panel();
            this.lblTotalModelsSub = new System.Windows.Forms.Label();
            this.lblTotalModels = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.cardSuppliers = new System.Windows.Forms.Panel();
            this.lblTotalBrandsSub = new System.Windows.Forms.Label();
            this.lblTotalBrands = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.cardPurchases = new System.Windows.Forms.Panel();
            this.lblTotalPurchasesSub = new System.Windows.Forms.Label();
            this.lblTotalPurchases = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.dgvDashboardAccessories = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.lblFilterSummary = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cboxFilterCategory = new System.Windows.Forms.ComboBox();
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.cboxFilterBrand = new System.Windows.Forms.ComboBox();
            this.lblFilterBrand = new System.Windows.Forms.Label();
            this.cboxFilterModel = new System.Windows.Forms.ComboBox();
            this.lblFilterModel = new System.Windows.Forms.Label();
            this.txtSearchAccessory = new System.Windows.Forms.TextBox();
            this.lblFilterAccessory = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.cardAccessories.SuspendLayout();
            this.cardCategories.SuspendLayout();
            this.cardSuppliers.SuspendLayout();
            this.cardPurchases.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardAccessories)).BeginInit();
            this.pnlFilterBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Sienna;
            this.lblTitle.Location = new System.Drawing.Point(26, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Overview";
            // 
            // cardAccessories
            // 
            this.cardAccessories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cardAccessories.Controls.Add(this.lblTotalStock);
            this.cardAccessories.Controls.Add(this.lblTotalAccessories);
            this.cardAccessories.Controls.Add(this.lblCard1Title);
            this.cardAccessories.Location = new System.Drawing.Point(30, 90);
            this.cardAccessories.Name = "cardAccessories";
            this.cardAccessories.Size = new System.Drawing.Size(235, 115);
            this.cardAccessories.TabIndex = 2;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblTotalStock.Location = new System.Drawing.Point(16, 82);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(135, 18);
            this.lblTotalStock.TabIndex = 2;
            this.lblTotalStock.Text = "Total Stock: 0 units";
            // 
            // lblTotalAccessories
            // 
            this.lblTotalAccessories.AutoSize = true;
            this.lblTotalAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAccessories.ForeColor = System.Drawing.Color.White;
            this.lblTotalAccessories.Location = new System.Drawing.Point(14, 38);
            this.lblTotalAccessories.Name = "lblTotalAccessories";
            this.lblTotalAccessories.Size = new System.Drawing.Size(40, 42);
            this.lblTotalAccessories.TabIndex = 1;
            this.lblTotalAccessories.Text = "0";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard1Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard1Title.Location = new System.Drawing.Point(16, 14);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(137, 20);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "ACCESSORIES";
            // 
            // cardCategories
            // 
            this.cardCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cardCategories.Controls.Add(this.lblTotalModelsSub);
            this.cardCategories.Controls.Add(this.lblTotalModels);
            this.cardCategories.Controls.Add(this.lblCard2Title);
            this.cardCategories.Location = new System.Drawing.Point(290, 90);
            this.cardCategories.Name = "cardCategories";
            this.cardCategories.Size = new System.Drawing.Size(235, 115);
            this.cardCategories.TabIndex = 3;
            // 
            // lblTotalModelsSub
            // 
            this.lblTotalModelsSub.AutoSize = true;
            this.lblTotalModelsSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalModelsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblTotalModelsSub.Location = new System.Drawing.Point(16, 82);
            this.lblTotalModelsSub.Name = "lblTotalModelsSub";
            this.lblTotalModelsSub.Size = new System.Drawing.Size(132, 18);
            this.lblTotalModelsSub.TabIndex = 2;
            this.lblTotalModelsSub.Text = "Registered Models";
            // 
            // lblTotalModels
            // 
            this.lblTotalModels.AutoSize = true;
            this.lblTotalModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalModels.ForeColor = System.Drawing.Color.White;
            this.lblTotalModels.Location = new System.Drawing.Point(14, 38);
            this.lblTotalModels.Name = "lblTotalModels";
            this.lblTotalModels.Size = new System.Drawing.Size(40, 42);
            this.lblTotalModels.TabIndex = 1;
            this.lblTotalModels.Text = "0";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard2Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard2Title.Location = new System.Drawing.Point(16, 14);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(83, 20);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "MODELS";
            // 
            // cardSuppliers
            // 
            this.cardSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.cardSuppliers.Controls.Add(this.lblTotalBrandsSub);
            this.cardSuppliers.Controls.Add(this.lblTotalBrands);
            this.cardSuppliers.Controls.Add(this.lblCard3Title);
            this.cardSuppliers.Location = new System.Drawing.Point(550, 90);
            this.cardSuppliers.Name = "cardSuppliers";
            this.cardSuppliers.Size = new System.Drawing.Size(235, 115);
            this.cardSuppliers.TabIndex = 4;
            // 
            // lblTotalBrandsSub
            // 
            this.lblTotalBrandsSub.AutoSize = true;
            this.lblTotalBrandsSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBrandsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.lblTotalBrandsSub.Location = new System.Drawing.Point(16, 82);
            this.lblTotalBrandsSub.Name = "lblTotalBrandsSub";
            this.lblTotalBrandsSub.Size = new System.Drawing.Size(130, 18);
            this.lblTotalBrandsSub.TabIndex = 2;
            this.lblTotalBrandsSub.Text = "Registered Brands";
            // 
            // lblTotalBrands
            // 
            this.lblTotalBrands.AutoSize = true;
            this.lblTotalBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBrands.ForeColor = System.Drawing.Color.White;
            this.lblTotalBrands.Location = new System.Drawing.Point(14, 38);
            this.lblTotalBrands.Name = "lblTotalBrands";
            this.lblTotalBrands.Size = new System.Drawing.Size(40, 42);
            this.lblTotalBrands.TabIndex = 1;
            this.lblTotalBrands.Text = "0";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard3Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard3Title.Location = new System.Drawing.Point(16, 14);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(83, 20);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "BRANDS";
            // 
            // cardPurchases
            // 
            this.cardPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.cardPurchases.Controls.Add(this.lblTotalPurchasesSub);
            this.cardPurchases.Controls.Add(this.lblTotalPurchases);
            this.cardPurchases.Controls.Add(this.lblCard4Title);
            this.cardPurchases.Location = new System.Drawing.Point(810, 90);
            this.cardPurchases.Name = "cardPurchases";
            this.cardPurchases.Size = new System.Drawing.Size(240, 115);
            this.cardPurchases.TabIndex = 5;
            // 
            // lblTotalPurchasesSub
            // 
            this.lblTotalPurchasesSub.AutoSize = true;
            this.lblTotalPurchasesSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPurchasesSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblTotalPurchasesSub.Location = new System.Drawing.Point(16, 82);
            this.lblTotalPurchasesSub.Name = "lblTotalPurchasesSub";
            this.lblTotalPurchasesSub.Size = new System.Drawing.Size(121, 18);
            this.lblTotalPurchasesSub.TabIndex = 2;
            this.lblTotalPurchasesSub.Text = "Purchase Orders";
            // 
            // lblTotalPurchases
            // 
            this.lblTotalPurchases.AutoSize = true;
            this.lblTotalPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPurchases.ForeColor = System.Drawing.Color.White;
            this.lblTotalPurchases.Location = new System.Drawing.Point(14, 38);
            this.lblTotalPurchases.Name = "lblTotalPurchases";
            this.lblTotalPurchases.Size = new System.Drawing.Size(40, 42);
            this.lblTotalPurchases.TabIndex = 1;
            this.lblTotalPurchases.Text = "0";
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard4Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard4Title.Location = new System.Drawing.Point(16, 14);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(119, 20);
            this.lblCard4Title.TabIndex = 0;
            this.lblCard4Title.Text = "PURCHASES";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainContent.Controls.Add(this.dgvDashboardAccessories);
            this.pnlMainContent.Controls.Add(this.pnlFilterBar);
            this.pnlMainContent.Location = new System.Drawing.Point(30, 220);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1020, 495);
            this.pnlMainContent.TabIndex = 6;
            // 
            // dgvDashboardAccessories
            // 
            this.dgvDashboardAccessories.AllowUserToAddRows = false;
            this.dgvDashboardAccessories.AllowUserToDeleteRows = false;
            this.dgvDashboardAccessories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDashboardAccessories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDashboardAccessories.BackgroundColor = System.Drawing.Color.White;
            this.dgvDashboardAccessories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDashboardAccessories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDashboardAccessories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboardAccessories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDashboardAccessories.ColumnHeadersHeight = 38;
            this.dgvDashboardAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDashboardAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colBrand,
            this.colModel,
            this.colCategory,
            this.colPrice,
            this.colQty,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(220)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDashboardAccessories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDashboardAccessories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDashboardAccessories.EnableHeadersVisualStyles = false;
            this.dgvDashboardAccessories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDashboardAccessories.Location = new System.Drawing.Point(0, 85);
            this.dgvDashboardAccessories.MultiSelect = false;
            this.dgvDashboardAccessories.Name = "dgvDashboardAccessories";
            this.dgvDashboardAccessories.ReadOnly = true;
            this.dgvDashboardAccessories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboardAccessories.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDashboardAccessories.RowHeadersVisible = false;
            this.dgvDashboardAccessories.RowHeadersWidth = 51;
            this.dgvDashboardAccessories.RowTemplate.Height = 32;
            this.dgvDashboardAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboardAccessories.Size = new System.Drawing.Size(1018, 408);
            this.dgvDashboardAccessories.TabIndex = 1;
            this.dgvDashboardAccessories.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDashboardAccessories_CellFormatting);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "AccessoryId";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 55;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "AccessoryName";
            this.colName.HeaderText = "Accessory / Product Name";
            this.colName.MinimumWidth = 160;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "BrandName";
            this.colBrand.HeaderText = "Brand";
            this.colBrand.MinimumWidth = 90;
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            this.colBrand.Width = 125;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "ModelName";
            this.colModel.HeaderText = "Model";
            this.colModel.MinimumWidth = 100;
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            this.colModel.Width = 145;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "CategoryName";
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 90;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 70;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 95;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Stock";
            this.colQty.MinimumWidth = 60;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "StockStatus";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 90;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 110;
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFilterBar.Controls.Add(this.lblFilterSummary);
            this.pnlFilterBar.Controls.Add(this.btnRefresh);
            this.pnlFilterBar.Controls.Add(this.btnResetFilter);
            this.pnlFilterBar.Controls.Add(this.cboxFilterCategory);
            this.pnlFilterBar.Controls.Add(this.lblFilterCategory);
            this.pnlFilterBar.Controls.Add(this.cboxFilterBrand);
            this.pnlFilterBar.Controls.Add(this.lblFilterBrand);
            this.pnlFilterBar.Controls.Add(this.cboxFilterModel);
            this.pnlFilterBar.Controls.Add(this.lblFilterModel);
            this.pnlFilterBar.Controls.Add(this.txtSearchAccessory);
            this.pnlFilterBar.Controls.Add(this.lblFilterAccessory);
            this.pnlFilterBar.Controls.Add(this.lblFilterTitle);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(1018, 85);
            this.pnlFilterBar.TabIndex = 0;
            // 
            // lblFilterSummary
            // 
            this.lblFilterSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.lblFilterSummary.Location = new System.Drawing.Point(465, 12);
            this.lblFilterSummary.Name = "lblFilterSummary";
            this.lblFilterSummary.Size = new System.Drawing.Size(550, 22);
            this.lblFilterSummary.TabIndex = 11;
            this.lblFilterSummary.Text = "Showing 0 products";
            this.lblFilterSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(922, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 28);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.Sienna;
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(834, 46);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(80, 28);
            this.btnResetFilter.TabIndex = 9;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // cboxFilterCategory
            // 
            this.cboxFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFilterCategory.FormattingEnabled = true;
            this.cboxFilterCategory.Location = new System.Drawing.Point(693, 47);
            this.cboxFilterCategory.Name = "cboxFilterCategory";
            this.cboxFilterCategory.Size = new System.Drawing.Size(135, 26);
            this.cboxFilterCategory.TabIndex = 8;
            this.cboxFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cboxFilterCategory_SelectedIndexChanged);
            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFilterCategory.Location = new System.Drawing.Point(606, 53);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(81, 18);
            this.lblFilterCategory.TabIndex = 7;
            this.lblFilterCategory.Text = "Category:";
            // 
            // cboxFilterBrand
            // 
            this.cboxFilterBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFilterBrand.FormattingEnabled = true;
            this.cboxFilterBrand.Location = new System.Drawing.Point(482, 50);
            this.cboxFilterBrand.Name = "cboxFilterBrand";
            this.cboxFilterBrand.Size = new System.Drawing.Size(118, 26);
            this.cboxFilterBrand.TabIndex = 6;
            this.cboxFilterBrand.SelectedIndexChanged += new System.EventHandler(this.cboxFilterBrand_SelectedIndexChanged);
            // 
            // lblFilterBrand
            // 
            this.lblFilterBrand.AutoSize = true;
            this.lblFilterBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFilterBrand.Location = new System.Drawing.Point(419, 54);
            this.lblFilterBrand.Name = "lblFilterBrand";
            this.lblFilterBrand.Size = new System.Drawing.Size(57, 18);
            this.lblFilterBrand.TabIndex = 5;
            this.lblFilterBrand.Text = "Brand:";
            // 
            // cboxFilterModel
            // 
            this.cboxFilterModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFilterModel.FormattingEnabled = true;
            this.cboxFilterModel.Location = new System.Drawing.Point(289, 49);
            this.cboxFilterModel.Name = "cboxFilterModel";
            this.cboxFilterModel.Size = new System.Drawing.Size(122, 26);
            this.cboxFilterModel.TabIndex = 4;
            this.cboxFilterModel.SelectedIndexChanged += new System.EventHandler(this.cboxFilterModel_SelectedIndexChanged);
            // 
            // lblFilterModel
            // 
            this.lblFilterModel.AutoSize = true;
            this.lblFilterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFilterModel.Location = new System.Drawing.Point(222, 53);
            this.lblFilterModel.Name = "lblFilterModel";
            this.lblFilterModel.Size = new System.Drawing.Size(59, 18);
            this.lblFilterModel.TabIndex = 3;
            this.lblFilterModel.Text = "Model:";
            // 
            // txtSearchAccessory
            // 
            this.txtSearchAccessory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccessory.Location = new System.Drawing.Point(76, 51);
            this.txtSearchAccessory.Name = "txtSearchAccessory";
            this.txtSearchAccessory.Size = new System.Drawing.Size(140, 25);
            this.txtSearchAccessory.TabIndex = 2;
            this.txtSearchAccessory.TextChanged += new System.EventHandler(this.txtSearchAccessory_TextChanged);
            // 
            // lblFilterAccessory
            // 
            this.lblFilterAccessory.AutoSize = true;
            this.lblFilterAccessory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterAccessory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFilterAccessory.Location = new System.Drawing.Point(5, 54);
            this.lblFilterAccessory.Name = "lblFilterAccessory";
            this.lblFilterAccessory.Size = new System.Drawing.Size(66, 18);
            this.lblFilterAccessory.TabIndex = 1;
            this.lblFilterAccessory.Text = "Search:";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterTitle.ForeColor = System.Drawing.Color.Sienna;
            this.lblFilterTitle.Location = new System.Drawing.Point(12, 12);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(277, 25);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Inventory Products & Filters";
            this.lblFilterTitle.UseMnemonic = false;
            // 
            // uc_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.cardPurchases);
            this.Controls.Add(this.cardSuppliers);
            this.Controls.Add(this.cardCategories);
            this.Controls.Add(this.cardAccessories);
            this.Controls.Add(this.lblTitle);
            this.Name = "uc_Dashboard";
            this.Size = new System.Drawing.Size(1080, 750);
            this.Load += new System.EventHandler(this.uc_Dashboard_Load);
            this.cardAccessories.ResumeLayout(false);
            this.cardAccessories.PerformLayout();
            this.cardCategories.ResumeLayout(false);
            this.cardCategories.PerformLayout();
            this.cardSuppliers.ResumeLayout(false);
            this.cardSuppliers.PerformLayout();
            this.cardPurchases.ResumeLayout(false);
            this.cardPurchases.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardAccessories)).EndInit();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel cardAccessories;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblTotalAccessories;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel cardCategories;
        private System.Windows.Forms.Label lblTotalModelsSub;
        private System.Windows.Forms.Label lblTotalModels;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel cardSuppliers;
        private System.Windows.Forms.Label lblTotalBrandsSub;
        private System.Windows.Forms.Label lblTotalBrands;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel cardPurchases;
        private System.Windows.Forms.Label lblTotalPurchasesSub;
        private System.Windows.Forms.Label lblTotalPurchases;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.DataGridView dgvDashboardAccessories;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblFilterAccessory;
        private System.Windows.Forms.TextBox txtSearchAccessory;
        private System.Windows.Forms.Label lblFilterModel;
        private System.Windows.Forms.ComboBox cboxFilterModel;
        private System.Windows.Forms.Label lblFilterBrand;
        private System.Windows.Forms.ComboBox cboxFilterBrand;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cboxFilterCategory;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblFilterSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
