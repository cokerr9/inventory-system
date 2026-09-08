using System;
using System.Data;
using System.Windows.Forms;

namespace inventory_system.View
{
    public partial class uc_Category : UserControl
    {
        public uc_Category()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        }

        Controller.ControllerCategory categoryCtrl = new Controller.ControllerCategory();
        Functions DE_Functions = new Functions();

        private void ResetFormState()
        {
            DE_Functions.ClearTxtAndCbox(this);
            DE_Functions.DisableTxtAndCbox(this);

            btnAdd.Text = "Add";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void uc_Category_Load(object sender, EventArgs e)
        {
            cboCategoryStatus.Items.Clear();
            cboCategoryStatus.Items.Add("Active");
            cboCategoryStatus.Items.Add("InActive");

            ResetFormState();
            GetCategoryData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Clear")
            {
                ResetFormState();
            }
            else if (btnAdd.Text == "Add")
            {
                DE_Functions.ClearTxtAndCbox(this);
                DE_Functions.EnableTxtAndCbox(this);
                txtCategoryId.Enabled = false; 

                if (cboCategoryStatus.Items.Count > 0)
                {
                    int activeIdx = cboCategoryStatus.FindStringExact("Active");
                    cboCategoryStatus.SelectedIndex = activeIdx >= 0 ? activeIdx : 0;
                }

                btnAdd.Text = "Save";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtCategoryName.Focus();
            }
            else if (btnAdd.Text == "Save")
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text) || cboCategoryStatus.SelectedIndex == -1 || cboCategoryStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in Category Name and Status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                categoryCtrl.CategoryName = txtCategoryName.Text.Trim();
                string selectedStatus = cboCategoryStatus.SelectedItem.ToString().Trim();
                categoryCtrl.CategoryStatus = selectedStatus.Equals("Active", StringComparison.OrdinalIgnoreCase) ? "Active" : "InActive";
                categoryCtrl.InsertCategory();

                GetCategoryData();
                ResetFormState();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCategoryId.Text.Trim(), out int id))
            {
                MessageBox.Show("Please select a category from the table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text) || cboCategoryStatus.SelectedIndex == -1 || cboCategoryStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill in Category Name and Status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            categoryCtrl.CategoryId = id;
            categoryCtrl.CategoryName = txtCategoryName.Text.Trim();
            string selectedStatus = cboCategoryStatus.SelectedItem.ToString().Trim();
            categoryCtrl.CategoryStatus = selectedStatus.Equals("Active", StringComparison.OrdinalIgnoreCase) ? "Active" : "InActive";
            categoryCtrl.UpdateCategory();
            GetCategoryData();
            ResetFormState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCategoryId.Text.Trim(), out int id))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    categoryCtrl.CategoryId = id;
                    categoryCtrl.DeleteCategory();
                    GetCategoryData();
                    ResetFormState();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataCategory.Rows[e.RowIndex];

                if (row.Cells[0].Value == null || string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                    return;

                txtCategoryId.Text = row.Cells[0].Value?.ToString() ?? "";
                txtCategoryName.Text = row.Cells[1].Value?.ToString() ?? "";

                object statusVal = row.Cells[2].Value;
                if (statusVal != null && !string.IsNullOrWhiteSpace(statusVal.ToString()))
                {
                    string statusStr = statusVal.ToString().Trim();
                    if (statusStr == "1" || statusStr.Equals("Active", StringComparison.OrdinalIgnoreCase) || statusStr.Equals("True", StringComparison.OrdinalIgnoreCase))
                    {
                        cboCategoryStatus.SelectedItem = "Active";
                    }
                    else
                    {
                        cboCategoryStatus.SelectedItem = "InActive";
                    }
                }
                else
                {
                    cboCategoryStatus.SelectedIndex = -1;
                }

                DE_Functions.EnableTxtAndCbox(this);
                txtCategoryId.Enabled = false;
                btnAdd.Text = "Clear";
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dataCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            string colName = dataCategory.Columns[e.ColumnIndex].Name;
            string propName = dataCategory.Columns[e.ColumnIndex].DataPropertyName;

            // Format Category Status: 1 -> Active, 0 -> InActive
            if (colName == "Column3" || propName == "CategoryStatus" || e.ColumnIndex == 2)
            {
                string raw = e.Value.ToString().Trim();
                if (raw == "1" || raw.Equals("True", StringComparison.OrdinalIgnoreCase) || raw.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    e.Value = "Active";
                    e.FormattingApplied = true;
                }
                else if (raw == "0" || raw.Equals("False", StringComparison.OrdinalIgnoreCase) || raw.Equals("InActive", StringComparison.OrdinalIgnoreCase) || raw.Equals("Inactive", StringComparison.OrdinalIgnoreCase) || raw.Equals("Disable", StringComparison.OrdinalIgnoreCase))
                {
                    e.Value = "InActive";
                    e.FormattingApplied = true;
                }
            }
        }

        public void GetCategoryData()
        {
            dataCategory.AutoGenerateColumns = false;
            categoryCtrl.GetCategoryData();
            dataCategory.DataSource = categoryCtrl.dt;
        }
        //private void btnUpdate_Click_1(object sender, EventArgs e)
        //{
        //    btnUpdate_Click(sender, e);
        //}
    }
}