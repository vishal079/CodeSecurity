using System;
using System.Data;
using System.Data.SqlClient;

namespace TestConsoleApp1
{
    public class EmployeeDA
    {
        public string query { get; set; }
        public DataTable ExecuteSql()
        {
            DataTable dt = new DataTable();
            string Conn = @"data source=192.168.51.158;initial catalog=Employee;persist security info=True;user id=sa;password=Dr.Nstein;";

            using (SqlConnection sqlConn = new SqlConnection(Conn))
            {
                try
                {
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = string.Format("{0}", query);
                        sqlCmd.Connection = sqlConn;
                        sqlCmd.CommandType = CommandType.Text;
                        sqlConn.Open();

                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                        {
                            sqlAdapter.Fill(dt);
                        }

                        sqlCmd.Clone();
                        sqlCmd.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    sqlConn.Close();
                    throw ex;
                }
                finally
                {
                    sqlConn.Dispose();
                    sqlConn.Close();
                }

            }


            return dt;
        }
    }
}
