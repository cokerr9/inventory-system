using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_system.Controller;

namespace inventory_system.View
{
    public partial class uc_Dashboard : UserControl
    {
        private DashboardController dashboardCtrl = new DashboardController();
        private bool isInitializing = false;

        public uc_Dashboard()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void uc_Dashboard_Load(object sender, EventArgs e)
        {
            LoadSummaryCounts();
            LoadFilterDropdowns();
            LoadFilteredAccessories();
        }

        /// <summary>
        /// Loads summary KPIs from the database into the top dashboard cards.
        /// </summary>
        private void LoadSummaryCounts()
        {
            try
            {
                DashboardSummaryModel summary = dashboardCtrl.GetDashboardSummary();
                lblTotalAccessories.Text = summary.TotalAccessories.ToString("N0");
                lblTotalStock.Text = $"Total Stock: {summary.TotalStockQty:N0} units";
                lblTotalModels.Text = summary.TotalModels.ToString("N0");
                lblTotalBrands.Text = summary.TotalBrands.ToString("N0");
                lblTotalPurchases.Text = summary.TotalPurchases.ToString("N0");
                lblTotalPurchasesSub.Text = $"Orders | Spend: ${summary.TotalPurchaseAmount:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Populates Model, Brand, and Category filter dropdowns.
        /// </summary>
        private void LoadFilterDropdowns()
        {
            isInitializing = true;
            try
            {
                // Populate Models
                DataTable dtModels = dashboardCtrl.GetModelFilterList();
                cboxFilterModel.DataSource = dtModels;
                cboxFilterModel.DisplayMember = "ModelName";
                cboxFilterModel.ValueMember = "ModelId";
                cboxFilterModel.SelectedIndex = 0;

                // Populate Brands
                DataTable dtBrands = dashboardCtrl.GetBrandFilterList();
                cboxFilterBrand.DataSource = dtBrands;
                cboxFilterBrand.DisplayMember = "BrandName";
                cboxFilterBrand.ValueMember = "BrandId";
                cboxFilterBrand.SelectedIndex = 0;

                // Populate Categories
                DataTable dtCategories = dashboardCtrl.GetCategoryFilterList();
                cboxFilterCategory.DataSource = dtCategories;
                cboxFilterCategory.DisplayMember = "CategoryName";
                cboxFilterCategory.ValueMember = "CategoryId";
                cboxFilterCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isInitializing = false;
            }
        }

        /// <summary>
        /// Queries and displays filtered accessories in the DataGridView.
        /// </summary>
        private void LoadFilteredAccessories()
        {
            try
            {
                string search = txtSearchAccessory.Text.Trim();

                int brandId = 0;
                if (cboxFilterBrand.SelectedValue != null && int.TryParse(cboxFilterBrand.SelectedValue.ToString(), out int bId))
                {
                    brandId = bId;
                }

                int modelId = 0;
                if (cboxFilterModel.SelectedValue != null && int.TryParse(cboxFilterModel.SelectedValue.ToString(), out int mId))
                {
                    modelId = mId;
                }

                int categoryId = 0;
                if (cboxFilterCategory.SelectedValue != null && int.TryParse(cboxFilterCategory.SelectedValue.ToString(), out int cId))
                {
                    categoryId = cId;
                }

                DataTable dt = dashboardCtrl.GetFilteredAccessories(search, brandId, modelId, categoryId);
                dgvDashboardAccessories.DataSource = dt;

                // Calculate live summary indicators
                int count = dt.Rows.Count;
                int totalUnits = 0;
                decimal totalValue = 0m;

                foreach (DataRow row in dt.Rows)
                {
                    int qty = row["Qty"] != DBNull.Value ? Convert.ToInt32(row["Qty"]) : 0;
                    decimal price = row["Price"] != DBNull.Value ? Convert.ToDecimal(row["Price"]) : 0m;
                    totalUnits += qty;
                    totalValue += (qty * price);
                }

                lblFilterSummary.Text = $"Showing {count} items | Stock: {totalUnits:N0} units | Value: ${totalValue:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to filter accessories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchAccessory_TextChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadFilteredAccessories();
            }
        }

        private void cboxFilterModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadFilteredAccessories();
            }
        }

        private void cboxFilterBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadFilteredAccessories();
            }
        }

        private void cboxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadFilteredAccessories();
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            isInitializing = true;
            txtSearchAccessory.Text = string.Empty;
            if (cboxFilterModel.Items.Count > 0) cboxFilterModel.SelectedIndex = 0;
            if (cboxFilterBrand.Items.Count > 0) cboxFilterBrand.SelectedIndex = 0;
            if (cboxFilterCategory.Items.Count > 0) cboxFilterCategory.SelectedIndex = 0;
            isInitializing = false;

            LoadFilteredAccessories();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSummaryCounts();
            LoadFilterDropdowns();
            LoadFilteredAccessories();
        }

        private void dgvDashboardAccessories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvDashboardAccessories.Columns[e.ColumnIndex].Name;

            if (colName == "colStatus" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "In Stock")
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.Font = new Font(dgvDashboardAccessories.Font, FontStyle.Bold);
                }
                else if (status == "Low Stock")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    e.CellStyle.Font = new Font(dgvDashboardAccessories.Font, FontStyle.Bold);
                }
                else if (status == "Out of Stock")
                {
                    e.CellStyle.ForeColor = Color.Crimson;
                    e.CellStyle.Font = new Font(dgvDashboardAccessories.Font, FontStyle.Bold);
                }
            }
            else if (colName == "colPrice" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal price))
                {
                    e.Value = price.ToString("$#,##0.00");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
