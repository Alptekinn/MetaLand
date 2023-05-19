using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MetaLand.Repository
{
    public class Database
    {

        public static string connectionString = "Data Source=.;Initial Catalog=MetaLand;Integrated Security=True";
        public static string Query { get; set; }
        static SqlConnection connection = new SqlConnection(connectionString);

        public int Login()
        {
            connection.Open();
            int isLogin;
            Query = "SELECT UserType,AmountFood, AmountItem, AmountMoney FROM Kullanicilar WHERE User_NickName = @Username AND User_Pass = @Password";
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.AddWithValue("@Username", User.UserNickname);
                command.Parameters.AddWithValue("@Password", User.Password);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int userType = Convert.ToInt32(reader.GetBoolean(0));

                    isLogin = userType == 1 ? 1 : (userType == 0 ? 0 : 2);
                }
                else
                {
                    isLogin = 2;
                }
                reader.Close();
                connection.Close();
                return isLogin;
            }
        }
        public void Register(int type)
        {
            PullAmountData();
            connection.Open();
            Query = "Insert into Tbl_Users(User_Name,User_Surname,User_Pass,User_NickName,AmountFood,AmountItem,AmountMoney,GameStartDate,UserType) values(@name,@surname,@pass,@nickname,@food,@item,@money,@startdate,@usertype)";
            SqlCommand addData = new SqlCommand(Query, connection);
            addData.Parameters.AddWithValue("@name", User.UserName);
            addData.Parameters.AddWithValue("@surname", User.UserSurname);
            addData.Parameters.AddWithValue("@pass", User.Password);
            addData.Parameters.AddWithValue("@nickname", User.UserNickname);
            addData.Parameters.AddWithValue("@food", Amount.AmountFood);
            addData.Parameters.AddWithValue("@startdate", User.StartDate);
            addData.Parameters.AddWithValue("@money", Amount.AmountMoney);
            addData.Parameters.AddWithValue("@item", Amount.AmountItem);
            addData.Parameters.AddWithValue("@usertype", type);
            addData.ExecuteNonQuery();
            connection.Close();
        }
        public void PullAmountData()
        {
            connection.Open();
            Query = "Select AmountFood, AmountItem, AmountMoney from Amount";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                Amount.AmountFood = Convert.ToInt32(reader["AmountFood"]);
                Amount.AmountMoney = Convert.ToInt32(reader["AmountMoney"]);
                Amount.AmountItem = Convert.ToInt32(reader["AmountItem"]);
            }
            reader.Close();
            connection.Close();
        }
        public void PullGameAreaData()
        {
            connection.Open();
            Query = "Select AreaHeight, AreaWidth from OyunAlani";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                GameSetting.AreaHeight = Convert.ToInt32(reader["AreaHeight"]);
                GameSetting.AreaWidth = Convert.ToInt32(reader["AreaWidth"]);
            }
            reader.Close();
            connection.Close();
        }
        public List<string> PullAreaName()
        {
            List<string> buttonNames = new List<string>();

            connection.Open();
            Query = "Select AlanAd From Arsalar";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            while (reader.Read())
            {
                buttonNames.Add(reader["AlanAd"].ToString(), reader["AlanID"].ToString()); 
            }
            reader.Close();
            connection.Close();
            return buttonNames;
        }
        public void SetUserData(DataGridView data)
        {
            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    int userId = Convert.ToInt32(row.Cells[0].Value);
                    string name = row.Cells[1].Value.ToString();
                    string surname = row.Cells[2].Value.ToString();
                    string nickname = row.Cells[3].Value.ToString();
                    string pass = row.Cells[4].Value.ToString();
                    string food = row.Cells[5].Value.ToString();
                    string item = row.Cells[6].Value.ToString();
                    string money = row.Cells[7].Value.ToString();
                    DateTime startdate = Convert.ToDateTime(row.Cells[8].Value);
                    bool type = Convert.ToBoolean(row.Cells[9].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE Tbl_Users SET User_Name = @Username, User_NickName = @nickname, User_Pass = @pass, User_Surname = @surname,GameStartDate=@date,UserType=@usertype,AmountFood=@food WHERE User_ID = @UserId";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Username", name);
                            command.Parameters.AddWithValue("@surname", surname);
                            command.Parameters.AddWithValue("@nickname", nickname);
                            command.Parameters.AddWithValue("@pass", pass);
                            command.Parameters.AddWithValue("@usertype", type);
                            command.Parameters.AddWithValue("@food", food);
                            command.Parameters.AddWithValue("@item", item);
                            command.Parameters.AddWithValue("@money", money);
                            command.Parameters.AddWithValue("@date", startdate);
                            command.Parameters.AddWithValue("@UserId", userId);

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
            }

        }
        public void PullAreaName1()
        {

            int areaid = 0;
            connection.Open();
            Query = "Select AlanID, AlanAd, Owner From Arsalar";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            List<GameSetting> buttonList = new List<GameSetting>();
            GameSetting gameSetting = new GameSetting();
            while (reader.Read())
            {
                gameSetting.AreaId = Convert.ToInt32(reader["AlanID"]);
                gameSetting.Name = reader["AlanAd"].ToString();
                gameSetting.AreaOwnerId = Convert.ToInt32(reader["Owner"]);
                buttonList.Add(gameSetting);
                areaid++;
            }
            reader.Close();
            connection.Close();
        }
        public void UpdateAmount()
        {
            connection.Open();
            Query = "UPDATE Amount SET AmountFood=@food,AmountMoney=@money,AmountItem=@item";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@food", Amount.AmountFood);
            command.Parameters.AddWithValue("@money", Amount.AmountMoney);
            command.Parameters.AddWithValue("@item", Amount.AmountItem);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateAreaSize()
        {
            connection.Open();
            Query = "UPDATE GameArea SET AreaWidth=@width,AreaHeight=@height";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@width", GameSetting.AreaWidth);
            command.Parameters.AddWithValue("@height", GameSetting.AreaHeight);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void InsertData(DataTable table)
        {

            connection.Open();

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
            {
                bulkCopy.DestinationTableName = "Tbl_Users";
                bulkCopy.WriteToServer(table);
            }
            connection.Close();
        }

    }
}
