namespace AssignmentCSharp.Main.View
{
    partial class FoodCategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFoodCategory = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCategory = new System.Windows.Forms.Button();
            this.editCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFoodCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Category";
            // 
            // dataFoodCategory
            // 
            this.dataFoodCategory.AllowUserToAddRows = false;
            this.dataFoodCategory.AllowUserToDeleteRows = false;
            this.dataFoodCategory.AllowUserToResizeColumns = false;
            this.dataFoodCategory.AllowUserToResizeRows = false;
            this.dataFoodCategory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataFoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFoodCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFoodCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataFoodCategory.ColumnHeadersHeight = 40;
            this.dataFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFoodCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.category});
            this.dataFoodCategory.EnableHeadersVisualStyles = false;
            this.dataFoodCategory.Location = new System.Drawing.Point(21, 64);
            this.dataFoodCategory.Margin = new System.Windows.Forms.Padding(0);
            this.dataFoodCategory.MultiSelect = false;
            this.dataFoodCategory.Name = "dataFoodCategory";
            this.dataFoodCategory.ReadOnly = true;
            this.dataFoodCategory.RowHeadersVisible = false;
            this.dataFoodCategory.RowHeadersWidth = 51;
            this.dataFoodCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFoodCategory.Size = new System.Drawing.Size(185, 260);
            this.dataFoodCategory.TabIndex = 4;
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
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(233, 64);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(119, 29);
            this.addCategory.TabIndex = 5;
            this.addCategory.Text = "Add Category";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // editCategory
            // 
            this.editCategory.Location = new System.Drawing.Point(233, 120);
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(119, 29);
            this.editCategory.TabIndex = 6;
            this.editCategory.Text = "Edit Category";
            this.editCategory.UseVisualStyleBackColor = true;
            this.editCategory.Click += new System.EventHandler(this.EditCategory_Click);
            // 
            // FoodCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.editCategory);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.dataFoodCategory);
            this.Controls.Add(this.label1);
            this.Name = "FoodCategoryForm";
            this.Text = "FoodCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataFoodCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataFoodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button editCategory;
    }
}