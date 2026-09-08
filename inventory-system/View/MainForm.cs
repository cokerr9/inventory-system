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
            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_User userControl = new uc_User();
            uc_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
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
            button1_Click(this, EventArgs.Empty);
        }

        public void LoadUserInfo()
        {
            try
            {
                string userName = !string.IsNullOrWhiteSpace(UserDetail.UserName) ? UserDetail.UserName : "Administrator";
                label1.Text = $"👤 User : {userName}";

                if (!string.IsNullOrWhiteSpace(UserDetail.UserRole))
                {
                    ToolTip tt = new ToolTip();
                    tt.SetToolTip(label1, $"User ID: {UserDetail.UserId}\nRole: {UserDetail.UserRole}\nStatus: {(UserDetail.UserStatus == 1 ? "Active" : "InActive")}");
                }
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

            uc_Container.Controls.Clear();
            uc_Container.Dock = DockStyle.Fill;
            uc_Models settingControl = new uc_Models();
            uc_Container.Controls.Add(settingControl);
            settingControl.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {

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
