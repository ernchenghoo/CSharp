namespace AssignmentCSharp.Main.View
{
    partial class SupplierEmailForm
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
            this.supplierEmailLabel = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.dataFoodStock = new System.Windows.Forms.DataGridView();
            this.addEmail = new System.Windows.Forms.Button();
            this.editEmail = new System.Windows.Forms.Button();
            this.deleteEmail = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataFoodStock)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierEmailLabel
            // 
            this.supplierEmailLabel.AutoSize = true;
            this.supplierEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierEmailLabel.Location = new System.Drawing.Point(6, 9);
            this.supplierEmailLabel.Name = "supplierEmailLabel";
            this.supplierEmailLabel.Size = new System.Drawing.Size(158, 24);
            this.supplierEmailLabel.TabIndex = 0;
            this.supplierEmailLabel.Text = "Supplier Email list";
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(10, 69);
            this.searchBar.Margin = new System.Windows.Forms.Padding(2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(257, 20);
            this.searchBar.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(285, 63);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(28, 26);
            this.searchButton.TabIndex = 9;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.clearsearch;
            this.clearSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(341, 62);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(98, 28);
            this.clearSearchButton.TabIndex = 10;
            this.clearSearchButton.UseVisualStyleBackColor = true;
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
            this.companyName,
            this.email,
            this.contactPerson});
            this.dataFoodStock.EnableHeadersVisualStyles = false;
            this.dataFoodStock.Location = new System.Drawing.Point(10, 110);
            this.dataFoodStock.Margin = new System.Windows.Forms.Padding(0);
            this.dataFoodStock.MultiSelect = false;
            this.dataFoodStock.Name = "dataFoodStock";
            this.dataFoodStock.ReadOnly = true;
            this.dataFoodStock.RowHeadersVisible = false;
            this.dataFoodStock.RowHeadersWidth = 51;
            this.dataFoodStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFoodStock.Size = new System.Drawing.Size(462, 229);
            this.dataFoodStock.TabIndex = 11;
            // 
            // addEmail
            // 
            this.addEmail.Location = new System.Drawing.Point(514, 110);
            this.addEmail.Name = "addEmail";
            this.addEmail.Size = new System.Drawing.Size(119, 29);
            this.addEmail.TabIndex = 12;
            this.addEmail.Text = "Add Email";
            this.addEmail.UseVisualStyleBackColor = true;
            // 
            // editEmail
            // 
            this.editEmail.Location = new System.Drawing.Point(514, 168);
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(119, 29);
            this.editEmail.TabIndex = 13;
            this.editEmail.Text = "Edit Email";
            this.editEmail.UseVisualStyleBackColor = true;
            // 
            // deleteEmail
            // 
            this.deleteEmail.Location = new System.Drawing.Point(514, 227);
            this.deleteEmail.Name = "deleteEmail";
            this.deleteEmail.Size = new System.Drawing.Size(119, 29);
            this.deleteEmail.TabIndex = 14;
            this.deleteEmail.Text = "Delete Email";
            this.deleteEmail.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.FillWeight = 40F;
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 40;
            // 
            // companyName
            // 
            this.companyName.FillWeight = 140F;
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Width = 160;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // contactPerson
            // 
            this.contactPerson.FillWeight = 45F;
            this.contactPerson.HeaderText = "Contact Person";
            this.contactPerson.Name = "contactPerson";
            this.contactPerson.ReadOnly = true;
            this.contactPerson.Width = 150;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(8, 44);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(170, 16);
            this.searchLabel.TabIndex = 15;
            this.searchLabel.Text = "Search by Company Name";
            // 
            // SupplierEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 348);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.deleteEmail);
            this.Controls.Add(this.editEmail);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.dataFoodStock);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.supplierEmailLabel);
            this.Name = "SupplierEmailForm";
            this.Text = "SupplierEmailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataFoodStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supplierEmailLabel;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.DataGridView dataFoodStock;
        private System.Windows.Forms.Button addEmail;
        private System.Windows.Forms.Button editEmail;
        private System.Windows.Forms.Button deleteEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPerson;
        private System.Windows.Forms.Label searchLabel;
    }
}