namespace AssignmentCSharp.Main.View
{
    partial class KitchenForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.orderList = new System.Windows.Forms.DataGridView();
            this.timeOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDoneButton = new System.Windows.Forms.Button();
            this.detail_numoffood = new System.Windows.Forms.Label();
            this.detail_time = new System.Windows.Forms.Label();
            this.detail_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foodList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 43);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AssignmentCSharp.Properties.Resources.logout;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(776, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitchen System";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.orderList);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.orderDoneButton);
            this.splitContainer1.Panel2.Controls.Add(this.detail_numoffood);
            this.splitContainer1.Panel2.Controls.Add(this.detail_time);
            this.splitContainer1.Panel2.Controls.Add(this.detail_id);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.foodList);
            this.splitContainer1.Size = new System.Drawing.Size(947, 571);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // orderList
            // 
            this.orderList.AllowUserToAddRows = false;
            this.orderList.AllowUserToDeleteRows = false;
            this.orderList.AllowUserToResizeColumns = false;
            this.orderList.AllowUserToResizeRows = false;
            this.orderList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeOrdered,
            this.orderid});
            this.orderList.Location = new System.Drawing.Point(12, 48);
            this.orderList.Margin = new System.Windows.Forms.Padding(4);
            this.orderList.MultiSelect = false;
            this.orderList.Name = "orderList";
            this.orderList.ReadOnly = true;
            this.orderList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.orderList.RowHeadersVisible = false;
            this.orderList.RowHeadersWidth = 51;
            this.orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderList.Size = new System.Drawing.Size(331, 497);
            this.orderList.TabIndex = 1;
            this.orderList.SelectionChanged += new System.EventHandler(this.OrderList_OnSelectionChanged);
            // 
            // timeOrdered
            // 
            this.timeOrdered.FillWeight = 140F;
            this.timeOrdered.HeaderText = "Time";
            this.timeOrdered.MinimumWidth = 6;
            this.timeOrdered.Name = "timeOrdered";
            this.timeOrdered.ReadOnly = true;
            this.timeOrdered.Width = 140;
            // 
            // orderid
            // 
            this.orderid.HeaderText = "Order ID";
            this.orderid.MinimumWidth = 6;
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order List";
            // 
            // orderDoneButton
            // 
            this.orderDoneButton.BackColor = System.Drawing.Color.GreenYellow;
            this.orderDoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderDoneButton.FlatAppearance.BorderSize = 2;
            this.orderDoneButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDoneButton.Location = new System.Drawing.Point(201, 517);
            this.orderDoneButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderDoneButton.Name = "orderDoneButton";
            this.orderDoneButton.Size = new System.Drawing.Size(165, 39);
            this.orderDoneButton.TabIndex = 8;
            this.orderDoneButton.Text = "Order Done";
            this.orderDoneButton.UseVisualStyleBackColor = false;
            this.orderDoneButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // detail_numoffood
            // 
            this.detail_numoffood.AutoSize = true;
            this.detail_numoffood.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_numoffood.Location = new System.Drawing.Point(185, 110);
            this.detail_numoffood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detail_numoffood.Name = "detail_numoffood";
            this.detail_numoffood.Size = new System.Drawing.Size(0, 20);
            this.detail_numoffood.TabIndex = 7;
            // 
            // detail_time
            // 
            this.detail_time.AutoSize = true;
            this.detail_time.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_time.Location = new System.Drawing.Point(184, 85);
            this.detail_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detail_time.Name = "detail_time";
            this.detail_time.Size = new System.Drawing.Size(0, 20);
            this.detail_time.TabIndex = 6;
            // 
            // detail_id
            // 
            this.detail_id.AutoSize = true;
            this.detail_id.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_id.Location = new System.Drawing.Point(184, 59);
            this.detail_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detail_id.Name = "detail_id";
            this.detail_id.Size = new System.Drawing.Size(0, 20);
            this.detail_id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order ID :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 110);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total No of Food :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Detail";
            // 
            // foodList
            // 
            this.foodList.AllowUserToAddRows = false;
            this.foodList.AllowUserToDeleteRows = false;
            this.foodList.AllowUserToResizeColumns = false;
            this.foodList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.foodList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.foodList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.foodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.foodname,
            this.quantity});
            this.foodList.Enabled = false;
            this.foodList.Location = new System.Drawing.Point(37, 149);
            this.foodList.Margin = new System.Windows.Forms.Padding(4);
            this.foodList.MultiSelect = false;
            this.foodList.Name = "foodList";
            this.foodList.ReadOnly = true;
            this.foodList.RowHeadersVisible = false;
            this.foodList.RowHeadersWidth = 51;
            this.foodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodList.Size = new System.Drawing.Size(476, 359);
            this.foodList.TabIndex = 0;
            // 
            // No
            // 
            this.No.FillWeight = 40F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // foodname
            // 
            this.foodname.FillWeight = 210F;
            this.foodname.HeaderText = "Food Name";
            this.foodname.MinimumWidth = 6;
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            this.foodname.Width = 210;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 614);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KitchenForm";
            this.Text = "KitchenForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label detail_numoffood;
        private System.Windows.Forms.Label detail_time;
        private System.Windows.Forms.Label detail_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView foodList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderid;
        private System.Windows.Forms.Button orderDoneButton;
    }
}