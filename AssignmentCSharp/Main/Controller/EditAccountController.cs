using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AssignmentCSharp.Main.Model;

namespace AssignmentCSharp.Main.Controller
{
    class EditAccountController
    {
        public static bool EditCredentials (string em, string newpw, int rl)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();                
                String sql = "update account set password= '" + newpw + "', typeID='" + rl + "' where email= '" + em + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                return true;
            }
            catch
            {                
                return false;
            }
           


        }        
    }
}
