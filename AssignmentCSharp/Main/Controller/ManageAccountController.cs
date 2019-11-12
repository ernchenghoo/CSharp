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
    class ManageAccountController
    {
        public static bool EditCredentials (string em, string newpw, int rl)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                Account loginAccount = null;
                String sql = "update account set password= '" + newpw + "', typeID='" + rl + "' where email= '" + em + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           


        }

        public static string IDToRole(int typID)
        {
            string typeName = "";
            switch (typID)
            {
                case 1:
                    typeName = "Admin";
                    break;
                case 2:
                    typeName = "Stock Keeper";
                    break;
                case 3:
                    typeName = "Kitchen Staff";
                    break;
                case 4:
                    typeName = "Cashier";
                    break;
            }
            return typeName;
        }
    }
}
