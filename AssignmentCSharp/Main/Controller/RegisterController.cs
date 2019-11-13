using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AssignmentCSharp.Main.Model;
using System.Windows.Forms;

namespace AssignmentCSharp.Main.Controller
{
    class RegisterController
    {
        private static int GenerateID()
        {
            int ID = 0;
            try
            {
                
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();

                
                String sql = "SELECT MAX(accountID) AS 'Largest ID' from account";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ID = dataReader.GetInt32(0) + 1;
                }
                cnn.Close();                
            }
            catch
            {
                
            }
            return ID;
        }

        private static bool CheckAccountExistence(string em)
        {
            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                String sql = "select * from account where email = '" + em + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    cnn.Close();
                    return true;                    
                }
                cnn.Close();

            }
            catch
            {
                Console.WriteLine(System.Environment.StackTrace);
            }
            return false;
        }

        public static bool addAccountToDB (Account acc)
        {
            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                string query =
                    "insert into account values('" + acc.Email + "', '" + acc.Password + "', '" + acc.AccountID + "', '" + acc.TypeID + "'); ";
                MySqlCommand command = new MySqlCommand(query, cnn);                
                cnn.Open();
                MySqlDataReader dataReader = command.ExecuteReader();                
                cnn.Close();
                return true;
                
            }
            catch
            {                
                return false;
            }            
        }
        
        public static int Register (string email, string pw, string repw, string role)
        {
            int registerStatus = 0;

            if (!string.Equals(pw, repw)) //check if password and re-entered password is same
            {
                registerStatus = 1;
            }            
            if (CheckAccountExistence(email)) //if account already exist
            {
                registerStatus = 2;
            }
            if (registerStatus == 0)
            {
                Account registerAccount = new Account(email, pw, GenerateID(), role);
                if (!addAccountToDB(registerAccount))
                {
                    registerStatus = 3;
                }
            }

            return registerStatus;           
        }       
    }
}
