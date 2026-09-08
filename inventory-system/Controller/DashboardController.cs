using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace inventory_system.Controller
{
    public class DashboardSummaryModel
    {
        public int TotalAccessories { get; set; }
        public int TotalStockQty { get; set; }
        public int TotalModels { get; set; }
        public int TotalBrands { get; set; }
        public int TotalPurchases { get; set; }
        public decimal TotalPurchaseAmount { get; set; }
    }

    public class DashboardController
    {
        public DashboardSummaryModel GetDashboardSummary()
        {
            DashboardSummaryModel summary = new DashboardSummaryModel();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = @"
                        SELECT 
                            (SELECT COUNT(*) FROM tblAccessory) AS TotalAccessories,
                            (SELECT ISNULL(SUM(Qty), 0) FROM tblAccessory) AS TotalStockQty,
                            (SELECT COUNT(*) FROM tblModel) AS TotalModels,
                            (SELECT COUNT(*) FROM tblBrand) AS TotalBrands,
                            (SELECT COUNT(*) FROM tblPurchase) AS TotalPurchases,
                            (SELECT ISNULL(SUM(Total), 0) FROM tblPurchase) AS TotalPurchaseAmount";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            summary.TotalAccessories = reader["TotalAccessories"] != DBNull.Value ? Convert.ToInt32(reader["TotalAccessories"]) : 0;
                            summary.TotalStockQty = reader["TotalStockQty"] != DBNull.Value ? Convert.ToInt32(reader["TotalStockQty"]) : 0;
                            summary.TotalModels = reader["TotalModels"] != DBNull.Value ? Convert.ToInt32(reader["TotalModels"]) : 0;
                            summary.TotalBrands = reader["TotalBrands"] != DBNull.Value ? Convert.ToInt32(reader["TotalBrands"]) : 0;
                            summary.TotalPurchases = reader["TotalPurchases"] != DBNull.Value ? Convert.ToInt32(reader["TotalPurchases"]) : 0;
                            summary.TotalPurchaseAmount = reader["TotalPurchaseAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPurchaseAmount"]) : 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return summary;
        }

        public DataTable GetBrandFilterList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT 0 AS BrandId, '-- All Brands --' AS BrandName UNION ALL SELECT BrandId, BrandName FROM tblBrand";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load brand filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetModelFilterList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT 0 AS ModelId, '-- All Models --' AS ModelName UNION ALL SELECT ModelId, ModelName FROM tblModel";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load model filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetCategoryFilterList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT 0 AS CategoryId, '-- All Categories --' AS CategoryName UNION ALL SELECT CategoryId, CategoryName FROM tblCategory";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load category filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetFilteredAccessories(string search, int brandId, int modelId, int categoryId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = @"
                        SELECT 
                            a.AccessoryId,
                            ISNULL(a.Description, 'Accessory #' + CAST(a.AccessoryId AS VARCHAR)) AS AccessoryName,
                            ISNULL(b.BrandName, 'N/A') AS BrandName,
                            ISNULL(m.ModelName, 'N/A') AS ModelName,
                            ISNULL(c.CategoryName, 'N/A') AS CategoryName,
                            ISNULL(a.Price, 0) AS Price,
                            ISNULL(a.Qty, 0) AS Qty,
                            CASE 
                                WHEN ISNULL(a.Qty, 0) <= 0 THEN 'Out of Stock'
                                WHEN a.Qty <= 5 THEN 'Low Stock'
                                ELSE 'In Stock'
                            END AS StockStatus
                        FROM tblAccessory a
                        LEFT JOIN tblBrand b ON a.BrandId = b.BrandId
                        LEFT JOIN tblModel m ON a.ModelId = m.ModelId
                        LEFT JOIN tblCategory c ON a.CategoryId = c.CategoryId
                        WHERE (@brandId = 0 OR a.BrandId = @brandId)
                          AND (@modelId = 0 OR a.ModelId = @modelId)
                          AND (@categoryId = 0 OR a.CategoryId = @categoryId)
                          AND (
                              @search = '' 
                              OR a.Description LIKE '%' + @search + '%'
                              OR b.BrandName LIKE '%' + @search + '%'
                              OR m.ModelName LIKE '%' + @search + '%'
                          )
                        ORDER BY a.AccessoryId DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@brandId", SqlDbType.Int).Value = brandId;
                        cmd.Parameters.Add("@modelId", SqlDbType.Int).Value = modelId;
                        cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                        cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = (search ?? "").Trim();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load filtered accessories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
