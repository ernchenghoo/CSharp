using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void LoginButton_click(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                List <string> output = new List <string>();
                String sql = "select username from account where username = '" + usernameBox.Text + "'";
                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output.Add(dataReader.GetString(0));
                }
                cnn.Close();
                foreach (var x in output) //maybe dont use array for this
                {
                   if (string.Equals(x, usernameBox.Text))
                    {
                        MessageBox.Show("Login Successful!");
                    }                   
                }
                if (!output.Any())
                {
                    MessageBox.Show("Account does not exist!");
                }
            }
            catch
            {
                MessageBox.Show ("Connection failed");
            }
        }
    }
}
