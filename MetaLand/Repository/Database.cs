using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public class Database
    {
        public string MyProperty { get; set; }
        public static string connectionString = "Data Source=.;Initial Catalog=MultiLand;Integrated Security=True";
        public static string Query { get; set; }
        static SqlConnection connection = new SqlConnection(connectionString);
 
        public bool Login()
        {
            connection.Open();
            Query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.AddWithValue("@Username", User.Username);
                command.Parameters.AddWithValue("@Password", User.password);

                int count = (int)command.ExecuteScalar();

                connection.Close();
                return count > 0;
            }
        }
    }
}
