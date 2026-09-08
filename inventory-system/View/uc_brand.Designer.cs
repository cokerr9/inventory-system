namespace inventory_system.View
{
    partial class uc_brand
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbrandid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbrandname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbrandstatus = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgbrands = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbrands)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(380, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Brands";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand ID";
            // 
            // txtbrandid
            // 
            this.txtbrandid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbrandid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrandid.Location = new System.Drawing.Point(80, 125);
            this.txtbrandid.Name = "txtbrandid";
            this.txtbrandid.Size = new System.Drawing.Size(280, 34);
            this.txtbrandid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand Name";
            // 
            // txtbrandname
            // 
            this.txtbrandname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbrandname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrandname.Location = new System.Drawing.Point(400, 125);
            this.txtbrandname.Name = "txtbrandname";
            this.txtbrandname.Size = new System.Drawing.Size(340, 34);
            this.txtbrandname.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(780, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Brand Status";
            // 
            // cbbrandstatus
            // 
            this.cbbrandstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbrandstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrandstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbrandstatus.FormattingEnabled = true;
            this.cbbrandstatus.Items.AddRange(new object[] {
            "Active",
            "Disable"});
            this.cbbrandstatus.Location = new System.Drawing.Point(780, 125);
            this.cbbrandstatus.Name = "cbbrandstatus";
            this.cbbrandstatus.Size = new System.Drawing.Size(260, 37);
            this.cbbrandstatus.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(310, 185);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(160, 44);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add New";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(490, 185);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 44);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(670, 185);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(160, 44);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dgbrands
            // 
            this.dgbrands.AllowUserToAddRows = false;
            this.dgbrands.AllowUserToDeleteRows = false;
            this.dgbrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgbrands.Location = new System.Drawing.Point(80, 255);
            this.dgbrands.Name = "dgbrands";
            this.dgbrands.ReadOnly = true;
            this.dgbrands.RowHeadersWidth = 51;
            this.dgbrands.RowTemplate.Height = 28;
            this.dgbrands.Size = new System.Drawing.Size(960, 460);
            this.dgbrands.TabIndex = 10;
            this.dgbrands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgbrands.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgbrands_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BrandId";
            this.Column1.HeaderText = "Brand ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BrandName";
            this.Column2.HeaderText = "Brand Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BrandStatus";
            this.Column3.HeaderText = "Brand Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // uc_brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgbrands);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbbrandstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbrandname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbrandid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_brand";
            this.Size = new System.Drawing.Size(1120, 750);
            this.Load += new System.EventHandler(this.uc_brand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbrandid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbrandname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbrandstatus;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgbrands;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
