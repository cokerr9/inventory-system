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
    internal class PurchaseController : Models.PurchaseModels
    {
        // Insert Purchase
        public void InsertPurchase()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("InsertPurchase", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@AceesoryId", SqlDbType.Int).Value = AccesoryId;
                    cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierId;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId;
                    cmd.Parameters.Add("@BrandId", SqlDbType.Int).Value = BrandId;
                    cmd.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = UnitPrice;
                    cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
                    cmd.Parameters.Add("@Purchase_date", SqlDbType.DateTime).Value = Purchase_date;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Purchase Inserted Failed: " + ex.Message,
                    "Cannot Insert Purchase", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Update Purchase
        public void UpdatePurchase()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("UpdatePurchase", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PurchaseId", SqlDbType.Int).Value = PurchaseId;
                    cmd.Parameters.Add("@AceesoryId", SqlDbType.Int).Value = AccesoryId;
                    cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierId;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId;
                    cmd.Parameters.Add("@BrandId", SqlDbType.Int).Value = BrandId;
                    cmd.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = UnitPrice;
                    cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
                    cmd.Parameters.Add("@Purchase_date", SqlDbType.DateTime).Value = Purchase_date;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Purchase Update Failed: " + ex.Message,
                    "Cannot Update Purchase", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Delete Purchase
        public void DeletePurchase()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("DeletePurchase", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PurchaseId", SqlDbType.Int).Value = PurchaseId;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Purchase Delete Failed: " + ex.Message,
                    "Cannot Delete Purchase", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Get data from Purchases
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public void GetPurchaseData()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                string sql = "SELECT PurchaseId, AceesoryId AS AccesoryId, AceesoryId, SupplierId, CategoryId, BrandId, UnitPrice, Qty, Total, Purchase_date FROM tblPurchase ORDER BY PurchaseId DESC";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                adapter.SelectCommand = cmd;
                ds.Clear();
                adapter.Fill(ds);
                dt = ds.Tables[0];

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Purchase Data Failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lookup Accessories
        public DataTable GetAccessories()
        {
            DataTable dtAcc = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT AccessoryId, ISNULL(Description, 'Accessory #' + CAST(AccessoryId AS VARCHAR)) AS AccessoryName FROM tblAccessory";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dtAcc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Accessories Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtAcc;
        }

        // Lookup Categories
        public DataTable GetCategories()
        {
            DataTable dtCat = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT CategoryId, CategoryName FROM tblCategory";
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

        // Lookup Brands
        public DataTable GetBrands()
        {
            DataTable dtBrd = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT BrandId, BrandName FROM tblBrand";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dtBrd);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Brands Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtBrd;
        }

        // Lookup Suppliers
        public DataTable GetSuppliers()
        {
            DataTable dtSup = new DataTable();
            try
            {
                using (SqlConnection conn = connection_db.GetConnection())
                {
                    string sql = "SELECT SupplierId, SupplierName FROM tblSupplier";
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
    }
}
