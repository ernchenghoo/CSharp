using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AssignmentCSharp.Main.Model;


namespace AssignmentCSharp.Main.Controller
{
    class ManageAccountController
    {
        public static List<Account> DisplayAccounts ()
        {
            List<Account> accountsInDB = new List<Account>();
            
            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                
                String sql = "select * from account";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    accountsInDB.Add(new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2),
                        dataReader.GetInt32(3)));
                }
                
            }
            catch
            {
                
            }
            return accountsInDB;
        }

        public static string DeleteAccount(Account acc)
        {
            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();

                String sql = "delete from account where accountID = '" + acc.AccountID + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
            
    }
}
