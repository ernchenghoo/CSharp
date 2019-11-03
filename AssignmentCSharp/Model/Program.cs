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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

     
        }
    }

    public class mainForm : Form
    {
        public mainForm()
        {
            new FoodStockForm().Show();
        }
    }
}
