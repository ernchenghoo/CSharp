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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
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
                int registerStatus = RegisterController.Register(emailBox.Text, passwordBox.Text, reenterBox.Text, roleBox.SelectedItem.ToString());
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
    }
}
