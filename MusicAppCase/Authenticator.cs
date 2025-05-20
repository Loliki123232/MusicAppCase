using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MusicAppCase
{
    internal class Authenticator
    {
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        public bool AreCredentialsValidLogin(string login, string password)
        {
            login = login.Trim();
            password = password.Trim();
            string query = "SELECT COUNT(*) FROM LoginTable WHERE Login = @Login AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
