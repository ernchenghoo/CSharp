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
        public static int Login(string email, string password)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            int loginInfo = 10;
            try
            {
                cnn.Open();
                Account loginAccount = null;
                String sql = "select * from account where email = '" + email + "'";
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
                    //login info = 10 : account does not exist
                    //login info = 11 : email exist, but password wrong
                    //login info = 1 : admin login
                    //login info = 2 : stockkeeper login
                    //login info = 3 : kitchen login
                    //login info = 4 : cashier login
                    //login info = 5 : supplier login

                    if (string.Equals(loginAccount.Email, email))
                    {
                        loginInfo = 11;
                    }

                    if (string.Equals(loginAccount.Email, email) &&
                        string.Equals(loginAccount.Password,password))
                    {
                        switch (loginAccount.AccountID)
                        {
                            case 1:
                                loginInfo = 1;
                                break;
                            case 2:
                                loginInfo = 2;
                                break;
                            case 3:
                                loginInfo = 3;
                                break;
                            case 4:
                                loginInfo = 4;
                                break;
                            case 5:
                                loginInfo = 5;
                                break;

                        }
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
