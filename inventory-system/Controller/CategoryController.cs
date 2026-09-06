using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventory_system.Controller
{
    internal class CategoryController : Models.ModelsCategory
    {
        // Insert Category
        public void InsertUser()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("InsertUser", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = CategoryName;
                    cmd.Parameters.Add("@CategoryStatus", SqlDbType.NVarChar).Value = CategoryStatus;
                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category Inserted Failed: " + ex.Message,
                    "Cannot Insert Category", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Get data from Category 
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public void GetCategoryData()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                string sql = "SELECT * FROM tblCategory";
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
                MessageBox.Show("Get Category Data Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
