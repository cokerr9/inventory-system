using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.View
{
    public partial class MainForm : Form
    {
        Controller.ControllerSetting setting = new Controller.ControllerSetting();

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Dashboard dashboardControl = new uc_Dashboard();
            uc_Container.Controls.Add(dashboardControl);
            dashboardControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Accessory accessoryControl = new uc_Accessory();
            uc_Container.Controls.Add(accessoryControl);
            accessoryControl.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!UserDetail.CanAccessModule("Category"))
            {
                MessageBox.Show("You do not have permission to access Category management.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Category categoryControl = new uc_Category();
            uc_Container.Controls.Add(categoryControl);
            categoryControl.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Supplier supplierControl = new uc_Supplier();
            uc_Container.Controls.Add(supplierControl);
            supplierControl.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!UserDetail.CanAccessModule("User"))
            {
                MessageBox.Show("You do not have permission to access User management.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_User userControl = new uc_User();
            uc_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!UserDetail.CanAccessModule("Setting"))
            {
                MessageBox.Show("You do not have permission to access System Settings.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Setting settingControl = new uc_Setting();
            uc_Container.Controls.Add(settingControl);
            settingControl.BringToFront();
        }

        private void uc_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadLogo();
            LoadUserInfo();
            ApplyUserPermissions();
            button1_Click(this, EventArgs.Empty);
        }

        public void ApplyUserPermissions()
        {
            bool isAdmin = UserDetail.IsAdmin;

            // Admin-only modules
            button4.Visible = isAdmin;       // Category
            button4.Enabled = isAdmin;
            button8.Visible = isAdmin;       // Brands
            button8.Enabled = isAdmin;
            button3.Visible = isAdmin;       // Models
            button3.Enabled = isAdmin;
            button6.Visible = isAdmin;       // User
            button6.Enabled = isAdmin;
            button7.Visible = isAdmin;       // Setting
            button7.Enabled = isAdmin;

            // Modules accessible to both User and Admin: Dashboard, Accessory, Supplier, Purchase
            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
            button5.Visible = true;
            button5.Enabled = true;
            btnPurchase.Visible = true;
            btnPurchase.Enabled = true;

            // Neatly reposition buttons on sidebar to eliminate blank gaps
            int startY = 112;
            int spacing = 52;
            int x = 12;

            if (isAdmin)
            {
                button1.Location = new Point(x, startY);
                button2.Location = new Point(x, startY + spacing * 1);
                button4.Location = new Point(x, startY + spacing * 2);
                button8.Location = new Point(x, startY + spacing * 3);
                button3.Location = new Point(x, startY + spacing * 4);
                button5.Location = new Point(x, startY + spacing * 5);
                btnPurchase.Location = new Point(x, startY + spacing * 6);
                button6.Location = new Point(x, startY + spacing * 7);
                button7.Location = new Point(x, startY + spacing * 8);
            }
            else
            {
                // Regular User: Dashboard, Accessory, Supplier, Purchase
                button1.Location = new Point(x, startY);
                button2.Location = new Point(x, startY + spacing * 1);
                button5.Location = new Point(x, startY + spacing * 2);
                btnPurchase.Location = new Point(x, startY + spacing * 3);
            }
        }

        public void LoadUserInfo()
        {
            try
            {
                string userName = !string.IsNullOrWhiteSpace(UserDetail.UserName) ? UserDetail.UserName : "Administrator";
                string roleName = !string.IsNullOrWhiteSpace(UserDetail.UserRole) ? UserDetail.UserRole : "Admin";
                label1.Text = $"👤 {userName} [{roleName}]";

                ToolTip tt = new ToolTip();
                tt.SetToolTip(label1, $"User ID: {UserDetail.UserId}\nRole: {roleName}\nStatus: {(UserDetail.UserStatus == 1 ? "Active" : "InActive")}");
            }
            catch
            {
                label1.Text = "👤 User : Administrator";
            }
        }

        public void RefreshLogo()
        {
            LoadLogo();
        }

        private void LoadLogo()
        {
            try
            {
                Image logo = setting.GetCompanyLogo();
                if (logo != null)
                {
                    pictureBox1.Image = logo;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Logo Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!UserDetail.CanAccessModule("Models"))
            {
                MessageBox.Show("You do not have permission to access Model management.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Models settingControl = new uc_Models();
            uc_Container.Controls.Add(settingControl);
            settingControl.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!UserDetail.CanAccessModule("Brands"))
            {
                MessageBox.Show("You do not have permission to access Brand management.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_brand settingControl = new uc_brand();
            uc_Container.Controls.Add(settingControl);
            settingControl.BringToFront();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Purchase purchaseControl = new uc_Purchase();
            uc_Container.Controls.Add(purchaseControl);
            purchaseControl.BringToFront();
        }
    }
}
