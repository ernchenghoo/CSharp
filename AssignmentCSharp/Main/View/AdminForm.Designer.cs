namespace AssignmentCSharp.Main.View
{
    partial class AdminForm
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
            this.CashierButton = new System.Windows.Forms.Button();
            this.StocksButton = new System.Windows.Forms.Button();
            this.KitchenButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // CashierButton
            // 
            this.CashierButton.Location = new System.Drawing.Point(43, 132);
            this.CashierButton.Name = "CashierButton";
            this.CashierButton.Size = new System.Drawing.Size(156, 66);
            this.CashierButton.TabIndex = 1;
            this.CashierButton.Text = "Cashier";
            this.CashierButton.UseVisualStyleBackColor = true;
            this.CashierButton.Click += new System.EventHandler(this.CashierButton_Click);
            // 
            // StocksButton
            // 
            this.StocksButton.Location = new System.Drawing.Point(430, 132);
            this.StocksButton.Name = "StocksButton";
            this.StocksButton.Size = new System.Drawing.Size(156, 66);
            this.StocksButton.TabIndex = 2;
            this.StocksButton.Text = "Stocks";
            this.StocksButton.UseVisualStyleBackColor = true;
            this.StocksButton.Click += new System.EventHandler(this.StocksButton_Click);
            // 
            // KitchenButton
            // 
            this.KitchenButton.Location = new System.Drawing.Point(235, 132);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(156, 66);
            this.KitchenButton.TabIndex = 3;
            this.KitchenButton.Text = "Kitchen";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += new System.EventHandler(this.KitchenButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(617, 132);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(156, 66);
            this.AccountButton.TabIndex = 4;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.logoutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountDetailsToolStripMenuItem});
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.manageAccountToolStripMenuItem.Text = "Manage account";
            // 
            // editAccountDetailsToolStripMenuItem
            // 
            this.editAccountDetailsToolStripMenuItem.Name = "editAccountDetailsToolStripMenuItem";
            this.editAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.editAccountDetailsToolStripMenuItem.Text = "Change password";
            this.editAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.EditAccountDetailsToolStripMenuItem_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 24);
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 442);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.KitchenButton);
            this.Controls.Add(this.StocksButton);
            this.Controls.Add(this.CashierButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CashierButton;
        private System.Windows.Forms.Button StocksButton;
        private System.Windows.Forms.Button KitchenButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutButton;
        private System.Windows.Forms.ToolStripMenuItem editAccountDetailsToolStripMenuItem;
    }
}