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
    public partial class ManageAccountsForm : Form
    {
        public ManageAccountsForm()
        {
            InitializeComponent();
            RefreshListView();
        }

        private void RefreshListView ()
        {
            accountList.Items.Clear();
            foreach (Account acc in DisplayAccounts())
            {
                string[] listRow = new string[] { acc.Email, acc.Type.Name };
                ListViewItem lvi = new ListViewItem(listRow);
                lvi.Tag = acc;
                accountList.Items.Add(lvi);
            }
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            Program.LoadRegister();
            this.Close();
        }

        private void AccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (accountList.SelectedItems.Count > 0)
                {
                    var selectedAccount = (Account)accountList.SelectedItems[0].Tag;
                    if (selectedAccount.Type.ID != 1)
                        editButton.Enabled = true;
                    else
                    {
                        editButton.Enabled = false;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }       

        private void EditButton_Click(object sender, EventArgs e)
        {
            Program.LoadEditAccount((Account)accountList.SelectedItems[0].Tag);
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedItems.Count > 0)
            {
                var confirm = MessageBox.Show("Are you sure to delete this item ??", "Delete confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string deleteResult = DeleteAccount((Account)accountList.SelectedItems[0].Tag);
                    if (!string.Equals("ok", deleteResult))
                    {
                        MessageBox.Show(deleteResult);
                    }
                    else
                    {
                        RefreshListView();
                    }
                }
            }
            else
            {
                MessageBox.Show("No item selected");
            }
                    
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.LoadAdmin();
            this.Close();
        }

        private List<Account> DisplayAccounts()
        {
            List<Account> accountsInDB = new List<Account>();

            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();

                String sql = "select * from account";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    accountsInDB.Add(new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2),
                        dataReader.GetInt32(3)));
                }

            }
            catch
            {

            }
            return accountsInDB;
        }        
        public static string DeleteAccount(Account acc)
        {
            try
            {
                MySqlConnection cnn;
                string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();

                String sql = "delete from account where accountID = '" + acc.AccountID + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
