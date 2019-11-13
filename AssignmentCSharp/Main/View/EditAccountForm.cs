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
using AssignmentCSharp.Main;
using AssignmentCSharp.Main.Model;

namespace AssignmentCSharp.Main.View
{
    public partial class EditAccountForm : Form
    {
        Account accountToEdit;
        public EditAccountForm (Account acc)
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            accountToEdit = acc;
            emailLabel.Text = accountToEdit.Email;
            roleBox.Text = accountToEdit.IDToRole();
            if (accountToEdit.TypeID != 1)
            {
                roleBox.Enabled = true;
            }
            else
            {
                roleBox.Enabled = false;
            }            
        }      

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.Equals(passwordBox.Text, accountToEdit.Password)) {
                MessageBox.Show("This password is the same as the old one, please enter a new password.");
            }
            else if (!string.Equals(retypeBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Re-typed password and password is not identical.");
            }
            else if (EditAccountController.EditCredentials(accountToEdit.Email, 
                passwordBox.Text, accountToEdit.TypeID)) //edit successful
            {
                MessageBox.Show("Account details has been edited!");
                Program.LoadAdmin();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account credentials edit error!");
                
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.LoadAdmin();
            this.Close();
        }       
    }
}
