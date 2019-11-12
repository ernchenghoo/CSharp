using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp;
using AssignmentCSharp.Main.View;

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
            public static string email;
            public static string password;
            public static int role;
        }

        public static void LoadCashier ()
        {
            new POSpageForm().Show();
        }

        public static void LoadStocks()
        {
            new FoodStockForm().Show();
        }

        public static void LoadAccounts()
        {
            new RegisterForm().Show();
        }

        public static void LoadKitchen()
        {
            new KitchenForm().Show();
        }

        public static void LoadAdmin ()
        {
            new AdminForm().Show();
        }
        public static void LoadEditAccount()
        {
            new EditAccountForm().Show();
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

    class Fromm : Form
    {
        public Fromm()
        {
            new FoodStockForm().Show();
        }

    }
}
