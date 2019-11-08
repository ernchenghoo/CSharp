using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp;
using AssignmentCSharp.View;

namespace AssignmentCSharp.Model
{
    static class Program
    {
        public static Form1 homePageFormReference = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homePageFormReference = new Form1();
            Application.Run(new Fromm());

     
        }
    }

    class Fromm : Form
    {
        public Fromm()
        {
            new FoodStockForm().Show();
        }
    }
}
