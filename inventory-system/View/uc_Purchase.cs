using inventory_system.Controller;
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
    public partial class uc_Purchase : UserControl
    {
        public uc_Purchase()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        // Call Controller to Insert/Manage Purchase
        Controller.PurchaseController purchaseCtrl = new Controller.PurchaseController();

        // Disable and Enable Functions
        Functions DE_Functions = new Functions();

        // Dictionaries for fast lookup in DataGridView CellFormatting
        private Dictionary<int, string> accessoryDict = new Dictionary<int, string>();
        private Dictionary<int, string> categoryDict = new Dictionary<int, string>();
        private Dictionary<int, string> brandDict = new Dictionary<int, string>();
        private Dictionary<int, string> supplierDict = new Dictionary<int, string>();

        private void LoadDropdownData()
        {
            try
            {
                // Accessories
                DataTable dtAcc = purchaseCtrl.GetAccessories();
                accessoryDict.Clear();
                foreach (DataRow row in dtAcc.Rows)
                {
                    if (row["AccessoryId"] != DBNull.Value)
                    {
                        accessoryDict[Convert.ToInt32(row["AccessoryId"])] = row["AccessoryName"]?.ToString() ?? "";
                    }
                }
                cboxAccessory.DataSource = dtAcc;
                cboxAccessory.DisplayMember = "AccessoryName";
                cboxAccessory.ValueMember = "AccessoryId";
                cboxAccessory.SelectedIndex = -1;

                // Categories
                DataTable dtCat = purchaseCtrl.GetCategories();
                categoryDict.Clear();
                foreach (DataRow row in dtCat.Rows)
                {
                    if (row["CategoryId"] != DBNull.Value)
                    {
                        categoryDict[Convert.ToInt32(row["CategoryId"])] = row["CategoryName"]?.ToString() ?? "";
                    }
                }
                cboxCategory.DataSource = dtCat;
                cboxCategory.DisplayMember = "CategoryName";
                cboxCategory.ValueMember = "CategoryId";
                cboxCategory.SelectedIndex = -1;

                // Brands
                DataTable dtBrd = purchaseCtrl.GetBrands();
                brandDict.Clear();
                foreach (DataRow row in dtBrd.Rows)
                {
                    if (row["BrandId"] != DBNull.Value)
                    {
                        brandDict[Convert.ToInt32(row["BrandId"])] = row["BrandName"]?.ToString() ?? "";
                    }
                }
                cboxBrand.DataSource = dtBrd;
                cboxBrand.DisplayMember = "BrandName";
                cboxBrand.ValueMember = "BrandId";
                cboxBrand.SelectedIndex = -1;

                // Suppliers
                DataTable dtSup = purchaseCtrl.GetSuppliers();
                supplierDict.Clear();
                foreach (DataRow row in dtSup.Rows)
                {
                    if (row["SupplierId"] != DBNull.Value)
                    {
                        supplierDict[Convert.ToInt32(row["SupplierId"])] = row["SupplierName"]?.ToString() ?? "";
                    }
                }
                cboxSupplier.DataSource = dtSup;
                cboxSupplier.DisplayMember = "SupplierName";
                cboxSupplier.ValueMember = "SupplierId";
                cboxSupplier.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Dropdown Data Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            DE_Functions.ClearTxtAndCbox(this);
            DE_Functions.DisableTxtAndCbox(this);
            dtpPurchaseDate.Enabled = false;
            dtpPurchaseDate.Value = DateTime.Now;
            txtPurchaseId.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Text = "0.00";

            btnAdd.Text = "Add";
            btnAdd.Enabled = true;
            btnUpdate.Text = "Update";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void uc_Purchase_Load(object sender, EventArgs e)
        {
            dgPurchase.AutoGenerateColumns = false;
            LoadDropdownData();
            ResetForm();
            GetPurchaseData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                DE_Functions.EnableTxtAndCbox(this);
                txtPurchaseId.Enabled = false;
                txtTotalPrice.Enabled = false;
                dtpPurchaseDate.Enabled = true;

                txtPurchaseId.Clear();
                txtUnitPrice.Clear();
                txtQty.Clear();
                txtTotalPrice.Text = "0.00";
                cboxAccessory.SelectedIndex = -1;
                cboxCategory.SelectedIndex = -1;
                cboxBrand.SelectedIndex = -1;
                cboxSupplier.SelectedIndex = -1;
                dtpPurchaseDate.Value = DateTime.Now;

                btnAdd.Text = "Insert";
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnUpdate.Text = "Clear";
                btnDelete.Enabled = false;
                cboxAccessory.Focus();
            }
            else if (btnAdd.Text == "Insert")
            {
                if (cboxAccessory.SelectedIndex == -1 || cboxCategory.SelectedIndex == -1 ||
                    cboxBrand.SelectedIndex == -1 || cboxSupplier.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    MessageBox.Show("Please Check Purchase Info", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice) || unitPrice < 0)
                    {
                        MessageBox.Show("Please enter a valid Unit Price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnitPrice.Focus();
                        return;
                    }
                    if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty <= 0)
                    {
                        MessageBox.Show("Please enter a valid Quantity greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQty.Focus();
                        return;
                    }

                    purchaseCtrl.AccesoryId = Convert.ToInt32(cboxAccessory.SelectedValue);
                    purchaseCtrl.SupplierId = Convert.ToInt32(cboxSupplier.SelectedValue);
                    purchaseCtrl.CategoryId = Convert.ToInt32(cboxCategory.SelectedValue);
                    purchaseCtrl.BrandId = Convert.ToInt32(cboxBrand.SelectedValue);
                    purchaseCtrl.UnitPrice = unitPrice;
                    purchaseCtrl.Qty = qty;
                    purchaseCtrl.Purchase_date = dtpPurchaseDate.Value;
                    purchaseCtrl.Total = unitPrice * qty;

                    purchaseCtrl.InsertPurchase();

                    MessageBox.Show("Purchase Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPurchaseData();
                    ResetForm();
                }
            }
            else if (btnAdd.Text == "Clear")
            {
                ResetForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Clear")
            {
                ResetForm();
            }
            else if (btnUpdate.Text == "Update")
            {
                if (string.IsNullOrWhiteSpace(txtPurchaseId.Text) ||
                    cboxAccessory.SelectedIndex == -1 || cboxCategory.SelectedIndex == -1 ||
                    cboxBrand.SelectedIndex == -1 || cboxSupplier.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    MessageBox.Show("Please Check Purchase Info", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(txtPurchaseId.Text.Trim(), out int purchaseId))
                    {
                        MessageBox.Show("Please select a valid purchase from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice) || unitPrice < 0)
                    {
                        MessageBox.Show("Please enter a valid Unit Price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnitPrice.Focus();
                        return;
                    }
                    if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty <= 0)
                    {
                        MessageBox.Show("Please enter a valid Quantity greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQty.Focus();
                        return;
                    }

                    purchaseCtrl.PurchaseId = purchaseId;
                    purchaseCtrl.AccesoryId = Convert.ToInt32(cboxAccessory.SelectedValue);
                    purchaseCtrl.SupplierId = Convert.ToInt32(cboxSupplier.SelectedValue);
                    purchaseCtrl.CategoryId = Convert.ToInt32(cboxCategory.SelectedValue);
                    purchaseCtrl.BrandId = Convert.ToInt32(cboxBrand.SelectedValue);
                    purchaseCtrl.UnitPrice = unitPrice;
                    purchaseCtrl.Qty = qty;
                    purchaseCtrl.Purchase_date = dtpPurchaseDate.Value;
                    purchaseCtrl.Total = unitPrice * qty;

                    purchaseCtrl.UpdatePurchase();

                    MessageBox.Show("Purchase Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPurchaseData();
                    ResetForm();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (int.TryParse(txtPurchaseId.Text.Trim(), out int purchaseId))
                {
                    purchaseCtrl.PurchaseId = purchaseId;
                    purchaseCtrl.DeletePurchase();

                    MessageBox.Show("Purchase Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPurchaseData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Please select a valid purchase to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal price) && int.TryParse(txtQty.Text.Trim(), out int qty))
            {
                txtTotalPrice.Text = (price * qty).ToString("0.00");
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }

        public void GetPurchaseData()
        {
            purchaseCtrl.GetPurchaseData();
            dgPurchase.DataSource = purchaseCtrl.dt;
        }

        private void dgPurchase_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgPurchase.Rows[e.RowIndex];

                    txtPurchaseId.Text = row.Cells["colPurchaseId"].Value?.ToString() ?? "";

                    if (row.Cells["colAccessory"].Value != null && int.TryParse(row.Cells["colAccessory"].Value.ToString(), out int accId))
                    {
                        cboxAccessory.SelectedValue = accId;
                    }
                    if (row.Cells["colSupplier"].Value != null && int.TryParse(row.Cells["colSupplier"].Value.ToString(), out int supId))
                    {
                        cboxSupplier.SelectedValue = supId;
                    }
                    if (row.Cells["colCategory"].Value != null && int.TryParse(row.Cells["colCategory"].Value.ToString(), out int catId))
                    {
                        cboxCategory.SelectedValue = catId;
                    }
                    if (row.Cells["colBrand"].Value != null && int.TryParse(row.Cells["colBrand"].Value.ToString(), out int brandId))
                    {
                        cboxBrand.SelectedValue = brandId;
                    }

                    if (row.Cells["colUnitPrice"].Value != null && decimal.TryParse(row.Cells["colUnitPrice"].Value.ToString(), out decimal unitPrice))
                    {
                        txtUnitPrice.Text = unitPrice.ToString("0.00");
                    }
                    else
                    {
                        txtUnitPrice.Text = row.Cells["colUnitPrice"].Value?.ToString() ?? "";
                    }

                    txtQty.Text = row.Cells["colQty"].Value?.ToString() ?? "";

                    if (row.Cells["colTotal"].Value != null && decimal.TryParse(row.Cells["colTotal"].Value.ToString(), out decimal total))
                    {
                        txtTotalPrice.Text = total.ToString("0.00");
                    }
                    else
                    {
                        txtTotalPrice.Text = row.Cells["colTotal"].Value?.ToString() ?? "";
                    }

                    if (row.Cells["colPurchaseDate"].Value != null && DateTime.TryParse(row.Cells["colPurchaseDate"].Value.ToString(), out DateTime dt))
                    {
                        dtpPurchaseDate.Value = dt;
                    }

                    DE_Functions.EnableTxtAndCbox(this);
                    txtPurchaseId.Enabled = false;
                    txtTotalPrice.Enabled = false;
                    dtpPurchaseDate.Enabled = true;

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = true;
                    btnAdd.Text = "Clear";

                    if (btnAdd.Text == "Clear")
                    {
                        btnUpdate.Text = "Update";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPurchase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            string colName = dgPurchase.Columns[e.ColumnIndex].Name;

            if (colName == "colAccessory" && int.TryParse(e.Value.ToString(), out int accId) && accessoryDict.TryGetValue(accId, out string accName))
            {
                e.Value = accName;
                e.FormattingApplied = true;
            }
            else if (colName == "colSupplier" && int.TryParse(e.Value.ToString(), out int supId) && supplierDict.TryGetValue(supId, out string supName))
            {
                e.Value = supName;
                e.FormattingApplied = true;
            }
            else if (colName == "colCategory" && int.TryParse(e.Value.ToString(), out int catId) && categoryDict.TryGetValue(catId, out string catName))
            {
                e.Value = catName;
                e.FormattingApplied = true;
            }
            else if (colName == "colBrand" && int.TryParse(e.Value.ToString(), out int brandId) && brandDict.TryGetValue(brandId, out string brandName))
            {
                e.Value = brandName;
                e.FormattingApplied = true;
            }
            else if (colName == "colUnitPrice" && decimal.TryParse(e.Value.ToString(), out decimal unitPrice))
            {
                e.Value = $"$ {unitPrice:F2}";
                e.FormattingApplied = true;
            }
            else if (colName == "colTotal" && decimal.TryParse(e.Value.ToString(), out decimal total))
            {
                e.Value = $"$ {total:F2}";
                e.FormattingApplied = true;
            }
            else if (colName == "colPurchaseDate" && DateTime.TryParse(e.Value.ToString(), out DateTime pDate))
            {
                e.Value = pDate.ToString("yyyy-MM-dd");
                e.FormattingApplied = true;
            }
        }
    }
}
