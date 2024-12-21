using InlamnDatabas.Entities;
using System.Data;
using System.Data.SqlClient;

namespace InlamnDatabas.Repository
{
    public class UserRepo
    {
        public List<User> GetUser(string username, string password)
        {
            string sql = "select userid, username, password from [User] " +
                         "where username like @coditionusername and password like @coditionpassword";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@coditionusername", username));
            parameters.Add(new SqlParameter("@coditionpassword", password));

            DataTable users = DataContext.ExecuteCommandReturnTable(sql, parameters);

            List<User> usersList = new();

            foreach(DataRow row in users.Rows)
            {
                usersList.Add(new User((int)row[0], row[1].ToString(), row[2].ToString()));
            }
            return usersList;
        }

        public void SaveUser(string username, string password)
        {
            string sql = "insert into [User](username, password)" +
                         "values(@username, @password)";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@username", username));
            parameters.Add(new SqlParameter("@password", password));

            DataContext.ExecuteCommandVoid(sql, parameters);
        }
    }
}
