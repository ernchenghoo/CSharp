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
using AssignmentCSharp.Model;

namespace AssignmentCSharp.View
{
    public partial class FoodStockForm : Form
    {
        public FoodStockForm()
        {
            InitializeComponent();
            getAllRecord();
        }

        private void FoodStock_Load(object sender, EventArgs e)
        {

        }

        private void getAllRecord()
        {
            this.dataFoodStock.Rows.Clear();
            foreach (Model.FoodStock food in Model.FoodStock.getFoodStocks())
            {
                this.dataFoodStock.Rows.Add(food.Id, food.Name, food.Quantity, food.Price);
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            string userinput = ShowInputDialog("Enter item name :","Enter quantity : (enter more than 15)","Enter price :", "Add new item Box",-1);
        }

        public string ShowInputDialog(string itemname,string quantity,string price, string caption,int getId)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 300,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label itemNameLabel = new Label() { Left = 20, Top = 10, Text = itemname };
            TextBox itemNameTextBox = new TextBox() { Left = 20, Top = 40, Width = 200 };
            Label quantityLabel = new Label() { Left = 20, Top = 80, Text = quantity, Width = 300 };
            TextBox quantityTextBox = new TextBox() { Left = 20, Top = 110, Width = 200 };
            Label priceLabel = new Label() { Left = 20, Top = 150, Text = price };
            TextBox priceTextBox = new TextBox() { Left = 20, Top = 180, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 70, Top = 220 };
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 70, Top = 220 };

            if(getId != -1)
            {
                FoodStock foodId = FoodStock.findById(getId);
                itemNameTextBox.Text = foodId.Name;
                quantityTextBox.Text = foodId.Quantity.ToString();
                priceTextBox.Text = foodId.Price.ToString();


            }
            //button click event handler
            confirmation.Click += (sender, e) => {
                try
                {
                    string inputItemName = itemNameTextBox.Text;
                    int inputQuantity = Convert.ToInt32(quantityTextBox.Text);
                    decimal inputPrice = Convert.ToDecimal(priceTextBox.Text);
                    string errorMessages = "";

                    if (inputQuantity < 0)
                    {
                        errorMessages += "Please enter positive integer for Quantity\n";
                    }

                    if (inputPrice < 0)
                    {
                        errorMessages += "Please enter positive integer for Price\n";
                    }

                    if(errorMessages != "")
                    {
                        MessageBox.Show(errorMessages);
                    }
                    else
                    {
                        prompt.DialogResult = DialogResult.OK;
                        if (getId == -1)
                        {
                            FoodStock newItem = new FoodStock(inputItemName, inputQuantity, inputPrice);
                            newItem.save();
                            getAllRecord();
                        }
                        else
                        {
                            FoodStock foodId = FoodStock.findById(getId);
                            foodId.Name = inputItemName;
                            foodId.Quantity = inputQuantity;
                            foodId.Price = inputPrice;                        
                            foodId.save();
                            getAllRecord();
                        }
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Please Enter only Integer!");
                }
            };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(itemNameTextBox);
            prompt.Controls.Add(quantityTextBox);
            prompt.Controls.Add(priceTextBox);
            prompt.Controls.Add(itemNameLabel);
            prompt.Controls.Add(quantityLabel);
            prompt.Controls.Add(priceLabel);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);            
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? itemNameTextBox.Text : "";
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (this.dataFoodStock.SelectedRows.Count > 0)
            {
                // have row selected
                int itemId = (int)dataFoodStock.SelectedRows[0].Cells[0].Value;
                string userinput = ShowInputDialog("Enter item name :", "Enter quantity :", "Enter price :", "Add new item Box", itemId);

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (this.dataFoodStock.SelectedRows.Count > 0)
            {
                // have row selected
                int itemId = (int)dataFoodStock.SelectedRows[0].Cells[0].Value;
                FoodStock foodId = FoodStock.findById(itemId);
                foodId.delete();
                getAllRecord();

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
