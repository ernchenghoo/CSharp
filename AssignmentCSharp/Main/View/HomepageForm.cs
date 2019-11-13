using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Main.Controller;


namespace AssignmentCSharp.Main.View
{
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
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
                int failLogin = HomepageController.Login(emailBox.Text, passwordBox.Text);
                switch (failLogin)
                {
                    case 0:
                        MessageBox.Show("Account does not exist.");                        
                        break;
                    case 1:
                        MessageBox.Show("Invalid Password.");                        
                        break;                        
                    case 2:
                        this.Hide();
                        break;

                }                
            }
            loginAttemps += 1;
            if (loginAttemps >= 5)
            {
                MessageBox.Show("You have attempted 5 failed logins. The system will be closed due to security purposes.");
                Application.Exit();
            }
        }
        
    }
}
