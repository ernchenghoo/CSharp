using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCSharp.Main.View
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CashierButton_Click(object sender, EventArgs e)
        {
            Program.LoadCashier();
            this.Close();
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {
            Program.LoadStocks();
            this.Close();
        }

        private void KitchenButton_Click(object sender, EventArgs e)
        {
            Program.LoadKitchen();
            this.Close();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Program.LoadAccounts();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        { 
            this.Close();
            FormManager.HomePage.Show();            
        }

        private void EditAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadEditAccount(Program.LoggedinAccount.account);
            this.Close();
        }        
    }
}
