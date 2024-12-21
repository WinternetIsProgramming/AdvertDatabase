using System.Data;
using System.Data.SqlClient;

namespace InlamnDatabas.Repository
{
    public static class DataContext
    {

        private static string _connString = "Data Source=localhost;Initial Catalog=AnnonsDB;Integrated Security=SSPI;TrustServerCertificate=True;";

        public static DataTable ExecuteCommandReturnTable(string sql, List<SqlParameter> parameters)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }

            return data;
        }

        public static void ExecuteCommandVoid(string sql, List<SqlParameter> parameters)
        {
            using(SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach(SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}
