namespace AssignmentCSharp.Main.View
{
    partial class SalesDetailsPopupForm
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
            this.SalesFoodList = new System.Windows.Forms.ListView();
            this.foodIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.ServiceChargeLabel = new System.Windows.Forms.Label();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.totalPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // SalesFoodList
            // 
            this.SalesFoodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodIDColumn,
            this.foodNameColumn,
            this.unitPriceColumn,
            this.quantityColumn,
            this.totalPriceColumn});
            this.SalesFoodList.HideSelection = false;
            this.SalesFoodList.Location = new System.Drawing.Point(12, 72);
            this.SalesFoodList.Name = "SalesFoodList";
            this.SalesFoodList.Size = new System.Drawing.Size(408, 243);
            this.SalesFoodList.TabIndex = 0;
            this.SalesFoodList.UseCompatibleStateImageBehavior = false;
            this.SalesFoodList.View = System.Windows.Forms.View.Details;
            // 
            // foodIDColumn
            // 
            this.foodIDColumn.Text = "ID";
            // 
            // foodNameColumn
            // 
            this.foodNameColumn.Text = "Name";
            this.foodNameColumn.Width = 95;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.Text = "Unit Price";
            this.unitPriceColumn.Width = 73;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Details";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GrandTotalLabel.Location = new System.Drawing.Point(69, 342);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(92, 17);
            this.GrandTotalLabel.TabIndex = 14;
            this.GrandTotalLabel.Text = "Grand Total: ";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(86, 394);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(75, 17);
            this.TaxLabel.TabIndex = 13;
            this.TaxLabel.Text = "Total Tax: ";
            // 
            // ServiceChargeLabel
            // 
            this.ServiceChargeLabel.AutoSize = true;
            this.ServiceChargeLabel.Location = new System.Drawing.Point(12, 368);
            this.ServiceChargeLabel.Name = "ServiceChargeLabel";
            this.ServiceChargeLabel.Size = new System.Drawing.Size(149, 17);
            this.ServiceChargeLabel.TabIndex = 12;
            this.ServiceChargeLabel.Text = "Total Service Charge: ";
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueLabel.Location = new System.Drawing.Point(20, 420);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(141, 20);
            this.RevenueLabel.TabIndex = 11;
            this.RevenueLabel.Text = "Total Revenue: ";
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.Text = "Total Price";
            this.totalPriceColumn.Width = 115;
            // 
            // SalesDetailsPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 459);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.ServiceChargeLabel);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesFoodList);
            this.Name = "SalesDetailsPopupForm";
            this.Text = "SalesDetailsPopupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SalesFoodList;
        private System.Windows.Forms.ColumnHeader foodIDColumn;
        private System.Windows.Forms.ColumnHeader foodNameColumn;
        private System.Windows.Forms.ColumnHeader unitPriceColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label ServiceChargeLabel;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader totalPriceColumn;
    }
}