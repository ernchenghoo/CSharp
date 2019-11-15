namespace AssignmentCSharp.Main.View
{
    partial class FoodStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFoodStock = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItem = new System.Windows.Forms.Button();
            this.editItem = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.manageStock = new System.Windows.Forms.Button();
            this.supplierEmail = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFoodStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // dataFoodStock
            // 
            this.dataFoodStock.AllowUserToAddRows = false;
            this.dataFoodStock.AllowUserToDeleteRows = false;
            this.dataFoodStock.AllowUserToResizeColumns = false;
            this.dataFoodStock.AllowUserToResizeRows = false;
            this.dataFoodStock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataFoodStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFoodStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFoodStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFoodStock.ColumnHeadersHeight = 40;
            this.dataFoodStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFoodStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.itemName,
            this.category,
            this.quantity,
            this.price});
            this.dataFoodStock.EnableHeadersVisualStyles = false;
            this.dataFoodStock.Location = new System.Drawing.Point(21, 161);
            this.dataFoodStock.Margin = new System.Windows.Forms.Padding(0);
            this.dataFoodStock.MultiSelect = false;
            this.dataFoodStock.Name = "dataFoodStock";
            this.dataFoodStock.ReadOnly = true;
            this.dataFoodStock.RowHeadersVisible = false;
            this.dataFoodStock.RowHeadersWidth = 51;
            this.dataFoodStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFoodStock.Size = new System.Drawing.Size(588, 308);
            this.dataFoodStock.TabIndex = 3;
            // 
            // no
            // 
            this.no.FillWeight = 40F;
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 40;
            // 
            // itemName
            // 
            this.itemName.FillWeight = 140F;
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 160;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 45F;
            this.quantity.HeaderText = "Qty";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 45;
            // 
            // price
            // 
            this.price.FillWeight = 70F;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 70;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(625, 161);
            this.addItem.Margin = new System.Windows.Forms.Padding(4);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(159, 36);
            this.addItem.TabIndex = 4;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // editItem
            // 
            this.editItem.Location = new System.Drawing.Point(625, 225);
            this.editItem.Margin = new System.Windows.Forms.Padding(4);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(159, 36);
            this.editItem.TabIndex = 5;
            this.editItem.Text = "Edit Item";
            this.editItem.UseVisualStyleBackColor = true;
            this.editItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(625, 364);
            this.deleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(159, 36);
            this.deleteItem.TabIndex = 6;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(15, 80);
            this.searchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(342, 22);
            this.searchBar.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(383, 72);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(37, 32);
            this.searchButton.TabIndex = 8;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.clearsearch;
            this.clearSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(447, 69);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(131, 34);
            this.clearSearchButton.TabIndex = 9;
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click_1);
            // 
            // manageStock
            // 
            this.manageStock.Location = new System.Drawing.Point(625, 296);
            this.manageStock.Margin = new System.Windows.Forms.Padding(4);
            this.manageStock.Name = "manageStock";
            this.manageStock.Size = new System.Drawing.Size(159, 36);
            this.manageStock.TabIndex = 10;
            this.manageStock.Text = "Add Stock";
            this.manageStock.UseVisualStyleBackColor = true;
            this.manageStock.Click += new System.EventHandler(this.ManageStock_Click);
            // 
            // supplierEmail
            // 
            this.supplierEmail.Location = new System.Drawing.Point(625, 72);
            this.supplierEmail.Margin = new System.Windows.Forms.Padding(4);
            this.supplierEmail.Name = "supplierEmail";
            this.supplierEmail.Size = new System.Drawing.Size(159, 36);
            this.supplierEmail.TabIndex = 11;
            this.supplierEmail.Text = "Supplier Email";
            this.supplierEmail.UseVisualStyleBackColor = true;
            this.supplierEmail.Click += new System.EventHandler(this.SupplierEmail_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.logout;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(614, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(190, 44);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // FoodStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 478);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.supplierEmail);
            this.Controls.Add(this.manageStock);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.editItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.dataFoodStock);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodStockForm";
            this.Text = "FoodStock";
            this.Load += new System.EventHandler(this.FoodStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFoodStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataFoodStock;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button editItem;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button manageStock;
        private System.Windows.Forms.Button supplierEmail;
        private System.Windows.Forms.Button logoutButton;
    }
}