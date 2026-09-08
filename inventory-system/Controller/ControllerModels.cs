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
    internal class ControllerModels : Models.Modelmodels
    {
        // Insert Model
        public void InsertModel()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("InsertModel", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ModelName", SqlDbType.NVarChar).Value = ModelName ?? string.Empty;
                    cmd.Parameters.Add("@ModelStatus", SqlDbType.Int).Value = ModelStatus;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Inserted Failed: " + ex.Message,
                    "Cannot Insert Model", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Update Model
        public void UpdateModel()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("UpdateModel", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ModelId", SqlDbType.Int).Value = ModelId;
                    cmd.Parameters.Add("@ModelName", SqlDbType.NVarChar).Value = ModelName ?? string.Empty;
                    cmd.Parameters.Add("@ModelStatus", SqlDbType.Int).Value = ModelStatus;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Update Failed: " + ex.Message,
                    "Cannot Update Model", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Delete Model
        public void DeleteModel()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("DeleteModel", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ModelId", SqlDbType.Int).Value = ModelId;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Delete Failed: " + ex.Message,
                    "Cannot Delete Model", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Get Model Data
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public void GetModelData()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                string sql = "SELECT ModelId, ModelName, ModelStatus FROM tblModel ORDER BY ModelId DESC";
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
                MessageBox.Show("Get Model Data Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
