﻿namespace AssignmentCSharp
{
    

    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endBusinessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.creditCardPay = new System.Windows.Forms.Button();
            this.cashPayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.minusQtyButton = new System.Windows.Forms.Button();
            this.plusQtyButton = new System.Windows.Forms.Button();
            this.xQtyButton = new System.Windows.Forms.Button();
            this.cashAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemListInCart = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foodListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListInCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.endBusinessButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 47);
            this.panel1.TabIndex = 0;
            // 
            // endBusinessButton
            // 
            this.endBusinessButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.endbusiness;
            this.endBusinessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endBusinessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endBusinessButton.FlatAppearance.BorderSize = 0;
            this.endBusinessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBusinessButton.Location = new System.Drawing.Point(1151, 4);
            this.endBusinessButton.Name = "endBusinessButton";
            this.endBusinessButton.Size = new System.Drawing.Size(188, 40);
            this.endBusinessButton.TabIndex = 1;
            this.endBusinessButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "POS SYSTEM";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.creditCardPay);
            this.splitContainer1.Panel1.Controls.Add(this.cashPayButton);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.clearAllButton);
            this.splitContainer1.Panel1.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.minusQtyButton);
            this.splitContainer1.Panel1.Controls.Add(this.plusQtyButton);
            this.splitContainer1.Panel1.Controls.Add(this.xQtyButton);
            this.splitContainer1.Panel1.Controls.Add(this.cashAmount);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.totalPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.itemListInCart);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Controls.Add(this.foodListContainer);
            this.splitContainer1.Panel2.Controls.Add(this.clearSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.searchButton);
            this.splitContainer1.Panel2.Controls.Add(this.searchBar);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.splitContainer1.SplitterDistance = 681;
            this.splitContainer1.TabIndex = 1;
            // 
            // creditCardPay
            // 
            this.creditCardPay.BackgroundImage = global::AssignmentCSharp.Properties.Resources.creditccardpay;
            this.creditCardPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.creditCardPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditCardPay.FlatAppearance.BorderSize = 0;
            this.creditCardPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCardPay.Location = new System.Drawing.Point(516, 603);
            this.creditCardPay.Name = "creditCardPay";
            this.creditCardPay.Size = new System.Drawing.Size(162, 45);
            this.creditCardPay.TabIndex = 21;
            this.creditCardPay.UseVisualStyleBackColor = true;
            // 
            // cashPayButton
            // 
            this.cashPayButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.cashpay;
            this.cashPayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cashPayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashPayButton.FlatAppearance.BorderSize = 0;
            this.cashPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashPayButton.Location = new System.Drawing.Point(516, 547);
            this.cashPayButton.Name = "cashPayButton";
            this.cashPayButton.Size = new System.Drawing.Size(160, 41);
            this.cashPayButton.TabIndex = 20;
            this.cashPayButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AssignmentCSharp.Properties.Resources.usericon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(114, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 35);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.clearall;
            this.clearAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Location = new System.Drawing.Point(587, 353);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(67, 68);
            this.clearAllButton.TabIndex = 18;
            this.clearAllButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.remove;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(589, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 64);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // minusQtyButton
            // 
            this.minusQtyButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.quantityminus;
            this.minusQtyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusQtyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusQtyButton.FlatAppearance.BorderSize = 0;
            this.minusQtyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusQtyButton.Location = new System.Drawing.Point(586, 203);
            this.minusQtyButton.Name = "minusQtyButton";
            this.minusQtyButton.Size = new System.Drawing.Size(71, 69);
            this.minusQtyButton.TabIndex = 16;
            this.minusQtyButton.UseVisualStyleBackColor = true;
            // 
            // plusQtyButton
            // 
            this.plusQtyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusQtyButton.BackgroundImage")));
            this.plusQtyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusQtyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusQtyButton.FlatAppearance.BorderSize = 0;
            this.plusQtyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusQtyButton.Location = new System.Drawing.Point(588, 127);
            this.plusQtyButton.Name = "plusQtyButton";
            this.plusQtyButton.Size = new System.Drawing.Size(69, 70);
            this.plusQtyButton.TabIndex = 15;
            this.plusQtyButton.UseVisualStyleBackColor = true;
            // 
            // xQtyButton
            // 
            this.xQtyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xQtyButton.BackgroundImage")));
            this.xQtyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xQtyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xQtyButton.FlatAppearance.BorderSize = 0;
            this.xQtyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xQtyButton.Location = new System.Drawing.Point(587, 53);
            this.xQtyButton.Name = "xQtyButton";
            this.xQtyButton.Size = new System.Drawing.Size(69, 68);
            this.xQtyButton.TabIndex = 14;
            this.xQtyButton.UseVisualStyleBackColor = true;
            this.xQtyButton.Click += new System.EventHandler(this.XQtyButton_Click);
            // 
            // cashAmount
            // 
            this.cashAmount.Location = new System.Drawing.Point(597, 504);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(73, 22);
            this.cashAmount.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cash amount:";
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(321, 565);
            this.totalPrice.Multiline = true;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(166, 62);
            this.totalPrice.TabIndex = 11;
            this.totalPrice.Text = "RM 200";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(334, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 41);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(176, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "2.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "0.80";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "200.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tax (10%) : RM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "SST (6%) : RM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "SubTotal : RM";
            // 
            // itemListInCart
            // 
            this.itemListInCart.AllowUserToAddRows = false;
            this.itemListInCart.AllowUserToDeleteRows = false;
            this.itemListInCart.AllowUserToResizeColumns = false;
            this.itemListInCart.AllowUserToResizeRows = false;
            this.itemListInCart.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemListInCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemListInCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemListInCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemListInCart.ColumnHeadersHeight = 40;
            this.itemListInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemListInCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.id,
            this.ItemName,
            this.quantity,
            this.price,
            this.total});
            this.itemListInCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemListInCart.EnableHeadersVisualStyles = false;
            this.itemListInCart.Location = new System.Drawing.Point(3, 46);
            this.itemListInCart.Margin = new System.Windows.Forms.Padding(0);
            this.itemListInCart.Name = "itemListInCart";
            this.itemListInCart.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemListInCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemListInCart.RowHeadersVisible = false;
            this.itemListInCart.RowHeadersWidth = 51;
            this.itemListInCart.RowTemplate.Height = 24;
            this.itemListInCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemListInCart.Size = new System.Drawing.Size(572, 452);
            this.itemListInCart.TabIndex = 3;
            // 
            // No
            // 
            this.No.FillWeight = 40F;
            this.No.Frozen = true;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // id
            // 
            this.id.FillWeight = 40F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 140F;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 160;
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
            // total
            // 
            this.total.FillWeight = 70F;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "John Doe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cashier :";
            // 
            // foodListContainer
            // 
            this.foodListContainer.AutoScroll = true;
            this.foodListContainer.Location = new System.Drawing.Point(19, 141);
            this.foodListContainer.Name = "foodListContainer";
            this.foodListContainer.Size = new System.Drawing.Size(635, 498);
            this.foodListContainer.TabIndex = 8;
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.clearsearch;
            this.clearSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(512, 86);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(130, 35);
            this.clearSearchButton.TabIndex = 6;
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(459, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(37, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(18, 96);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(431, 22);
            this.searchBar.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(614, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "                                                                                 " +
    "                                        ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Menu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListInCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemListInCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cashAmount;
        private System.Windows.Forms.Button xQtyButton;
        private System.Windows.Forms.Button plusQtyButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button minusQtyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button creditCardPay;
        private System.Windows.Forms.Button cashPayButton;
        private System.Windows.Forms.Button endBusinessButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel foodListContainer;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}