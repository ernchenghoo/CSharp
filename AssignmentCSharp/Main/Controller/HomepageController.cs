using System;
using MySql.Data.MySqlClient;
using AssignmentCSharp.Main.Model;

namespace AssignmentCSharp.Main.Controller
{
    class HomepageController
    {
        public static int Login(string email, string password)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            int loginFail = 0;
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
                    //login info = 0 : account does not exist
                    //login info = 1 : email exist, but password wrong
                    //login info = 2 : successful login   

                    if (string.Equals(loginAccount.Email, email))
                    {
                        loginFail = 1;
                    }

                    if (string.Equals(loginAccount.Email, email) &&
                        string.Equals(loginAccount.Password,password))
                    {
                        loginFail = 2;
                        switch (loginAccount.TypeID)
                        {
                            case 1:
                                Program.LoadAdmin();
                                break;
                            case 2:
                                Program.LoadStocks();
                                break;
                            case 3:
                                Program.LoadKitchen();
                                break;
                            case 4:
                                Program.LoadCashier();
                                break;
                            case 5:
                                //supplier
                                break;

                        }
                    }                    
                }                
            }
            catch
            {
                Console.WriteLine(System.Environment.StackTrace);
            }
            return loginFail;
        }
    }
}
