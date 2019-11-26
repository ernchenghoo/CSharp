namespace AssignmentCSharp.Main.View
{
    partial class DailySalesForm
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
            this.dataSet1 = new System.Data.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesList = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.ServiceChargeLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FoodSalesList = new System.Windows.Forms.ListView();
            this.foodNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantitySoldColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitButton = new System.Windows.Forms.Button();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.PrintButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Sales";
            // 
            // SalesList
            // 
            this.SalesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.DateColumn,
            this.SalesColumn});
            this.SalesList.FullRowSelect = true;
            this.SalesList.HideSelection = false;
            this.SalesList.Location = new System.Drawing.Point(24, 114);
            this.SalesList.Name = "SalesList";
            this.SalesList.Size = new System.Drawing.Size(301, 240);
            this.SalesList.TabIndex = 1;
            this.SalesList.UseCompatibleStateImageBehavior = false;
            this.SalesList.View = System.Windows.Forms.View.Details;
            this.SalesList.DoubleClick += new System.EventHandler(this.SalesList_OnDoubleClick);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 42;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 143;
            // 
            // SalesColumn
            // 
            this.SalesColumn.Text = "Sales";
            this.SalesColumn.Width = 101;
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueLabel.Location = new System.Drawing.Point(44, 468);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(165, 25);
            this.RevenueLabel.TabIndex = 2;
            this.RevenueLabel.Text = "Total Revenue: ";
            // 
            // ServiceChargeLabel
            // 
            this.ServiceChargeLabel.AutoSize = true;
            this.ServiceChargeLabel.Location = new System.Drawing.Point(56, 412);
            this.ServiceChargeLabel.Name = "ServiceChargeLabel";
            this.ServiceChargeLabel.Size = new System.Drawing.Size(149, 17);
            this.ServiceChargeLabel.TabIndex = 3;
            this.ServiceChargeLabel.Text = "Total Service Charge: ";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(130, 440);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(75, 17);
            this.TaxLabel.TabIndex = 4;
            this.TaxLabel.Text = "Total Tax: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = " Sales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = " Food Sold";
            // 
            // FoodSalesList
            // 
            this.FoodSalesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodNameColumn,
            this.foodPriceColumn,
            this.quantitySoldColumn});
            this.FoodSalesList.HideSelection = false;
            this.FoodSalesList.Location = new System.Drawing.Point(354, 114);
            this.FoodSalesList.Name = "FoodSalesList";
            this.FoodSalesList.Size = new System.Drawing.Size(296, 240);
            this.FoodSalesList.TabIndex = 8;
            this.FoodSalesList.UseCompatibleStateImageBehavior = false;
            this.FoodSalesList.View = System.Windows.Forms.View.Details;
            // 
            // foodNameColumn
            // 
            this.foodNameColumn.Text = "Food Name";
            this.foodNameColumn.Width = 110;
            // 
            // foodPriceColumn
            // 
            this.foodPriceColumn.Text = "Food Price";
            this.foodPriceColumn.Width = 126;
            // 
            // quantitySoldColumn
            // 
            this.quantitySoldColumn.Text = "Qty";
            this.quantitySoldColumn.Width = 56;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(564, 472);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GrandTotalLabel.Location = new System.Drawing.Point(113, 386);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(92, 17);
            this.GrandTotalLabel.TabIndex = 10;
            this.GrandTotalLabel.Text = "Grand Total: ";
            // 
            // PrintButon
            // 
            this.PrintButon.Location = new System.Drawing.Point(564, 433);
            this.PrintButon.Name = "PrintButon";
            this.PrintButon.Size = new System.Drawing.Size(75, 23);
            this.PrintButon.TabIndex = 11;
            this.PrintButon.Text = "Print";
            this.PrintButon.UseVisualStyleBackColor = true;
            this.PrintButon.Click += new System.EventHandler(this.PrintButon_Click);
            // 
            // DailySalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 562);
            this.Controls.Add(this.PrintButon);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FoodSalesList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.ServiceChargeLabel);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.SalesList);
            this.Controls.Add(this.label1);
            this.Name = "DailySalesForm";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView SalesList;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader SalesColumn;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.Label ServiceChargeLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView FoodSalesList;
        private System.Windows.Forms.ColumnHeader foodNameColumn;
        private System.Windows.Forms.ColumnHeader foodPriceColumn;
        private System.Windows.Forms.ColumnHeader quantitySoldColumn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Button PrintButon;
    }
}