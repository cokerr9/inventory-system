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
    public partial class uc_brand : UserControl
    {
        public uc_brand()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            txtbrandid.Enabled = false;
            txtbrandname.Enabled = false;
            cbbrandstatus.Enabled = false;
            dgbrands.AutoGenerateColumns = false;
        }
        Controller.ControllerBrands cbrand = new Controller.ControllerBrands();

        private void uc_brand_Load(object sender, EventArgs e)
        {
            viewBrand();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgbrands_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgbrands.Rows[e.RowIndex];

            txtbrandid.Text = row.Cells[0].Value?.ToString();
            txtbrandname.Text = row.Cells[1].Value?.ToString();
            cbbrandstatus.SelectedItem = row.Cells[2].Value?.ToString();
            txtbrandname.Enabled = true;
            cbbrandstatus.Enabled = true;

            btnadd.Text = "Update Brand";
            btnclear.Enabled = true;
            btnclear.Text = "Clear";
        }
        public void viewBrand()
        {
            try
            {
                cbrand.viewBrand();
                dgbrands.DataSource = cbrand.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("View Brand Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add New")
            {
                txtbrandid.Text = "";
                txtbrandname.Text = "";
                cbbrandstatus.SelectedIndex = -1;

                txtbrandid.Enabled = false;
                txtbrandname.Enabled = true;
                cbbrandstatus.Enabled = true;
                btnadd.Text = "Insert Brand";
                btnclear.Enabled = true;
                btnclear.Text = "Clear Brand";
            }
            else if (btnadd.Text == "Insert Brand")
            {
                try
                {
                    cbrand.BrandName = txtbrandname.Text;
                    cbrand.BrandStatus = cbbrandstatus.SelectedItem.ToString();
                    cbrand.InsertBrand();
                    viewBrand();
                    MessageBox.Show("Brand Has Been Inserted", "Insert Brand", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Brand Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnadd.Text == "Update Brand")
            {
                try
                {
                    cbrand.BrandId = Convert.ToInt32(txtbrandid.Text);
                    cbrand.BrandName = txtbrandname.Text;
                    cbrand.BrandStatus = cbbrandstatus.SelectedItem.ToString();
                    cbrand.UpdateBrand();
                    viewBrand();
                    MessageBox.Show("Brand Has Been Updated", "Update Brand", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Brand Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbrandid.Text = "";
            txtbrandname.Text = "";
            cbbrandstatus.SelectedIndex = -1;
            txtbrandid.Enabled = true;
            btnadd.Text = "Add New";
            btnclear.Enabled = false;
            btnclear.Text = "Clear";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbrandid.Text))
            {
                MessageBox.Show("Please select a brand to delete.", "Delete Brand", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this brand?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    cbrand.BrandId = Convert.ToInt32(txtbrandid.Text);
                    cbrand.DeleteBrand();
                    viewBrand();
                    MessageBox.Show("Brand Has Been Deleted", "Delete Brand", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtbrandid.Text = "";
                    txtbrandname.Text = "";
                    cbbrandstatus.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Brand Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetForm()
        {
            txtbrandid.Text = "";
            txtbrandname.Text = "";
            cbbrandstatus.SelectedIndex = -1;

            txtbrandid.Enabled = false;
            txtbrandname.Enabled = false;
            cbbrandstatus.Enabled = false;

            btnadd.Text = "Add New";
            btnclear.Enabled = false;
            btnclear.Text = "Clear";
        }
    }
}
