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
using System.Drawing.Imaging;

namespace AssignmentCSharp.Main.View
{
    
    public partial class POSpageForm : Form
    {
        private int categoryChosen = -1;
        private String orderType = null;
        public POSpageForm(bool isAdmin)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeComponent();
            SearchAndUpdateList("");

            //add value to comboBox
            this.orderType = "Dine-In";
            this.dineInRadioButton.Checked = true;

            DisplayListOfCategories();

            //set validation for the editing the quantity in the list
            this.ItemListInCart.CellBeginEdit += this.ItemListInCart_CellBeginEdit;
            this.ItemListInCart.CellEndEdit += this.ItemListInCart_CellEditEnding;

            String cashierName = Program.LoggedinAccount.account.Email.Split('@')[0];

            this.cashierNameLabel.Text = cashierName;

            if(isAdmin == true)
            {
                this.backButton.Visible = true;
            }
            else
            {
                this.backButton.Visible = false;
            }
        }

        private void DisplayListOfCategories()
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
            allButton.Tag = -1;
            allButton.UseVisualStyleBackColor = false;
            allButton.BackColor = System.Drawing.Color.Green;
            allButton.Click += new System.EventHandler(this.ChooseCategory);

            this.categoryContainer.Controls.Add(allButton);
            this.categoryChosen = -1;

            foreach (Model.FoodCategory category in Model.FoodCategory.GetFoodCategory())
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
                newButton.Tag = category.Id;
                newButton.UseVisualStyleBackColor = false;
                newButton.BackColor = System.Drawing.Color.Yellow;
                newButton.Click += new System.EventHandler(this.ChooseCategory);
          
                this.categoryContainer.Controls.Add(newButton);    
            }
        }

        private int oldValueOfItemListInCart_CellEditing = 0;
        private void ItemListInCart_CellEditEnding(object sender, DataGridViewCellEventArgs e)
        {
            

            int QuantityEntered = 0;
            try
            {
                String newValue = null;
                if(ItemListInCart[e.ColumnIndex, e.RowIndex].Value is System.Int32)
                {
                    QuantityEntered = (System.Int32) ItemListInCart[e.ColumnIndex, e.RowIndex].Value;
                }
                else
                {
                    newValue = (String)ItemListInCart[e.ColumnIndex, e.RowIndex].Value;
                    QuantityEntered = Convert.ToInt32(newValue);
                }
                
                

                if (QuantityEntered > 0)
                {
                    //check whether got enough stock
                    foreach (DataGridViewRow row in this.ItemListInCart.SelectedRows)
                    {
                        int itemId = (int)row.Cells[1].Value;

                        Model.FoodStock itemObject = Model.FoodStock.FindById(itemId);

                        if (itemObject.Quantity >= QuantityEntered)
                        {
                            //modify quantity
                            row.Cells[3].Value = QuantityEntered;
                            row.Cells[4].Value = itemObject.Price;
                            row.Cells[5].Value = QuantityEntered * itemObject.Price;
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Cannot modify item {0} because you have only {1} stock", itemObject.Name, itemObject.Quantity));
                            //setback to only value
                            ItemListInCart[e.ColumnIndex, e.RowIndex].Value = oldValueOfItemListInCart_CellEditing;
                        }

                    }
                    UpdateTotalCalculation();
                }
                else
                {
                    MessageBox.Show("Please Enter Integer more than 0!");
                    //setback to only value
                    ItemListInCart[e.ColumnIndex, e.RowIndex].Value = oldValueOfItemListInCart_CellEditing;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter only Integer!"+ex.Message);
                Console.WriteLine(ex.ToString());
                //setback to only value
                ItemListInCart[e.ColumnIndex, e.RowIndex].Value = oldValueOfItemListInCart_CellEditing;
            }
        }
        private void ItemListInCart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValueOfItemListInCart_CellEditing = (int)ItemListInCart[e.ColumnIndex, e.RowIndex].Value;
        }


        private void ChooseCategory(object sender, EventArgs e)
        {
            foreach (Button b in this.categoryContainer.Controls)
            {
                b.BackColor = System.Drawing.Color.Yellow;
            }

            System.Windows.Forms.Button buttonObject = (System.Windows.Forms.Button)sender;
            //save it to class variable so we can reference it later
            this.categoryChosen = (int)buttonObject.Tag;
            buttonObject.BackColor = System.Drawing.Color.Green;

            SearchAndUpdateList(this.searchBar.Text);
        }
        Image ConvertBinaryToImage(byte[] image)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(image, 0, image.Length))
            {
                ms.Write(image, 0, image.Length);
                //Set image variable value using memory stream.
                return Image.FromStream(ms, true);
            }
        }


        //function to search and update the food menu
        private void SearchAndUpdateList(String search)
        {
            this.foodListContainer.Controls.Clear();

            //filter food name
            var filteredList = from food in Model.FoodStock.GetFoodStocks()
                              where food.Name.ToLower().Contains(search.ToLower())
                              select food;
            //if category all is not chosen
            if (this.categoryChosen != -1)
            {
                //filter category
                filteredList = from food in filteredList
                               where food.CategoryId == this.categoryChosen
                               select food;
            }


            foreach (Model.FoodStock food in filteredList)
            {
                
                FlowLayoutPanel newFlowPanel = new FlowLayoutPanel {
                    Width = 150,
                    Height = 180,
                    Tag = food,
                    Cursor = Cursors.Hand,
                };

                


                PictureBox myPicBox = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(150, 150),
                    Image = ConvertBinaryToImage(food.Image),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = food,
                    Cursor = Cursors.Hand,
                };

                

                Label newLabel = new Label
                {
                    Text = food.Name,
                    Font = new Font("Arial", 15, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Width = 150,
                    Height = 30,
                    Tag = food,
                    Cursor = Cursors.Hand,
                };

                if (food.Quantity == 0)
                {
                    myPicBox.Image = (Image)ChangeOpacity((Bitmap)myPicBox.Image.Clone(),80);
                    newLabel.ForeColor = Color.Red;
                }

                newFlowPanel.Controls.Add(myPicBox);
                newFlowPanel.Controls.Add(newLabel);
                myPicBox.Click += new System.EventHandler(this.AddItem);
                newLabel.Click += new System.EventHandler(this.AddItem);

                this.foodListContainer.Controls.Add(newFlowPanel);



            }
        }
        static Bitmap ChangeOpacity(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
                                    new float[] {1, 0, 0, 0, 0},
                                    new float[] {0, 1, 0, 0, 0},
                                    new float[] {0, 0, 1, 0, 0},
                                    new float[] {0, 0, 0, a, 0},
                                    new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        //function to add the item to the cart
        private void AddItem(object sender, EventArgs e)
        {
            System.Windows.Forms.Control layoutPanelObject = (System.Windows.Forms.Control)sender;
            Model.FoodStock chosenFood = (Model.FoodStock)layoutPanelObject.Tag;

            DataGridViewRow foundItemInCart = null;
            foreach (DataGridViewRow row in this.ItemListInCart.Rows)
            {
                int currentRowID = (int)row.Cells[1].Value;
                if (currentRowID == chosenFood.Id)
                {
                    foundItemInCart = row;
                }
            }

            if (foundItemInCart == null)
            {
                int newNo = this.ItemListInCart.Rows.Count + 1;
                if(chosenFood.Quantity >0)
                {
                    this.ItemListInCart.Rows.Add(newNo, chosenFood.Id, chosenFood.Name, 1, chosenFood.Price, chosenFood.Price * 1);
                }
                else
                {
                    MessageBox.Show("Item out of stock!");
                }
                
            }
            else
            {
                //if enough quantity then show sucessfully added
                int currentNumberOfItem = (int)foundItemInCart.Cells[3].Value;
                                
                AddQuantityToRow(foundItemInCart);
            }
            UpdateTotalCalculation();
        }

        private void AddQuantityToRow(DataGridViewRow row)
        {

            int itemId = (int)row.Cells[1].Value;
            int currentNumberOfItem = (int)row.Cells[3].Value;

            Model.FoodStock itemObject = Model.FoodStock.FindById(itemId);

            int newQuantity = currentNumberOfItem + 1;
            if(itemObject.Quantity >= newQuantity)
            {
                //add quantity, update price, update total price
                row.Cells[3].Value = newQuantity;
                row.Cells[4].Value = itemObject.Price;
                row.Cells[5].Value = newQuantity * itemObject.Price;
                UpdateTotalCalculation();
            }
            else
            {
                MessageBox.Show(String.Format("You have only {0} stock for {1}!",itemObject.Quantity,itemObject.Name));
            }
            
        }

        private void MinusQuantityToRow(DataGridViewRow row)
        {

            int itemId = (int)row.Cells[1].Value;
            int currentNumberOfItem = (int)row.Cells[3].Value;

            Model.FoodStock itemObject = Model.FoodStock.FindById(itemId);

            int newQuantity = currentNumberOfItem - 1;

            if(newQuantity == 0)
            {
                //if queantity already zero remove from cart
                this.ItemListInCart.Rows.Remove(row);
            }
            else
            {
                //minus quantity
                row.Cells[3].Value = newQuantity;
                row.Cells[4].Value = itemObject.Price;
                row.Cells[5].Value = newQuantity * itemObject.Price;
            }
            UpdateTotalCalculation();
        }

        private void UpdateTotalCalculation()
        {
            decimal totalPrice = 0;

            foreach(DataGridViewRow row in this.ItemListInCart.Rows)
            {
                totalPrice += (decimal)row.Cells[5].Value;
            }

            //if orderType is dine in got dine in tax
            if (orderType == "Dine-In")
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
            SearchAndUpdateList(searchBar.Text);
        }

        

        

        private void XQtyButton_Click(object sender, EventArgs e)
        {
            if (this.ItemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                string userinput = ShowQuantityInputDialog("Enter Quantity:", "Quantity Input Box");

                if (userinput != "")
                {
                    //if input returned not empty because if user cancel the return will be empty
                    int newQuantity = Convert.ToInt32(userinput);

                    foreach (DataGridViewRow row in this.ItemListInCart.SelectedRows)
                    {
                        int itemId = (int)row.Cells[1].Value;
                        int currentNumberOfItem = (int)row.Cells[3].Value;

                        Model.FoodStock itemObject = Model.FoodStock.FindById(itemId);

                        if(itemObject.Quantity >= newQuantity)
                        {
                            //modify quantity
                            row.Cells[3].Value = newQuantity;
                            row.Cells[4].Value = itemObject.Price;
                            row.Cells[5].Value = newQuantity * itemObject.Price;
                        }
                        else
                        {
                            MessageBox.Show(String.Format("{0} only have {1} stocks available.",itemObject.Name,itemObject.Quantity));
                        }
                        
                    }
                    UpdateTotalCalculation();
                }                
            }
            else
            {
                // no  row is selected 
                MessageBox.Show("Please select an item to edit.");
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
            SearchAndUpdateList("");
            searchBar.Text = "";
        }

        private void MinusQtyButton_Click(object sender, EventArgs e)
        {
            if (this.ItemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                foreach(DataGridViewRow row in this.ItemListInCart.SelectedRows)
                {
                    MinusQuantityToRow(row);
                }
                
            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No item selected");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.ItemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                foreach (DataGridViewRow row in this.ItemListInCart.SelectedRows)
                {
                    this.ItemListInCart.Rows.Remove(row);
                }
                UpdateTotalCalculation();
            }
            else
            {
                // no  row is selected 
                MessageBox.Show("Please select an item to delete");
            }     
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            this.ItemListInCart.Rows.Clear();
            UpdateTotalCalculation();
        }

        private void PlusQtyButton_Click(object sender, EventArgs e)
        {
            if (this.ItemListInCart.SelectedRows.Count > 0)
            {
                // have row selected
                foreach (DataGridViewRow row in this.ItemListInCart.SelectedRows)
                {
                    AddQuantityToRow(row);
                }

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No item selected");
            }
        }

        private void OrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalCalculation();
        }

        private void CashPayButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cashPayed =Convert.ToDecimal(this.cashAmount.Text);

                if(this.ItemListInCart.Rows.Count > 0)
                {
                    //add all food object
                    List<Receipt_Food> foodlist = new List<Receipt_Food>();
                    foreach (DataGridViewRow row in this.ItemListInCart.Rows)
                    {
                        int foodid = (int)row.Cells[1].Value;
                        int quantity = (int)row.Cells[3].Value;
                        FoodStock foodObj = FoodStock.FindById(foodid);
                        foodlist.Add(new Receipt_Food(foodid,foodObj.Name,foodObj.Price, quantity));
                    }

                    //make the receipt
                    decimal totalPrice = 0;

                    foreach (DataGridViewRow row in this.ItemListInCart.Rows)
                    {
                        totalPrice += (decimal)row.Cells[5].Value;
                    }

                    
                    decimal tax = (totalPrice * 6 / 100);
                    decimal servTax = this.orderType == "Dine-In" ? totalPrice * 10 / 100 : 0;
                    decimal finaltotal = totalPrice + tax + servTax;

                    if (cashPayed >= finaltotal)
                    {
                        Receipt newReceipt = new Receipt(tax, servTax, finaltotal, foodlist);
                        newReceipt.Save();

                        /*Minus the stock from database*/
                        foreach(Receipt_Food currFood in newReceipt.FoodOrdered)
                        {
                            Account myAcc = Model.Account.GetSupplierAcc();
                            //food stock quantity minus ordered quantity
                            FoodStock foodObj = FoodStock.FindById(currFood.FoodId);
                            foodObj.Quantity -= currFood.QuantityOrdered;
                            foodObj.Save();
                            
                            if (foodObj.Quantity <= 0)
                            {
                                EmailSupplierForm emailSupplier = new EmailSupplierForm(myAcc.Email, foodObj.Id,foodObj.Name);
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

        private void CreditCardPay_Click(object sender, EventArgs e)
        {
            if (this.ItemListInCart.Rows.Count > 0)
            {
                //add all food object
                List<Receipt_Food> foodlist = new List<Receipt_Food>();
                foreach (DataGridViewRow row in this.ItemListInCart.Rows)
                {
                    int foodid = (int)row.Cells[1].Value;
                    int quantity = (int)row.Cells[3].Value;
                    FoodStock foodObj = FoodStock.FindById(foodid);

                    foodlist.Add(new Receipt_Food(foodid, foodObj.Name, foodObj.Price, quantity));
                }

                //make the receipt
                decimal totalPrice = 0;

                foreach (DataGridViewRow row in this.ItemListInCart.Rows)
                {
                    totalPrice += (decimal)row.Cells[5].Value;
                }


                decimal tax = (totalPrice * 6 / 100);
                decimal servTax = this.orderType == "Dine-In" ? totalPrice * 10 / 100 : 0;
                decimal finaltotal = totalPrice + tax + servTax;

               
                Receipt newReceipt = new Receipt(tax, servTax, finaltotal, foodlist);
                newReceipt.Save();

                /*Minus the stock from database*/
                foreach (Receipt_Food currFood in newReceipt.FoodOrdered)
                {
                    //food stock quantity minus ordered quantity
                    FoodStock foodObj = FoodStock.FindById(currFood.FoodId);
                    foodObj.Quantity -= currFood.QuantityOrdered;
                    foodObj.Save();
                    
                    if (foodObj.Quantity <= 0)
                    {
                        Account myAcc = Model.Account.GetSupplierAcc();
                        EmailSupplierForm emailSupplier = new EmailSupplierForm(myAcc.Email,foodObj.Id,foodObj.Name);
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

        private void EndBusinessButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our POS system! Have a nice day =D");
            this.Close();
            Program.homePageFormReference.clearAllTextBox();
            Program.homePageFormReference.Show();
        }

        private void DineInRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(dineInRadioButton.Checked == true)
            {
                this.orderType = "Dine-In";
                UpdateTotalCalculation();
            }
            
        }

        private void TakeAwayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(takeAwayRadioButton.Checked == true)
            {
                this.orderType = "Take-Away";
                UpdateTotalCalculation();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.LoadAdmin();
            this.Close();
        }
    }
}
