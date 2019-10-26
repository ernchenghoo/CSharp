using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AssignmentCSharp.View;

namespace AssignmentCSharp.Controller
{
    class HomepageController
    {
        public static int Login(string username, string password)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            int loginInfo = 0;
            try
            {
                cnn.Open();
                Account loginAccount = null;
                String sql = "select * from account where username = '" + username + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    loginAccount = new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2),
                        dataReader.GetInt32(3));
                }
                cnn.Close();
                
                if (loginAccount != null)
                {
                    //login info = 0 : account does not exist
                    //login info = 1 : username exist, but password wrong
                    //login info = 2 : login successful                    

                    if (string.Equals(loginAccount.Username, username))
                    {
                        loginInfo = 1;
                    }

                    if (string.Equals(loginAccount.Username, username) &&
                        string.Equals(loginAccount.Password,password))
                    {
                        loginInfo = 2;
                    }                    
                }                
            }
            catch
            {
                Console.WriteLine(System.Environment.StackTrace);
            }
            return loginInfo;
        }
    }
}
