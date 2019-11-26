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
    public partial class SalesDetailsPopupForm : Form
    {
        static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
        MySqlConnection cnn = new MySqlConnection(connectionString);
        Receipt selectedSale = null;
        List<Receipt_Food> saleFood = new List<Receipt_Food>();
        public SalesDetailsPopupForm(Receipt sale)
        {
            selectedSale = sale;
            InitializeComponent();
            GenerateList();
            GrandTotalLabel.Text += "   RM" + selectedSale.Total.ToString();
            ServiceChargeLabel.Text += " - RM" + selectedSale.ServiceTax.ToString();
            TaxLabel.Text += " - RM" + selectedSale.Tax.ToString();
            RevenueLabel.Text += "RM" + (selectedSale.Total - selectedSale.ServiceTax - selectedSale.Tax).ToString();
        }

        private void GenerateList()
        {
            SalesFoodList.Items.Clear();
            foreach (Receipt_Food food in DisplayFood())
            {
                string[] listRow = new string[] { food.FoodId.ToString(), food.FoodName.ToString(), food.FoodPrice.ToString(),
                food.QuantityOrdered.ToString(), (food.QuantityOrdered * food.FoodPrice).ToString()};
                ListViewItem lvi = new ListViewItem(listRow);
                lvi.Tag = food;
                SalesFoodList.Items.Add(lvi);
            }
        }

        private List<Receipt_Food> DisplayFood()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                String sql = "SELECT * FROM receipt_food where receiptid =  '" + selectedSale.Id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);


                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    saleFood.Add(new Receipt_Food(dataReader.GetInt32(0), dataReader.GetInt32(1),
                        dataReader.GetString(2), dataReader.GetDecimal(3), dataReader.GetInt32(4), dataReader.GetBoolean(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
            return saleFood;
        }        
    }
}
