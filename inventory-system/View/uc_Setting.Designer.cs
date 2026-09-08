namespace inventory_system.View
{
    partial class uc_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.addLogo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcompanyid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting Information";
            // 
            // pblogo
            // 
            this.pblogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pblogo.BackColor = System.Drawing.Color.White;
            this.pblogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
            this.pblogo.Location = new System.Drawing.Point(180, 120);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(280, 280);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 1;
            this.pblogo.TabStop = false;
            // 
            // addLogo
            // 
            this.addLogo.ActiveLinkColor = System.Drawing.Color.Sienna;
            this.addLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addLogo.AutoSize = true;
            this.addLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addLogo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.addLogo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.addLogo.Location = new System.Drawing.Point(215, 415);
            this.addLogo.Name = "addLogo";
            this.addLogo.Size = new System.Drawing.Size(211, 25);
            this.addLogo.TabIndex = 2;
            this.addLogo.TabStop = true;
            this.addLogo.Text = "Change Company Logo";
            this.addLogo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLogo_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company ID";
            // 
            // txtcompanyid
            // 
            this.txtcompanyid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcompanyid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtcompanyid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyid.Location = new System.Drawing.Point(540, 150);
            this.txtcompanyid.Name = "txtcompanyid";
            this.txtcompanyid.ReadOnly = true;
            this.txtcompanyid.Size = new System.Drawing.Size(400, 34);
            this.txtcompanyid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company Name";
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcompanyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyname.Location = new System.Drawing.Point(540, 235);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(400, 34);
            this.txtcompanyname.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(540, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uc_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcompanyid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLogo);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.label1);
            this.Name = "uc_Setting";
            this.Size = new System.Drawing.Size(1120, 750);
            this.Load += new System.EventHandler(this.uc_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel addLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcompanyid;
        private System.Windows.Forms.TextBox txtcompanyname;
    }
}
