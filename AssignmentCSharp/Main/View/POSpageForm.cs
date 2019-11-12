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
using AssignmentCSharp.Main.Model;


namespace AssignmentCSharp.Main.View
{
    
    public partial class POSpageForm : Form
    {
        private String categoryChosen = null;
        public POSpageForm()
        {
            InitializeComponent();
            searchAndUpdateList("");

            //add value to comboBox
            this.orderType.Items.Insert(0, "Dine-In");
            this.orderType.Items.Insert(1, "Take Away");
            this.orderType.SelectedIndex = 0;
            displayListOfCategories();
        }

        private void displayListOfCategories()
        {
            this.categoryContainer.Controls.Clear();

            //Create All Button
            System.Windows.Forms.Button allButton = new System.Windows.Forms.Button();

            allButton.FlatAppearance.BorderSize = 1;
            allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            allButton.Location = new System.Drawing.Point(10, 10);
            allButton.Margin = new System.Windows.Forms.Padding(5);
            allButton.Name = "button1";
            allButton.Size = new System.Drawing.Size(140, 23);
            allButton.TabIndex = 7;
            allButton.Text = "All";
            allButton.Tag = (String)null;
            allButton.UseVisualStyleBackColor = false;
            allButton.BackColor = System.Drawing.Color.Green;
            allButton.Click += new System.EventHandler(this.chooseCategory);

            this.categoryContainer.Controls.Add(allButton);
            this.categoryChosen = null;

            foreach (Model.FoodCategory category in Model.FoodCategory.getFoodCategory())
            {
                
                System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();

                newButton.FlatAppearance.BorderSize = 1;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.Location = new System.Drawing.Point(10, 10);
                newButton.Margin = new System.Windows.Forms.Padding(5);
                newButton.Name = "button1";
                newButton.Size = new System.Drawing.Size(140, 23);
                newButton.TabIndex = 7;
                newButton.Text = category.Category;
                newButton.Tag = category.Category;
                newButton.UseVisualStyleBackColor = false;
                newButton.BackColor = System.Drawing.Color.Yellow;
                newButton.Click += new System.EventHandler(this.chooseCategory);
          
                this.categoryContainer.Controls.Add(newButton);    
            }
        }

        private void chooseCategory(object sender, EventArgs e)
        {
            foreach (Button b in this.categoryContainer.Controls)
            {
                b.BackColor = System.Drawing.Color.Yellow;
            }

            System.Windows.Forms.Button buttonObject = (System.Windows.Forms.Button)sender;
            //save it to class variable so we can reference it later
            this.categoryChosen = (String)buttonObject.Tag;
            buttonObject.BackColor = System.Drawing.Color.Green;

            searchAndUpdateList(this.searchBar.Text);
        }

        //function to search and update the food menu
        private void searchAndUpdateList(String search)
        {
            this.foodListContainer.Controls.Clear();

            //filter food name
            var filteredList = from food in Model.FoodStock.getFoodStocks()
                              where food.Name.ToLower().Contains(search.ToLower())
                              select food;
            //if category all is not chosen
            if (this.categoryChosen != null)
            {
                //filter category
                filteredList = from food in filteredList
                               where food.Category.Equals(this.categoryChosen)
                               select food;
            }


            foreach (Model.FoodStock food in filteredList)
            {
               
                System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();

                    
                newButton.FlatAppearance.BorderSize = 2;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.Location = new System.Drawing.Point(10, 10);
                newButton.Margin = new System.Windows.Forms.Padding(10);
                newButton.Name = "button1";
                newButton.Size = new System.Drawing.Size(199, 191);
                newButton.TabIndex = 7;
                newButton.Text = food.Name;
                newButton.Tag = food;
                newButton.UseVisualStyleBackColor = false;

                //if the item is no stock the color will be red
                if (food.Quantity > 0)
                {
                    newButton.BackColor = System.Drawing.Color.White;
                    newButton.Click += new System.EventHandler(this.addItem);
                }
                else
                {
                    newButton.BackColor = System.Drawing.Color.Red;
                    newButton.Click += (sender, e) => {
                        MessageBox.Show("This Item is Out of Stock!");
                    };
                }
                    

                this.foodListContainer.Controls.Add(newButton);
                 
            }
        }

        //function to add the item to the cart
        private void addItem(object sender, EventArgs e)
        {
            System.Windows.Forms.Button buttonObject = (System.Windows.Forms.Button)sender;
            Model.FoodStock chosenFood = (Model.FoodStock)buttonObject.Tag;

            DataGridViewRow foundItemInCart = null;
            foreach (DataGridViewRow row in this.itemListInCart.Rows)
            {
                int currentRowID = (int)row.Cells[1].Value;
                if (currentRowID == chosenFood.Id)
                {
                    foundItemInCart = row;
                }
            }

            if (foundItemInCart == null)
            {
                int newNo = this.itemListInCart.Rows.Count + 1;
                this.itemListInCart.Rows.Add(newNo, chosenFood.Id, chosenFood.Name, 1, chosenFood.Price, chosenFood.Price * 1);
            }
            else
            {
                //if enough quantity then show sucessfully added
                int currentNumberOfItem = (int)foundItemInCart.Cells[3].Value;
                if (FoodStock.findById((int)foundItemInCart.Cells[1].Value).Quantity > currentNumberOfItem+1)
                {
                    MessageBox.Show("Item Already in Cart! Added 1 quantity for you");
                }
                
                addQuantityToRow(foundItemInCart);
            }
            updateTotalCalculation();
        }

        private void addQuantityToRow(DataGridViewRow row)
        {

            int itemId = (int)row.Cells[1].Value;
            int currentNumberOfItem = (int)row.Cells[3].Value;

            Model.FoodStock itemObject = Model.FoodStock.findById(itemId);

            int newQuantity = currentNumberOfItem + 1;
            if(itemObject.Quantity >= newQuantity)
            {
                //add quantity, update price, update total price
                row.Cells[3].Value = newQuantity;
                row.Cells[4].Value = itemObject.Price;
                row.Cells[5].Value = newQuantity * itemObject.Price;
                updateTotalCalculation();
            }
            else
            {
                MessageBox.Show(String.Format("You have only {0} stock for {1}!",itemObject.Quantity,itemObject.Name));
            }
            
        }

        private void minusQuantityToRow(DataGridViewRow row)
        {

            int itemId = (int)row.Cells[1].Value;
            int currentNumberOfItem = (int)row.Cells[3].Value;

            Model.FoodStock itemObject = Model.FoodStock.findById(itemId);

            int newQuantity = currentNumberOfItem - 1;

            if(newQuantity == 0)
            {
                //if queantity already zero remove from cart
                this.itemListInCart.Rows.Remove(row);
            }
            else
            {
                //minus quantity
                row.Cells[3].Value = newQuantity;
                row.Cells[4].Value = itemObject.Price;
                row.Cells[5].Value = newQuantity * itemObject.Price;
            }
            updateTotalCalculation();
        }

        private void updateTotalCalculation()
        {
            decimal totalPrice = 0;

            foreach(DataGridViewRow row in this.itemListInCart.Rows)
            {
                totalPrice += (decimal)row.Cells[5].Value;
            }

            //if orderType is dine in got dine in tax
            if (orderType.SelectedIndex == 0)
            {
                this.subTotal.Text = totalPrice.ToString();
                this.tax.Text = (totalPrice * 6 / 100).ToString();
                this.serviceTax.Text = (totalPrice * 10 / 100).ToString();
                this.totalPrice.Text = "RM "+(totalPrice * 116 / 100).ToString();
            }
            else
            {
                this.subTotal.Text = totalPrice.ToString();
                this.tax.Text = (totalPrice * 6 / 100).ToString();
                this.serviceTax.Text = "N/A";
                this.totalPrice.Text = "RM "+(totalPrice * 106 / 100).ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.foodListContainer.Controls.Clear();
            searchAndUpdateList(searchBar.Text);
        }

        

        

        private void XQtyButton_Click(object sender, EventArgs e)
        {
            if (this.itemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                string userinput = ShowQuantityInputDialog("Enter Quantity:", "Quantity Input Box");

                if (userinput != "")
                {
                    //if input returned not empty because if user cancel the return will be empty
                    int newQuantity = Convert.ToInt32(userinput);

                    foreach (DataGridViewRow row in this.itemListInCart.SelectedRows)
                    {
                        int itemId = (int)row.Cells[1].Value;
                        int currentNumberOfItem = (int)row.Cells[3].Value;

                        Model.FoodStock itemObject = Model.FoodStock.findById(itemId);

                        if(itemObject.Quantity >= newQuantity)
                        {
                            //modify quantity
                            row.Cells[3].Value = newQuantity;
                            row.Cells[4].Value = itemObject.Price;
                            row.Cells[5].Value = newQuantity * itemObject.Price;
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Cannot modify item {0} because you have only {1} stock",itemObject.Name,itemObject.Quantity));
                        }
                        
                    }
                    updateTotalCalculation();
                }                
            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
            
        }

        public static string ShowQuantityInputDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 40, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 70, Top = 70};
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 70, Top = 70};
            //button click event handler
            confirmation.Click += (sender, e) => {
                try
                {
                    int input = Convert.ToInt32(textBox.Text);

                    if (input > 0)
                    {
                        prompt.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Integer more than 0!");
                    }
                }
                catch
                {
                    MessageBox.Show("Please Enter only Integer!");
                }
            };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            searchAndUpdateList("");
            searchBar.Text = "";
        }

        private void minusQtyButton_Click(object sender, EventArgs e)
        {
            if (this.itemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                foreach(DataGridViewRow row in this.itemListInCart.SelectedRows)
                {
                    minusQuantityToRow(row);
                }
                
            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.itemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                foreach (DataGridViewRow row in this.itemListInCart.SelectedRows)
                {
                    this.itemListInCart.Rows.Remove(row);
                }
                updateTotalCalculation();
            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }     
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            this.itemListInCart.Rows.Clear();
            updateTotalCalculation();
        }

        private void plusQtyButton_Click(object sender, EventArgs e)
        {
            if (this.itemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                foreach (DataGridViewRow row in this.itemListInCart.SelectedRows)
                {
                    addQuantityToRow(row);
                }

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
        }

        private void orderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTotalCalculation();
        }

        private void cashPayButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cashPayed =Convert.ToDecimal(this.cashAmount.Text);

                if(this.itemListInCart.Rows.Count > 0)
                {
                    //add all food object
                    List<Receipt_Food> foodlist = new List<Receipt_Food>();
                    foreach (DataGridViewRow row in this.itemListInCart.Rows)
                    {
                        int foodid = (int)row.Cells[1].Value;
                        int quantity = (int)row.Cells[3].Value;
                        FoodStock foodObj = FoodStock.findById(foodid);
                        foodlist.Add(new Receipt_Food(foodid,foodObj.Name,foodObj.Price, quantity));
                    }

                    //make the receipt
                    decimal totalPrice = 0;

                    foreach (DataGridViewRow row in this.itemListInCart.Rows)
                    {
                        totalPrice += (decimal)row.Cells[5].Value;
                    }

                    
                    decimal tax = (totalPrice * 6 / 100);
                    decimal servTax = this.orderType.SelectedIndex == 0 ? totalPrice * 10 / 100 : 0;
                    decimal finaltotal = totalPrice + tax + servTax;

                    if (cashPayed >= finaltotal)
                    {
                        Receipt newReceipt = new Receipt(tax, servTax, finaltotal, foodlist);
                        newReceipt.save();

                        /*Minus the stock from database*/
                        foreach(Receipt_Food currFood in newReceipt.FoodOrdered)
                        {
                            //food stock quantity minus ordered quantity

                            FoodStock foodObj = FoodStock.findById(currFood.FoodId);
                            foodObj.Quantity -= currFood.QuantityOrdered;
                            foodObj.save();
                            
                            if (foodObj.Quantity <= 0)
                            {
                                EmailSupplierForm emailSupplier = new EmailSupplierForm(foodObj.Id,foodObj.Name);
                                emailSupplier.Show();
                            }
                        }

                        this.Hide();
                        ReceiptPage showReceipt = new ReceiptPage(newReceipt, cashPayed);
                        showReceipt.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The cash amount cannot be lower than Total Price!");
                    }

                    
                }
                else
                {
                    MessageBox.Show("You must have at least one item to checkout!");

                }


            }
            catch(Exception ex)
            {
                if(ex is FormatException)
                {
                    MessageBox.Show("Cash Amount must be decimal number!");
                }
                else
                {
                    MessageBox.Show("Error saving receipt!");
                    
                }
                
            }
        }

        private void creditCardPay_Click(object sender, EventArgs e)
        {
            if (this.itemListInCart.Rows.Count > 0)
            {
                //add all food object
                List<Receipt_Food> foodlist = new List<Receipt_Food>();
                foreach (DataGridViewRow row in this.itemListInCart.Rows)
                {
                    int foodid = (int)row.Cells[1].Value;
                    int quantity = (int)row.Cells[3].Value;
                    FoodStock foodObj = FoodStock.findById(foodid);

                    foodlist.Add(new Receipt_Food(foodid, foodObj.Name, foodObj.Price, quantity));
                }

                //make the receipt
                decimal totalPrice = 0;

                foreach (DataGridViewRow row in this.itemListInCart.Rows)
                {
                    totalPrice += (decimal)row.Cells[5].Value;
                }


                decimal tax = (totalPrice * 6 / 100);
                decimal servTax = this.orderType.SelectedIndex == 0 ? totalPrice * 10 / 100 : 0;
                decimal finaltotal = totalPrice + tax + servTax;

               
                Receipt newReceipt = new Receipt(tax, servTax, finaltotal, foodlist);
                newReceipt.save();

                /*Minus the stock from database*/
                foreach (Receipt_Food currFood in newReceipt.FoodOrdered)
                {
                    //food stock quantity minus ordered quantity
                    FoodStock foodObj = FoodStock.findById(currFood.FoodId);
                    foodObj.Quantity -= currFood.QuantityOrdered;
                    foodObj.save();
                    
                    if (foodObj.Quantity <= 0)
                    {
                        EmailSupplierForm emailSupplier = new EmailSupplierForm(foodObj.Id,foodObj.Name);
                        emailSupplier.Show();
                    }
                }

                this.Hide();
                ReceiptPage showReceipt = new ReceiptPage(newReceipt, finaltotal);
                showReceipt.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("You must have at least one item to checkout!");

            }
        }

        private void endBusinessButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our POS system! Have a nice day =D");
            this.Close();
        }

    }
}
