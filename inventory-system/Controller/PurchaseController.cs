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



















        // Get data from Users
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

                string sql = "SELECT * FROM tblPurchase";
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
    }
}
