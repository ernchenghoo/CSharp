namespace AssignmentCSharp.Main.View
{
    partial class ManageAccountsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.createAccButton = new System.Windows.Forms.Button();
            this.accountList = new System.Windows.Forms.ListView();
            this.emailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts";
            // 
            // createAccButton
            // 
            this.createAccButton.Location = new System.Drawing.Point(602, 134);
            this.createAccButton.Name = "createAccButton";
            this.createAccButton.Size = new System.Drawing.Size(134, 23);
            this.createAccButton.TabIndex = 2;
            this.createAccButton.Text = "Create Account";
            this.createAccButton.UseVisualStyleBackColor = true;
            this.createAccButton.Click += new System.EventHandler(this.CreateAccButton_Click);
            // 
            // accountList
            // 
            this.accountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emailHeader,
            this.roleHeader});
            this.accountList.FullRowSelect = true;
            this.accountList.GridLines = true;
            this.accountList.HideSelection = false;
            this.accountList.Location = new System.Drawing.Point(45, 134);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(495, 264);
            this.accountList.TabIndex = 3;
            this.accountList.UseCompatibleStateImageBehavior = false;
            this.accountList.View = System.Windows.Forms.View.Details;
            this.accountList.SelectedIndexChanged += new System.EventHandler(this.AccountList_SelectedIndexChanged);
            // 
            // emailHeader
            // 
            this.emailHeader.Text = "Email";
            this.emailHeader.Width = 377;
            // 
            // roleHeader
            // 
            this.roleHeader.Text = "Role";
            this.roleHeader.Width = 112;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(602, 182);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(134, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Account";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(602, 232);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Account";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(694, 397);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManageAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.accountList);
            this.Controls.Add(this.createAccButton);
            this.Controls.Add(this.label1);
            this.Name = "ManageAccountsForm";
            this.Text = "Manage Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccButton;
        private System.Windows.Forms.ListView accountList;
        private System.Windows.Forms.ColumnHeader emailHeader;
        private System.Windows.Forms.ColumnHeader roleHeader;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}