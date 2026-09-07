using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_system.Controller
{
    internal class ControllerSetting : Models.ModelsSetting
    {
        public void InsertSetting()
        {
            bool closeConnection = false;
            try
            {
                closeConnection = EnsureConnectionIsOpen();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("InsertSetting", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50).Value = (object)CompanyName ?? DBNull.Value;
                        cmd.Parameters.Add("@CompanyLogo", SqlDbType.VarBinary, -1).Value = (object)CompanyLogo ?? DBNull.Value;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2812) // Stored procedure not found
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblSetting (CompanyName, CompanyLogo) VALUES (@CompanyName, @CompanyLogo)", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50).Value = (object)CompanyName ?? DBNull.Value;
                        cmd.Parameters.Add("@CompanyLogo", SqlDbType.VarBinary, -1).Value = (object)CompanyLogo ?? DBNull.Value;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Insert setting failed: " + ex.Message, ex);
            }
            finally
            {
                CloseConnectionIfOpened(closeConnection);
            }
        }

        public void UpdateSetting()
        {
            bool closeConnection = false;
            try
            {
                closeConnection = EnsureConnectionIsOpen();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateSetting", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = CompanyId;
                        cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50).Value = (object)CompanyName ?? DBNull.Value;
                        cmd.Parameters.Add("@CompanyLogo", SqlDbType.VarBinary, -1).Value = (object)CompanyLogo ?? DBNull.Value;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2812) // Stored procedure not found
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE tblSetting SET CompanyName = @CompanyName, CompanyLogo = @CompanyLogo WHERE CompanyId = @CompanyId", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = CompanyId;
                        cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50).Value = (object)CompanyName ?? DBNull.Value;
                        cmd.Parameters.Add("@CompanyLogo", SqlDbType.VarBinary, -1).Value = (object)CompanyLogo ?? DBNull.Value;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Update setting failed: " + ex.Message, ex);
            }
            finally
            {
                CloseConnectionIfOpened(closeConnection);
            }
        }

        public bool LoadCompanySetting(int? companyId = null)
        {
            bool closeConnection = false;
            try
            {
                closeConnection = EnsureConnectionIsOpen();

                string query;
                if (companyId.HasValue && companyId.Value > 0)
                {
                    query = "SELECT TOP 1 CompanyId, CompanyName, CompanyLogo FROM tblSetting WHERE CompanyId = @CompanyId";
                }
                else
                {
                    query = "SELECT TOP 1 CompanyId, CompanyName, CompanyLogo FROM tblSetting ORDER BY CompanyId DESC";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (companyId.HasValue && companyId.Value > 0)
                    {
                        cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = companyId.Value;
                    }

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            CompanyId = Convert.ToInt32(dr["CompanyId"]);
                            CompanyName = dr["CompanyName"] != DBNull.Value ? dr["CompanyName"].ToString() : string.Empty;
                            CompanyLogo = dr["CompanyLogo"] != DBNull.Value ? (byte[])dr["CompanyLogo"] : null;
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Load setting failed: " + ex.Message, ex);
            }
            finally
            {
                CloseConnectionIfOpened(closeConnection);
            }
        }


        public System.Drawing.Image GetCompanyLogo()
        {
            return GetCompanyLogo("SELECT TOP 1 CompanyLogo FROM tblSetting ORDER BY CompanyId DESC", null);
        }

        public System.Drawing.Image GetCompanyLogo(int companyId)
        {
            return GetCompanyLogo("SELECT CompanyLogo FROM tblSetting WHERE CompanyId = @CompanyId", companyId);
        }

        private System.Drawing.Image GetCompanyLogo(string sql, int? companyId)
        {
            bool closeConnection = false;
            try
            {
                closeConnection = EnsureConnectionIsOpen();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (companyId.HasValue)
                    {
                        cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = companyId.Value;
                    }

                    object value = cmd.ExecuteScalar();
                    if (value == null || value == DBNull.Value)
                    {
                        return null;
                    }

                    byte[] img = (byte[])value;
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(img))
                    using (System.Drawing.Image logo = System.Drawing.Image.FromStream(ms))
                    {
                        return new System.Drawing.Bitmap(logo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Load company logo failed: " + ex.Message, ex);
            }
            finally
            {
                CloseConnectionIfOpened(closeConnection);
            }
        }

        private bool EnsureConnectionIsOpen()
        {
            if (conn == null)
            {
                throw new InvalidOperationException("Database connection failed to initialize. Check your server configuration.");
            }

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                return true;
            }

            return false;
        }

        private void CloseConnectionIfOpened(bool closeConnection)
        {
            if (closeConnection && conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
