using System;
using System.Windows.Forms;
using AssignmentCSharp.Main.Model;
using MySql.Data.MySqlClient;


namespace AssignmentCSharp.Main.View
{
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            this.AcceptButton = LoginButton;
        }

        int loginAttemps = 0;

        private void LoginButton_click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailBox.Text) && String.IsNullOrEmpty(passwordBox.Text))
                MessageBox.Show("Login fields are empty.");
            else if (String.IsNullOrEmpty(emailBox.Text))
                MessageBox.Show("Username field is empty.");
            else if (String.IsNullOrEmpty(passwordBox.Text))
                MessageBox.Show("Password field is empty");
            else
            {
                loginAttemps += 1;
                int failLogin = Login(emailBox.Text, passwordBox.Text);
                switch (failLogin)
                {
                    case 0:
                        MessageBox.Show("Account does not exist.");                        
                        break;
                    case 1:
                        MessageBox.Show("Invalid Password.");                        
                        break;                        
                    case 2: //login successful
                        this.Hide();
                        loginAttemps = 0;
                        break;

                }                
            }            
            if (loginAttemps >= 5)
            {
                MessageBox.Show("You have attempted 5 failed logins. The system will be closed due to security purposes.");
                Application.Exit();
            }
        }

        private int Login(string email, string password)
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
                        string.Equals(loginAccount.Password, password))
                    {
                        loginFail = 2;
                        Program.LoggedinAccount.account = loginAccount;

                        switch (loginAccount.Type.ID)
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

        public void clearAllTextBox()
        {
            emailBox.Text = "";
            passwordBox.Text = "";
        }        
    }
}
