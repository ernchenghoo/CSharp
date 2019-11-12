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
    }

   public class FormManager
    {
        public static HomepageForm HomePage
        {
            get
            {
                if (ShowHomePage == null)
                {
                    ShowHomePage = new HomepageForm();
                }
                return ShowHomePage;
            }
        }
        private static HomepageForm ShowHomePage;
    }

    class Fromm : Form
    {
        public Fromm()
        {
            new FoodStockForm().Show();
        }

    }
}
