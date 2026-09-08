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
    public partial class uc_Supplier : UserControl
    {
        public uc_Supplier()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        Controller.Controllersupplier supplier = new Controller.Controllersupplier();
        Functions DE_Functions = new Functions();

        private void uc_Supplier_Load(object sender, EventArgs e)
        {
            InitializeGridStyle();
            ResetSupplierButtons();
            viewSupplier();
        }

        private void InitializeGridStyle()
        {
            dgsupplier.BackgroundColor = Color.White;
            dgsupplier.BorderStyle = BorderStyle.Fixed3D;
            dgsupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgsupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgsupplier.EnableHeadersVisualStyles = false;
            dgsupplier.GridColor = Color.FromArgb(230, 230, 230);
            dgsupplier.RowHeadersVisible = false;
            dgsupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgsupplier.MultiSelect = false;
            dgsupplier.RowTemplate.Height = 30;

            // Sienna header style
            dgsupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 82, 45);
            dgsupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgsupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dgsupplier.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(160, 82, 45);
            dgsupplier.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgsupplier.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
            dgsupplier.ColumnHeadersHeight = 36;
            dgsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Default cell style
            dgsupplier.DefaultCellStyle.BackColor = Color.White;
            dgsupplier.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgsupplier.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            dgsupplier.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 220, 205);
            dgsupplier.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Alternating rows
            dgsupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string btnText = btnsave.Text.Trim();

            if (btnText == "Add Supplier" || btnText == "Add")
            {
                DE_Functions.EnableTxtAndCbox(this);
                ClearSupplierTextBoxes();
                txtsupplierId.Enabled = false;

                btnsave.Text = "Insert";
                btnsave.Enabled = true;
                btnClear.Text = "Clear";
                btnClear.Enabled = true;
                btndelete.Enabled = false;
                txtsuppliername.Focus();
            }
            else if (btnText == "Insert Supplier" || btnText == "Insert")
            {
                // Strict validation: Supplier Name cannot be empty or whitespace
                if (string.IsNullOrWhiteSpace(txtsuppliername.Text))
                {
                    MessageBox.Show("Please enter the Supplier Name.", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsuppliername.Focus();
                    return;
                }

                try
                {
                    supplier.SupplierName = txtsuppliername.Text.Trim();
                    supplier.SupplierPhone = txtnumber.Text.Trim();
                    supplier.SupplierEmail = txtsupplieremail.Text.Trim();
                    supplier.SupplierAddress = txtadress.Text.Trim();
                    supplier.InsertSupplier();

                    viewSupplier();
                    MessageBox.Show("Supplier Has Been Inserted", "Insert Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetSupplierButtons();
                    ClearSupplierTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Supplier Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnText == "Clear" || btnText == "Clear Supplier")
            {
                ClearSupplierTextBoxes();
                ResetSupplierButtons();
            }
        }

        public void viewSupplier()
        {
            supplier.viewSupplier();
            dgsupplier.DataSource = supplier.dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsupplierId.Text) || !int.TryParse(txtsupplierId.Text.Trim(), out int supId))
            {
                MessageBox.Show("Please select a valid supplier from the table to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    supplier.SupplierId = supId;
                    supplier.DeleteSupplier();
                    viewSupplier();
                    MessageBox.Show("Supplier Has Been Deleted", "Delete Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetSupplierButtons();
                    ClearSupplierTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Supplier Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string btnText = btnClear.Text.Trim();

            if (btnText == "Clear Supplier" || btnText == "Clear")
            {
                ClearSupplierTextBoxes();
                ResetSupplierButtons();
            }
            else if (btnText == "Update Supplier" || btnText == "Update")
            {
                if (string.IsNullOrWhiteSpace(txtsupplierId.Text) || !int.TryParse(txtsupplierId.Text.Trim(), out int supId))
                {
                    MessageBox.Show("Please select a valid supplier from the table to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Strict validation: Supplier Name cannot be empty or whitespace
                if (string.IsNullOrWhiteSpace(txtsuppliername.Text))
                {
                    MessageBox.Show("Please enter the Supplier Name.", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsuppliername.Focus();
                    return;
                }

                try
                {
                    supplier.SupplierId = supId;
                    supplier.SupplierName = txtsuppliername.Text.Trim();
                    supplier.SupplierPhone = txtnumber.Text.Trim();
                    supplier.SupplierEmail = txtsupplieremail.Text.Trim();
                    supplier.SupplierAddress = txtadress.Text.Trim();
                    supplier.UpdateSupplier();

                    viewSupplier();
                    MessageBox.Show("Supplier Has Been Updated", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetSupplierButtons();
                    ClearSupplierTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Supplier Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSupplierRow(e.RowIndex);
        }

        private void SelectSupplierRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgsupplier.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dgsupplier.Rows[rowIndex];
            DataRowView supplierRow = row.DataBoundItem as DataRowView;
            if (supplierRow == null)
            {
                return;
            }

            txtsupplierId.Text = GetSupplierValue(supplierRow, "SupplierId");
            txtsuppliername.Text = GetSupplierValue(supplierRow, "SupplierName");
            txtnumber.Text = GetSupplierValue(supplierRow, "SupplierPhone");
            txtsupplieremail.Text = GetSupplierValue(supplierRow, "SupplierEmail");
            txtadress.Text = GetSupplierValue(supplierRow, "SupplierAddress");

            DE_Functions.EnableTxtAndCbox(this);
            txtsupplierId.Enabled = false;

            btnsave.Text = "Clear";
            btnsave.Enabled = true;
            btnClear.Text = "Update";
            btnClear.Enabled = true;
            btndelete.Text = "Delete";
            btndelete.Enabled = true;
        }

        private string GetSupplierValue(DataRowView row, string columnName)
        {
            if (!row.DataView.Table.Columns.Contains(columnName) || row[columnName] == DBNull.Value)
            {
                return "";
            }

            return row[columnName].ToString();
        }

        private void ClearSupplierTextBoxes()
        {
            DE_Functions.ClearTxtAndCbox(this);
            txtsupplierId.Clear();
            txtsuppliername.Clear();
            txtnumber.Clear();
            txtsupplieremail.Clear();
            txtadress.Clear();
        }

        private void ResetSupplierButtons()
        {
            DE_Functions.DisableTxtAndCbox(this);
            txtsupplierId.Enabled = false;
            btnsave.Text = "Add";
            btnsave.Enabled = true;
            btnClear.Text = "Update";
            btnClear.Enabled = false;
            btndelete.Text = "Delete";
            btndelete.Enabled = false;
        }

        private void dgsupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectSupplierRow(e.RowIndex);
        }
    }
}
