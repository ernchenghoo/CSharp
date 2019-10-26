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

namespace AssignmentCSharp
{
    
    public partial class POSpageForm : Form
    {
        public POSpageForm()
        {
            InitializeComponent();
            searchAndUpdateList("");
        }

        //function to search and update the food menu
        public void searchAndUpdateList(String search)
        {
            this.foodListContainer.Controls.Clear();
            foreach (var food in FoodStock.getFoodStocks())
            {
                if (food.name.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();

                    newButton.BackColor = System.Drawing.Color.White;
                    newButton.FlatAppearance.BorderSize = 2;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.Location = new System.Drawing.Point(10, 10);
                    newButton.Margin = new System.Windows.Forms.Padding(10);
                    newButton.Name = "button1";
                    newButton.Size = new System.Drawing.Size(199, 191);
                    newButton.TabIndex = 7;
                    newButton.Text = food.name;
                    newButton.Tag = food;
                    newButton.UseVisualStyleBackColor = false;
                    newButton.Click += new System.EventHandler(this.addItem);

                    this.foodListContainer.Controls.Add(newButton);
                }   
            }
        }

        //function to add the item to the cart
        private void addItem(object sender, EventArgs e)
        {
            System.Windows.Forms.Button buttonObject = (System.Windows.Forms.Button)sender;
            FoodStock chosenFood = (FoodStock)buttonObject.Tag;

            DataGridViewRow foundItemInCart = null;
            foreach (DataGridViewRow row in this.itemListInCart.Rows)
            {
                int currentRowID = (int)row.Cells[1].Value;
                if (currentRowID == chosenFood.id)
                {
                    foundItemInCart = row;
                }
            }

            if (foundItemInCart == null)
            {
                int newNo = this.itemListInCart.Rows.Count + 1;
                this.itemListInCart.Rows.Add(newNo, chosenFood.id, chosenFood.name, 1, chosenFood.price, chosenFood.price * 1);
            }
            else
            {
                addQuantityToRow(foundItemInCart);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.foodListContainer.Controls.Clear();
            searchAndUpdateList(searchBar.Text);
        }

        

        public void addQuantityToRow(DataGridViewRow row)
        {
            
            int itemId = (int)row.Cells[1].Value;
            int currentNumberOfItem = (int)row.Cells[3].Value;

            FoodStock itemObject = null;
            foreach (var food in FoodStock.getFoodStocks())
            {
                if(food.id == itemId)
                {
                    itemObject = food;
                }
            }

            int newQuantity = currentNumberOfItem+1;
            //add quantity
            row.Cells[3].Value = newQuantity;
            row.Cells[4].Value = itemObject.price;
            row.Cells[5].Value = newQuantity * itemObject.price;
        }

        private void XQtyButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            searchAndUpdateList("");
        }
    }
}
