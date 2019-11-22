using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Main.Model;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.View
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            reenterBox.PasswordChar = '*';
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {            
            if (String.IsNullOrEmpty(emailBox.Text) || String.IsNullOrEmpty(passwordBox.Text))
                MessageBox.Show("Please fill in all empty fields.");
            else if (String.IsNullOrEmpty(reenterBox.Text) || String.IsNullOrEmpty(roleBox.Text))
                MessageBox.Show("Please fill in all empty fields.");
            else
            {
                int registerStatus = Register(emailBox.Text, passwordBox.Text, reenterBox.Text, roleBox.SelectedItem.ToString());
                // registerStatus = 0: Create account
                // registerStatus = 1: Password and re-typed password not identical
                // registerStatus = 2: Email address already exist
                switch (registerStatus)
                {
                    case 0:
                        MessageBox.Show("Account registered!");
                        Program.LoadAccounts();
                        this.Close();
                        break;
                    case 1:
                        MessageBox.Show("Re-typed password and password is not identical.");
                        break;
                    case 2:
                        MessageBox.Show("There is already an account associated with this e-mail address.");
                        break;
                    case 3:
                        MessageBox.Show("Unable to add account into database.");
                        break;
                }
            }           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.LoadAccounts();
            this.Close();
        }

        private int Register(string email, string pw, string repw, string role)
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

        private bool CheckAccountExistence(string em)
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

        private int GenerateID()
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

        private bool addAccountToDB(Account acc)
        {
            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                string query =
                    "insert into account values('" + acc.Email + "', '" + acc.Password + "', '" + acc.AccountID + "', '" + acc.Type.ID + "'); ";
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

    }
}
