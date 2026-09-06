using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace inventory_system.Controller
{
    internal class ControllerCategory : Models.CategoryModels
    {
        // Insert Category
        public void InsertCategory()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("InsertCategory", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryName", this.CategoryName?.Trim() ?? string.Empty);

                    // Convert string "Active" to 1, otherwise 0
                    int statusValue = string.Equals(this.CategoryStatus, "Active", StringComparison.OrdinalIgnoreCase) ? 1 : 0;
                    cmd.Parameters.AddWithValue("@CategoryStatus", statusValue);

                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }

                MessageBox.Show("Category inserted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category Inserted Failed: " + ex.Message,
                    "Cannot Insert Category", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Update Category
        public void UpdateCategory()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("UpdateCategory", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", this.CategoryId);
                    cmd.Parameters.AddWithValue("@CategoryName", this.CategoryName?.Trim() ?? string.Empty);

                    int statusValue = string.Equals(this.CategoryStatus, "Active", StringComparison.OrdinalIgnoreCase) ? 1 : 0;
                    cmd.Parameters.AddWithValue("@CategoryStatus", statusValue);

                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }

                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category Update Failed: " + ex.Message, "Cannot Update Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Category
        public void DeleteCategory()
        {
            try
            {
                connection_db db = new connection_db();
                if (db.conn.State != ConnectionState.Open)
                {
                    db.conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand("DeleteCategory", db.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", this.CategoryId);

                    cmd.ExecuteNonQuery();
                }

                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }

                MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category Deletion Failed: " + ex.Message, "Cannot Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Get Category Data Failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}