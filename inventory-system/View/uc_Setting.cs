using inventory_system.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.View
{
    public partial class uc_Setting : UserControl
    {
        public uc_Setting()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        Controller.ControllerSetting setting = new Controller.ControllerSetting();

        private void uc_Setting_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData(int companyId = 0)
        {
            try
            {
                bool found = setting.LoadCompanySetting(companyId > 0 ? (int?)companyId : null);

                if (found)
                {
                    txtcompanyid.Text = setting.CompanyId.ToString();
                    txtcompanyname.Text = setting.CompanyName;

                    Image logo = setting.GetLogoAsImage();
                    if (logo != null)
                    {
                        pblogo.Image = logo;
                    }
                    else
                    {
                        pblogo.Image = Resources.man_with_sunglasses_and_suit;
                    }
                }
                else
                {
                    txtcompanyid.Text = "";
                    txtcompanyname.Text = "";
                    pblogo.Image = Resources.man_with_sunglasses_and_suit;
                }
                pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Setting Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addLogo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        using (var img = Image.FromStream(stream))
                        {
                            pblogo.Image = new Bitmap(img);
                            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot load selected image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string companyName = txtcompanyname.Text.Trim();
            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Please enter a valid Company Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcompanyname.Focus();
                return;
            }

            if (pblogo.Image == null)
            {
                MessageBox.Show("Please select a Company Logo.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isUpdate = int.TryParse(txtcompanyid.Text.Trim(), out int companyId) && companyId > 0;

            try
            {
                setting.CompanyName = companyName;
                setting.SetLogoFromImage(pblogo.Image);

                if (isUpdate)
                {
                    setting.CompanyId = companyId;
                    setting.UpdateSetting();
                    MessageBox.Show("Company setting has been updated successfully!", "Update Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setting.InsertSetting();
                    MessageBox.Show("Company setting has been saved successfully!", "Save Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                loadData();
                RefreshMainFormLogo();
            }
            catch (Exception ex)
            {
                string action = isUpdate ? "Update" : "Insert";
                MessageBox.Show($"{action} Setting Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshMainFormLogo()
        {
            MainForm mainForm = FindForm() as MainForm;
            if (mainForm != null)
            {
                mainForm.RefreshLogo();
            }
        }
    }
}
