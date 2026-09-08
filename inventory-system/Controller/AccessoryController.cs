using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.Controller
{
    public class AccessoryController : Models.AccessoryModel
    {
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        // Insert Accessory
        public void InsertAccessory()
        {
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertAccessory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@AccessoryName", SqlDbType.NVarChar, 100).Value = (object)AccessoryName ?? DBNull.Value;
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = Price;
                        cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId > 0 ? (object)CategoryId : DBNull.Value;
                        cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierId > 0 ? (object)SupplierId : DBNull.Value;
                        cmd.Parameters.Add("@ModelId", SqlDbType.Int).Value = ModelId > 0 ? (object)ModelId : DBNull.Value;
                        cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(Status) ? "IN" : Status.Trim();
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = (object)Description ?? DBNull.Value;
                        cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = (UserId.HasValue && UserId.Value > 0) ? (object)UserId.Value : (UserDetail.UserId > 0 ? (object)UserDetail.UserId : DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Accessory Insert Failed: " + ex.Message, "Cannot Insert Accessory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        // Update Accessory
        public void UpdateAccessory()
        {
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateAccessory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@AccessoryId", SqlDbType.Int).Value = AccessoryId;
                        cmd.Parameters.Add("@AccessoryName", SqlDbType.NVarChar, 100).Value = (object)AccessoryName ?? DBNull.Value;
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = Price;
                        cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId > 0 ? (object)CategoryId : DBNull.Value;
                        cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierId > 0 ? (object)SupplierId : DBNull.Value;
                        cmd.Parameters.Add("@ModelId", SqlDbType.Int).Value = ModelId > 0 ? (object)ModelId : DBNull.Value;
                        cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(Status) ? "IN" : Status.Trim();
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = (object)Description ?? DBNull.Value;
                        cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = (UserId.HasValue && UserId.Value > 0) ? (object)UserId.Value : (UserDetail.UserId > 0 ? (object)UserDetail.UserId : DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Accessory Update Failed: " + ex.Message, "Cannot Update Accessory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        // Delete Accessory
        public void DeleteAccessory()
        {
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteAccessory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@AccessoryId", SqlDbType.Int).Value = AccessoryId;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Accessory Delete Failed: " + ex.Message, "Cannot Delete Accessory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        // Get Accessory Data for Grid
        public void GetAccessoryData()
        {
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = @"
                        SELECT 
                            a.AccessoryId,
                            ISNULL(NULLIF(a.AccessoryName, ''), a.Description) AS AccessoryName,
                            ISNULL(c.CategoryName, 'N/A') AS CategoryName,
                            ISNULL(s.SupplierName, 'N/A') AS SupplierName,
                            ISNULL(m.ModelName, 'N/A') AS ModelName,
                            ISNULL(a.Price, 0) AS Price,
                            ISNULL(a.Status, 'IN') AS Status,
                            ISNULL(a.Description, '') AS Description,
                            ISNULL(a.CategoryId, 0) AS CategoryId,
                            ISNULL(a.SupplierId, 0) AS SupplierId,
                            ISNULL(a.ModelId, 0) AS ModelId
                        FROM tblAccessory a
                        LEFT JOIN tblCategory c ON a.CategoryId = c.CategoryId
                        LEFT JOIN tblSupplier s ON a.SupplierId = s.SupplierId
                        LEFT JOIN tblModel m ON a.ModelId = m.ModelId
                        ORDER BY a.AccessoryId DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable newDt = new DataTable();
                        da.Fill(newDt);
                        dt = newDt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Accessory data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lookup Categories
        public DataTable GetCategories()
        {
            DataTable dtCat = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT CategoryId, CategoryName FROM tblCategory ORDER BY CategoryName";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dtCat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Categories Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtCat;
        }

        // Lookup Suppliers
        public DataTable GetSuppliers()
        {
            DataTable dtSup = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT SupplierId, SupplierName FROM tblSupplier ORDER BY SupplierName";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dtSup);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Suppliers Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtSup;
        }

        // Lookup Models
        public DataTable GetModels()
        {
            DataTable dtMod = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT ModelId, ModelName FROM tblModel ORDER BY ModelName";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dtMod);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Models Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtMod;
        }
    }
}
