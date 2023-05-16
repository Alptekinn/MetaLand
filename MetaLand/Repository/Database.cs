using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            Query = "SELECT COUNT(*) FROM Tbl_User WHERE User_NickName = @Username AND User_Pass = @Password";
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.AddWithValue("@Username", User.UserNickname);
                command.Parameters.AddWithValue("@Password", User.Password);

                int count = (int)command.ExecuteScalar();

                connection.Close();
                return count>0;
            }
        }
        public void Register() 
        {
            int val = 10;
             connection.Open();
            Query = "Insert into Tbl_User(User_Name,User_Surname,User_Pass,User_NickName,AmountFood,AmountItem,AmountMoney,GameStartDate) values(@name,@surname,@pass,@nickname,@food,@item,@money,@startdate)";
            SqlCommand addData = new SqlCommand(Query, connection);
            addData.Parameters.AddWithValue("@name", User.UserName);
            addData.Parameters.AddWithValue("@surname", User.UserSurname);
            addData.Parameters.AddWithValue("@pass", User.Password);
            addData.Parameters.AddWithValue("@nickname", User.UserNickname);
            addData.Parameters.AddWithValue("@food", 10);
            addData.Parameters.AddWithValue("@startdate", User.StartDate);
            addData.Parameters.AddWithValue("@money", 10);
            addData.Parameters.AddWithValue("@item", 10);
            addData.ExecuteNonQuery();
            connection.Close();
        }
        public void PullAmountData() 
        {
            connection.Open();
            Query = "Select AmountFood, AmountItem, AmountMoney from Tbl_User where User_NickName=@Username and User_Pass=@pass";
            SqlCommand pulldata = new SqlCommand(Query,connection);
            pulldata.Parameters.AddWithValue("@Username",User.UserNickname);
            pulldata.Parameters.AddWithValue("@pass",User.Password);
            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                Amount.AmountFood = Convert.ToInt32(reader["AmountFood"]);
                Amount.AmountMoney = Convert.ToInt32(reader["AmountMoney"]);
                Amount.AmountItem = Convert.ToInt32(reader["AmountItem"]);
            }
        }
    }
}
