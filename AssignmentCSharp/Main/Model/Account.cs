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
        public int TypeID { get; set; }

        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        public Account(string usnm, string pwd, int accID, string role)
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            TypeID = RoleToID(role);
        }

        public Account(string usnm, string pwd, int accID, int role) //overloaded constructor
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            TypeID = role;
        }

        private int RoleToID(string accType)
        {
            int typeID = 0;
            switch (accType)
            {

                case "Stock Keeper":
                    typeID = 2;
                    break;
                case "Kitchen Staff":
                    typeID = 3;
                    break;
                case "Cashier":
                    typeID = 4;
                    break;
            }
            return typeID;
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
                    supplierAcc = new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetString(3));
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

        public string IDToRole()
        {
            string typeName = "";
            switch (TypeID)
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
