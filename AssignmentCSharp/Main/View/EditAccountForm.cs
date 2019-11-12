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

namespace AssignmentCSharp.Main.View
{
    public partial class EditAccountForm : Form
    {
        public EditAccountForm()
        {
            InitializeComponent();            
        }      

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.Equals(passwordBox.Text, Program.LoggedinAccount.password)) {
                MessageBox.Show("Please enter a new password!");
            }
            else if (ManageAccountController.EditCredentials(Program.LoggedinAccount.email, 
                passwordBox.Text, Program.LoggedinAccount.role)) //edit successful
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
