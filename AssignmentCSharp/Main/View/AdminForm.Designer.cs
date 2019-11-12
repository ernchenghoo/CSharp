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
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // CashierButton
            // 
            this.CashierButton.Location = new System.Drawing.Point(43, 146);
            this.CashierButton.Name = "CashierButton";
            this.CashierButton.Size = new System.Drawing.Size(75, 23);
            this.CashierButton.TabIndex = 1;
            this.CashierButton.Text = "Cashier";
            this.CashierButton.UseVisualStyleBackColor = true;
            this.CashierButton.Click += new System.EventHandler(this.CashierButton_Click);
            // 
            // StocksButton
            // 
            this.StocksButton.Location = new System.Drawing.Point(43, 189);
            this.StocksButton.Name = "StocksButton";
            this.StocksButton.Size = new System.Drawing.Size(75, 23);
            this.StocksButton.TabIndex = 2;
            this.StocksButton.Text = "Stocks";
            this.StocksButton.UseVisualStyleBackColor = true;
            this.StocksButton.Click += new System.EventHandler(this.StocksButton_Click);
            // 
            // KitchenButton
            // 
            this.KitchenButton.Location = new System.Drawing.Point(43, 230);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(75, 23);
            this.KitchenButton.TabIndex = 3;
            this.KitchenButton.Text = "Kitchen";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += new System.EventHandler(this.KitchenButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(43, 275);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(75, 23);
            this.AccountButton.TabIndex = 4;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userToolStripMenuItem.AutoSize = false;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.KitchenButton);
            this.Controls.Add(this.StocksButton);
            this.Controls.Add(this.CashierButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}