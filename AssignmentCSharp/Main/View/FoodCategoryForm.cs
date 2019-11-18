using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentCSharp.Main.Model;
using System.Windows.Forms;

namespace AssignmentCSharp.Main.View
{
    public partial class FoodCategoryForm : Form
    {
        public FoodCategoryForm()
        {
            InitializeComponent();
            GetAllRecord();
        }

        private void GetAllRecord()
        {
            this.dataFoodCategory.Rows.Clear();
            foreach (Model.FoodCategory food in Model.FoodCategory.GetFoodCategory())
            {           
                dataFoodCategory.ClearSelection();
                this.dataFoodCategory.Rows.Add(food.Id, food.Category);

            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            ShowInputDialog("Enter Category name :", "Add New Category Box", -1);
        }

        private void EditCategory_Click(object sender, EventArgs e)
        {
            if (this.dataFoodCategory.SelectedRows.Count > 0)
            {
                // have row selected
                int itemId = (int)dataFoodCategory.SelectedRows[0].Cells[0].Value;
                ShowInputDialog("Enter Category name :", "Edit Category Box", itemId);

            }
            else
            {
                // no  row is selected 
                MessageBox.Show("No row is Selected");
            }
        }

        public void ShowInputDialog(string category, string caption, int getId)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label categoryLabel = new Label() { Left = 20, Top = 10, Text = category,Width =200 };
            TextBox categoryTextBox = new TextBox() { Left = 20, Top = 35, Width = 200 };           
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 70, Top = 65 };
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 70, Top = 65 };


            //if getId is not equal negative 1 that means its a existing object
            if (getId != -1)
            {                
                FoodCategory CategoryId = FoodCategory.FindById(getId);
                categoryTextBox.Text = CategoryId.Category;                
            }
            //button click event handler
            confirmation.Click += (sender, e) => {
                try
                {
                    string inputCategoryName = categoryTextBox.Text;
                    string errorMessages = "";

                    foreach (Model.FoodCategory food in Model.FoodCategory.GetFoodCategory())
                    {
                        if (categoryTextBox.Text.ToLower() == food.Category.ToLower())
                        {
                            errorMessages += "Category name already exist please enter another category name\n";
                        }
                    }

                    if (inputCategoryName ==  "")
                    {
                        errorMessages += "Category cannot be empty\n";
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
                            FoodCategory newCategory = new FoodCategory(inputCategoryName);
                            newCategory.Save();
                            GetAllRecord();
                        }
                        else
                        {
                            FoodCategory CategoryId = FoodCategory.FindById(getId);
                            CategoryId.Category = inputCategoryName;
                            CategoryId.Save();
                            GetAllRecord();                            
                        }
                        
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);                    
                }
            };
            cancel.Click += (sender, e) => { prompt.Close(); };


            prompt.Controls.Add(categoryLabel);
            prompt.Controls.Add(categoryTextBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();

        }

        
    }
}
