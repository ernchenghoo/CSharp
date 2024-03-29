﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Main.Model;
using AssignmentCSharp.Main.View;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.View
{
    public partial class EditAccountForm : Form
    {
        Account accountToEdit;
        public EditAccountForm (Account acc)
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            retypeBox.PasswordChar = '*';
            accountToEdit = acc;
            emailLabel.Text = accountToEdit.Email;
            roleBox.Text = accountToEdit.Type.Name;
            if (accountToEdit.Type.ID != 1)
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
            if (String.IsNullOrEmpty(passwordBox.Text) || String.IsNullOrEmpty(retypeBox.Text))
            {
                MessageBox.Show("Password and/or Re-enter password field(s) cannot be empty.");
            }
            else if (string.Equals(passwordBox.Text, accountToEdit.Password)) {
                MessageBox.Show("This password is the same as the old one, please enter a new password.");
            }
            else if (!string.Equals(retypeBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Re-typed password and password is not identical.");
            }
            else if (EditCredentials(accountToEdit.Email, 
                passwordBox.Text, accountToEdit.Type.ID)) //edit successful
            {
                MessageBox.Show("Account details has been edited!");
                Program.LoggedinAccount.account.Password = passwordBox.Text;
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

        public bool EditCredentials(string em, string newpw, int rl)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                String sql = "update account set password= '" + newpw + "', typeID='" + rl + "' where email= '" + em + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
