using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.Model
{
    public class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int AccountID { get; set; }
        public AccountType Type { get; set; }

        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";        

        public Account(string usnm, string pwd, int accID, int role) //overloaded constructor
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            Type = new AccountType(role, IDToRole(role));
        }

        public Account(string usnm, string pwd, int accID, string role) //overloaded constructor
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            Type = new AccountType(RoleToID(role), role);
        }

        private string IDToRole(int id)
        {
            string role = "";
            switch (id)
            {
                case 1:
                    role = "Admin";
                    break;
                case 2:
                    role = "Stock Keeper";
                    break;
                case 3:
                    role = "Kitchen Staff";
                    break;
                case 4:
                    role = "Cashier";
                    break;
                case 5:
                    role = "Supplier";
                    break;
            }
            return role;

        }

        private int RoleToID(string name)
        {
            int roleID = 0;
            switch (name)
            {
                case "Admin":
                    roleID = 1;
                    break;
                case "Stock Keeper":
                    roleID = 2;
                    break;
                case "Kitchen Staff":
                    roleID = 3;
                    break;
                case "Cashier":
                    roleID = 4;
                    break;
                case "Supplier":
                    roleID = 5;
                    break;
            }
            return roleID;

        }

        public static Account GetSupplierAcc()
        {
            cnn = new MySqlConnection(connectionString);
            Account supplierAcc = null;

            try
            {
                cnn.Open();

                MySqlCommand command = new MySqlCommand("select * from account where typeID = 5", cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    supplierAcc = new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3));
                }
                cnn.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed");
                Console.WriteLine(e.ToString());
            }
            return supplierAcc;
        }

        public void Save()
        {
            try
            {
                //update the record
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = cnn;
                command.CommandText = "UPDATE Account SET email=@email WHERE typeID =5";
                command.Parameters.AddWithValue("@email", Email);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed");
                MessageBox.Show(e.ToString());
            }
        }       
    }    
}
