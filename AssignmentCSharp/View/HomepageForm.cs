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
            if (String.IsNullOrEmpty(usernameBox.Text) && String.IsNullOrEmpty(passwordBox.Text))
                MessageBox.Show("Login fields are empty.");
            else if (String.IsNullOrEmpty(usernameBox.Text))
                MessageBox.Show("Username field is empty.");
            else if (String.IsNullOrEmpty(passwordBox.Text))
                MessageBox.Show("Password field is empty");
            else
            {
                int loginStatus = HomepageController.Login(usernameBox.Text, passwordBox.Text);
                switch (loginStatus)
                {
                    case 0:
                        MessageBox.Show("Account does not exist!");
                        break;
                    case 1:
                        MessageBox.Show("Account exist, but invalid password");
                        break;
                    case 2:
                        MessageBox.Show("Login successful");
                        break;
                }

            }            
        }

        
    }

}
