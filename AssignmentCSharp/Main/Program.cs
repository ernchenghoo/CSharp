using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp;
using AssignmentCSharp.Main.View;
using AssignmentCSharp.Main.Model;

namespace AssignmentCSharp.Main
{
    static class Program
    {
        public static HomepageForm homePageFormReference = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homePageFormReference = new HomepageForm();
            Application.Run(FormManager.HomePage);

     
        }

        
        public static class LoggedinAccount
        {
            public static Account account;
        }

        public static void LoadCashier ()
        {
            //if loggedinaccount is admin show back button
            if(LoggedinAccount.account.Type.ID == 1)
            {
                new POSpageForm(true).Show();
            }
            else
            {
                new POSpageForm(false).Show();
            }
            
        }

        public static void LoadStocks()
        {
            //if loggedinaccount is admin show back button
            if (LoggedinAccount.account.Type.ID == 1)
            {
                new FoodStockForm(true).Show();
            }
            else
            {
                new FoodStockForm(false).Show();
            }
        }

        public static void LoadRegister()
        {
            new RegisterForm().Show();
        }

        public static void LoadAccounts()
        {
            new ManageAccountsForm().Show();
        }

        public static void LoadKitchen()
        {
            //if loggedinaccount is admin show back button
            if (LoggedinAccount.account.Type.ID == 1)
            {
                new KitchenForm(true).Show();
            }
            else
            {
                new KitchenForm(false).Show();
            }
        }

        public static void LoadAdmin ()
        {
            new AdminForm().Show();
        }
        public static void LoadEditAccount(Account acc)
        {
            EditAccountForm editForm = new EditAccountForm (acc);
            editForm.ShowDialog();
        }

        public static void LoadSalesReport()
        {
            new DailySalesForm().Show();
        }

        public static void LoadSalesReportDetails(Receipt selectedSale)
        {
            new SalesDetailsPopupForm(selectedSale).Show();
        }
    }

   public class FormManager
    {
        public static HomepageForm HomePage
        {
            get
            {
                if (homePage == null)
                {
                    homePage = new HomepageForm();
                }
                return homePage;
            }
        }
        private static HomepageForm homePage;
    }    

}
