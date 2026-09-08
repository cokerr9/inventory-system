using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Controller
{
    internal class ControllerBrands : Models.ModelsBrands
    {
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public void InsertBrand()
        {
            connection_db db = new connection_db();
            try
            {
                OpenConnection(db);

                using (SqlCommand cmd = new SqlCommand("InsertBrand", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BrandName", SqlDbType.NVarChar).Value = BrandName;
                    cmd.Parameters.Add("@BrandStatus", SqlDbType.NVarChar).Value = BrandStatus;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting brand: " + ex.Message);
            }
            finally
            {
                CloseConnection(db);
            }
                   
        }
        public void DeleteBrand()
        {
            connection_db db = new connection_db();
            try
            {
                OpenConnection( db );
                using (SqlCommand cmd = new SqlCommand("DeleteBrand", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BrandId", SqlDbType.Int).Value = BrandId;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting brand: " + ex.Message);
            }
            finally
            {
                CloseConnection(db);
            }
        }
        public void viewBrand()
        {
            connection_db db = new connection_db();
            try
            {
                OpenConnection(db);
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ViewBrand", db.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error viewing brands: " + ex.Message);
            }
            finally
            {
                CloseConnection(db);
            }
        }
        public void OpenConnection(connection_db db)
        {
            if (db.conn != null && db.conn.State != ConnectionState.Open)
                db.conn.Open();
        }

        public void CloseConnection(connection_db db)
        {
            if (db.conn != null && db.conn.State != ConnectionState.Closed)
                db.conn.Close();
        }
        public void UpdateBrand()
        {
            connection_db db = new connection_db();
            try
            {
                OpenConnection(db);
                using (SqlCommand cmd = new SqlCommand("UpdateBrand", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BrandId", SqlDbType.Int).Value = BrandId;
                    cmd.Parameters.Add("@BrandName", SqlDbType.NVarChar).Value = BrandName;
                    cmd.Parameters.Add("@BrandStatus", SqlDbType.NVarChar).Value = BrandStatus;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating brands: " + ex.Message);
            }
            finally
            {
                CloseConnection(db);
            }
        }
    }
}
