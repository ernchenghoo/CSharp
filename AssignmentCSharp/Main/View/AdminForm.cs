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
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {
            Program.LoadStocks();
        }

        private void KitchenButton_Click(object sender, EventArgs e)
        {
            Program.LoadKitchen();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Program.LoadAccounts();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        { 
            this.Close();
            FormManager.HomePage.Show();            
        }

        private void EditAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadEditAccount();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FormManager.HomePage.Show();
        }
    }
}
