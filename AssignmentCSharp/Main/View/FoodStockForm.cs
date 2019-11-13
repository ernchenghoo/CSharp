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
    public partial class FoodStockForm : Form
    {
        public FoodStockForm()
        {
            InitializeComponent();
            GetAllRecord("");
        }

        //public static string supplierEmailAddress = "";
        //public static int itemId = 0;
        //public static string emailSubject = "";

        private void FoodStock_Load(object sender, EventArgs e)
        {

        }

        private void GetAllRecord(string search)
        {
            this.dataFoodStock.Rows.Clear();
            foreach (Model.FoodStock food in Model.FoodStock.GetFoodStocks())
            {
                if (food.Name.ToLower().Contains(search.ToLower()))
                {
                    if(food.Quantity == 0 && food.AllowSendEmail == true)
                    {
                        Account myAcc = Model.Account.GetSupplierAcc();
                        //supplierEmailAddress = myAcc.Email;
                        //itemId = food.Id;
                        //emailSubject = food.Name;
                        //create email form to supplier
                        EmailSupplierForm emailSupplier = new EmailSupplierForm(myAcc.Email, food.Id, food.Name);
                        emailSupplier.Show();
                        this.dataFoodStock.Rows.Add(food.Id, food.Name, food.Category, food.Quantity, food.Price);
                  
                    }

                    else if(food.Quantity > 0)
                    {
                        dataFoodStock.ClearSelection();
                        this.dataFoodStock.Rows.Add(food.Id, food.Name, food.Category, food.Quantity, food.Price);
                    }

                    else
                    {
                        this.dataFoodStock.Rows.Add(food.Id, food.Name, food.Category, food.Quantity, food.Price);
                    }
                    
                }
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            ShowInputDialog("Enter item name :","Enter quantity : (enter more than 15)","Enter price :","Select Category:", "Add new item Box",-1);
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (this.dataFoodStock.SelectedRows.Count > 0)
            {
                // have row selected
                int itemId = (int)dataFoodStock.SelectedRows[0].Cells[0].Value;
                ShowInputDialog("Enter item name :", "Enter quantity :", "Enter price :", "Select Category:", "Edit item Box", itemId);

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
        }

        public void ShowInputDialog(string itemname,string quantity,string price,string category, string caption,int getId)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 470,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label itemNameLabel = new Label() { Left = 20, Top = 10, Text = itemname };
            TextBox itemNameTextBox = new TextBox() { Left = 20, Top = 30, Width = 200 };
            Label quantityLabel = new Label() { Left = 20, Top = 80, Text = quantity, Width = 300 };
            TextBox quantityTextBox = new TextBox() { Left = 20, Top = 100, Width = 200 };
            Label priceLabel = new Label() { Left = 20, Top = 150, Text = price };
            TextBox priceTextBox = new TextBox() { Left = 20, Top = 170, Width = 200 };
            Label categoryLabel = new Label() { Left = 20, Top = 220, Text = category };
            ListBox categoryListBox = new ListBox() { Left = 20, Top = 245, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 70, Top = 360 };
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 70, Top = 360 };

            foreach (Model.FoodCategory food in Model.FoodCategory.getFoodCategory())
            {
                categoryListBox.Sorted = true;
                categoryListBox.Items.Add(food.Category);
                
            }

            //if getId is not equal negative 1 that means its a existing object
            if (getId != -1)
            {
                FoodStock foodId = FoodStock.FindById(getId);
                itemNameTextBox.Text = foodId.Name;
                categoryListBox.SelectedItem = foodId.Category;
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
                    string selectedItem = "";
                    string errorMessages = "";
                    bool validSendEmail = true;

                    foreach (Model.FoodStock food in Model.FoodStock.GetFoodStocks())
                    {
                        if (itemNameTextBox.Text.ToLower() == food.Name.ToLower() && getId != food.Id)
                        {
                            errorMessages += "Food name already exist please enter another food name\n";
                        }
                    }


                    if (categoryListBox.SelectedItem != null) {
                        selectedItem = categoryListBox.Items[categoryListBox.SelectedIndex].ToString();
                    }
                    else
                    {
                        errorMessages += "Please select one food category\n";
                    }                   

                    if (inputQuantity < 0)
                    {
                        errorMessages += "Please enter positive integer for Quantity\n";
                    }

                    if (inputPrice < 0)
                    {
                        errorMessages += "Please enter positive integer for Price\n";
                    }

                    if (errorMessages != "")
                    {
                        MessageBox.Show(errorMessages);
                    }
                    else
                    {
                        prompt.DialogResult = DialogResult.OK;
                        if (getId == -1)
                        {
                            validSendEmail = true;
                            FoodStock newItem = new FoodStock(inputItemName, selectedItem, inputQuantity, inputPrice, validSendEmail);
                            newItem.Save();
                            GetAllRecord("");                            
                        }
                        else
                        {
                            FoodStock foodId = FoodStock.FindById(getId);
                            foodId.Name = inputItemName;
                            foodId.Category = selectedItem;
                            foodId.Quantity = inputQuantity;
                            foodId.Price = inputPrice;       
                            if (inputQuantity >= 1)
                            {
                                validSendEmail = true;
                            }
                            foodId.AllowSendEmail = validSendEmail;
                            foodId.Save();
                            GetAllRecord("");
                        }
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Please Enter only Integer for quantity and price!\nPlease select one food category");
                }
            };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(itemNameTextBox);
            prompt.Controls.Add(quantityTextBox);
            prompt.Controls.Add(priceTextBox);
            prompt.Controls.Add(itemNameLabel);
            prompt.Controls.Add(quantityLabel);
            prompt.Controls.Add(priceLabel);
            prompt.Controls.Add(categoryLabel);
            prompt.Controls.Add(categoryListBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);            
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (this.dataFoodStock.SelectedRows.Count > 0)
            {
                // have row selected
                int itemId = (int)dataFoodStock.SelectedRows[0].Cells[0].Value;
                FoodStock foodId = FoodStock.FindById(itemId);
                foodId.Delete();
                GetAllRecord("");

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.dataFoodStock.Controls.Clear();
            GetAllRecord(searchBar.Text);
        }

        private void ClearSearchButton_Click_1(object sender, EventArgs e)
        {
            GetAllRecord("");
            searchBar.Text = "";
        }

        private void ManageStock_Click(object sender, EventArgs e)
        {
            if (this.dataFoodStock.SelectedRows.Count > 0)
            {
                // have row selected
                int itemId = (int)dataFoodStock.SelectedRows[0].Cells[0].Value;
                string userinput = ShowInputQuantityDialog("Enter number of amount will be added in the stock", "Manage Stock Box", itemId);

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }

        }

        public string ShowInputQuantityDialog(string quantity, string caption,int getId)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label foodNameLabel = new Label() { Left = 20, Top = 10, Width = 300 };
            foodNameLabel.Font = new Font(foodNameLabel.Font, FontStyle.Bold);
            Label originalQuantityLabel = new Label() { Left = 20, Top = 30,Width =150 };
            originalQuantityLabel.Font = new Font(originalQuantityLabel.Font, FontStyle.Bold);            
            Label quantityLabel = new Label() { Left = 20, Top = 50, Text = quantity, Width =300 };            
            TextBox quantityTextBox = new TextBox() { Left = 20, Top = 70, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 70, Top = 100 };
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 70, Top = 100 };

            if (getId != -1)
            {
                FoodStock foodId = FoodStock.FindById(getId);
                foodNameLabel.Text = string.Format("Food name: {0}", foodId.Name);
                originalQuantityLabel.Text = string.Format("Original quantity: {0}",foodId.Quantity.ToString());                
            }

            //button click event handler
            confirmation.Click += (sender, e) => {
                try
                {
                    FoodStock foodId = FoodStock.FindById(getId);
                    int total = foodId.Quantity;
                    int inputQuantity = Convert.ToInt32(quantityTextBox.Text);
                    bool validSendEmail = true;
                    string errorMessages = "";
                    

                    if (inputQuantity < 0)
                    {
                        errorMessages += "Please enter positive integer for Quantity\n";
                    }
                    else
                    {                        
                        total += inputQuantity;
                    }

                    if (errorMessages != "")
                    {
                        MessageBox.Show(errorMessages);
                    }
                    else
                    {
                        prompt.DialogResult = DialogResult.OK;
                        FoodStock foodAdd = FoodStock.FindById(getId);
                        foodAdd.Quantity = total;
                        if (total >= 1)
                        {
                            validSendEmail = true;
                        }
                        else
                        {
                            validSendEmail = false;
                        }
                        foodAdd.AllowSendEmail = validSendEmail;
                        foodAdd.AddStock();
                        GetAllRecord("");


                    }
                }
                catch
                {
                    MessageBox.Show("Please Enter only Integer!\n");
                }
            };
            cancel.Click += (sender, e) => { prompt.Close(); };

   
            prompt.Controls.Add(quantityTextBox);
            prompt.Controls.Add(quantityLabel);
            prompt.Controls.Add(originalQuantityLabel);
            prompt.Controls.Add(foodNameLabel);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? quantityTextBox.Text : "";
        }

        private void SupplierEmail_Click(object sender, EventArgs e)
        {
            ShowSupplierEmailDialog("Supplier Email :", "Supplier Email");
        }

        public void ShowSupplierEmailDialog(string email, string caption)
        {
            Form prompt = new Form()
            {
                Width = 280,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label supplierEmailLabel = new Label() { Left = 20, Top = 10, Width = 200, Text = email};              
            TextBox supplierEmailTextBox = new TextBox() { Left = 20, Top = 30, Width = 200 };
            Button confirmation = new Button() { Text = "Change", Left = 20, Width = 60, Top = 60 };
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 50, Top = 60 };

            Account myAcc = Model.Account.GetSupplierAcc();
            supplierEmailTextBox.Text = myAcc.Email;

            //button click event handler
            confirmation.Click += (sender, e) => {
                try
                {                   
                    string inputSupplierEmail = supplierEmailTextBox.Text;                    
                    string errorMessages = "";

                    if (inputSupplierEmail == "")
                    {
                        errorMessages += "Email Address cannot be empty";
                    }

                    if (errorMessages != "")
                    {
                        MessageBox.Show(errorMessages);
                    }
                    else
                    {
                        prompt.DialogResult = DialogResult.OK;
                        Account supplierEmail = Model.Account.GetSupplierAcc();
                        supplierEmail.Email = inputSupplierEmail;
                        supplierEmail.Save();
                    }
                }
                catch
                {
                    MessageBox.Show("Please Enter Email Address only!\n");
                }
            };
            cancel.Click += (sender, e) => { prompt.Close(); };


            prompt.Controls.Add(supplierEmailTextBox);
            prompt.Controls.Add(supplierEmailLabel);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
        }
    }
}
