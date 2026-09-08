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
            dgbrands.AutoGenerateColumns = false;
        }

        private Controller.ControllerBrands cbrand = new Controller.ControllerBrands();

        private void uc_brand_Load(object sender, EventArgs e)
        {
            // Ensure status items are available
            if (!cbbrandstatus.Items.Contains("Active")) cbbrandstatus.Items.Add("Active");
            if (!cbbrandstatus.Items.Contains("InActive")) cbbrandstatus.Items.Add("InActive");
            if (!cbbrandstatus.Items.Contains("Disable")) cbbrandstatus.Items.Add("Disable");

            ResetForm();
            viewBrand();
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

        private void SelectBrandFromGrid(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgbrands.Rows.Count) return;

            DataGridViewRow row = dgbrands.Rows[rowIndex];
            if (row.Cells[0].Value == null) return;

            txtbrandid.Text = row.Cells[0].Value?.ToString() ?? "";
            txtbrandname.Text = row.Cells[1].Value?.ToString() ?? "";

            string status = row.Cells[2].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(status))
            {
                int idx = cbbrandstatus.FindStringExact(status);
                if (idx >= 0)
                {
                    cbbrandstatus.SelectedIndex = idx;
                }
                else
                {
                    cbbrandstatus.Items.Add(status);
                    cbbrandstatus.SelectedItem = status;
                }
            }
            else
            {
                cbbrandstatus.SelectedIndex = -1;
            }

            txtbrandid.Enabled = false;
            txtbrandname.Enabled = true;
            cbbrandstatus.Enabled = true;

            btnadd.Text = "Update Brand";
            btnadd.Enabled = true;
            btnclear.Enabled = true;
            btnclear.Text = "Clear";
            btndelete.Enabled = true;
        }

        private void dgbrands_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectBrandFromGrid(e.RowIndex);
        }

        private void dgbrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectBrandFromGrid(e.RowIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectBrandFromGrid(e.RowIndex);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add New")
            {
                txtbrandid.Text = "";
                txtbrandname.Text = "";

                // Select "Active" by default so SelectedItem is never null
                if (cbbrandstatus.Items.Count > 0)
                {
                    int activeIdx = cbbrandstatus.FindStringExact("Active");
                    cbbrandstatus.SelectedIndex = activeIdx >= 0 ? activeIdx : 0;
                }

                txtbrandid.Enabled = false;
                txtbrandname.Enabled = true;
                cbbrandstatus.Enabled = true;

                btnadd.Text = "Insert Brand";
                btnclear.Enabled = true;
                btnclear.Text = "Clear Brand";
                btndelete.Enabled = false;

                txtbrandname.Focus();
            }
            else if (btnadd.Text == "Insert Brand")
            {
                // Validation to prevent null reference and empty inputs
                if (string.IsNullOrWhiteSpace(txtbrandname.Text))
                {
                    MessageBox.Show("Please enter Brand Name!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbrandname.Focus();
                    return;
                }

                if (cbbrandstatus.SelectedIndex == -1 || cbbrandstatus.SelectedItem == null)
                {
                    MessageBox.Show("Please select Brand Status!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbrandstatus.Focus();
                    return;
                }

                try
                {
                    cbrand.BrandName = txtbrandname.Text.Trim();
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
                // Validation to prevent null reference and empty inputs
                if (string.IsNullOrWhiteSpace(txtbrandid.Text))
                {
                    MessageBox.Show("Please select a brand from the list to update.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbrandname.Text))
                {
                    MessageBox.Show("Please enter Brand Name!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbrandname.Focus();
                    return;
                }

                if (cbbrandstatus.SelectedIndex == -1 || cbbrandstatus.SelectedItem == null)
                {
                    MessageBox.Show("Please select Brand Status!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbrandstatus.Focus();
                    return;
                }

                try
                {
                    cbrand.BrandId = Convert.ToInt32(txtbrandid.Text);
                    cbrand.BrandName = txtbrandname.Text.Trim();
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
            ResetForm();
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

                    ResetForm();
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
            btnadd.Enabled = true;
            btnclear.Enabled = false;
            btnclear.Text = "Clear";
            btndelete.Enabled = false;
        }
    }
}
