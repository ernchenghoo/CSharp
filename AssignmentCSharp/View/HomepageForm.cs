using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Controller;
using AssignmentCSharp.Model;

namespace AssignmentCSharp.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
        }       

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
                int loginStatus = HomepageController.Login(emailBox.Text, passwordBox.Text);
                switch (loginStatus)
                {
                    //login status = 10 : account does not exist
                    //login status = 11 : email exist, but password wrong
                    //login status = 1 : admin login
                    //login status = 2 : stockkeeper login
                    //login status = 3 : kitchen login
                    //login status = 4 : cashier login
                    //login status = 5 : supplier login
                    case 10:
                        MessageBox.Show("Account does not exist!");
                        break;
                    case 11:
                        MessageBox.Show("Account exist, but invalid password");
                        break;
                    case 1:
                        MessageBox.Show("Admin login");
                        break;
                    case 2:
                        MessageBox.Show("Stockkeeper login");
                        break;
                    case 3:
                        MessageBox.Show("Kitchen login");
                        break;
                    case 4:
                        Program.LoadCashier();
                        break;
                    case 5:
                        MessageBox.Show("Supplier login");
                        break;
                }

            }            
        }
    }

}
