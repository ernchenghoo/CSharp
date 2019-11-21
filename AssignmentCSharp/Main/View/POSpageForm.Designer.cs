namespace AssignmentCSharp.Main.View
{


    partial class POSpageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.endBusinessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.takeAwayRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInRadioButton = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.creditCardPay = new System.Windows.Forms.Button();
            this.cashPayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.minusQtyButton = new System.Windows.Forms.Button();
            this.cashAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.serviceTax = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemListInCart = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryContainer = new System.Windows.Forms.FlowLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.ItemListInCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.endBusinessButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 47);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(945, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(172, 38);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // endBusinessButton
            // 
            this.endBusinessButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endBusinessButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.logout;
            this.endBusinessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endBusinessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endBusinessButton.FlatAppearance.BorderSize = 0;
            this.endBusinessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBusinessButton.Location = new System.Drawing.Point(1125, 5);
            this.endBusinessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endBusinessButton.Name = "endBusinessButton";
            this.endBusinessButton.Size = new System.Drawing.Size(188, 39);
            this.endBusinessButton.TabIndex = 1;
            this.endBusinessButton.UseVisualStyleBackColor = true;
            this.endBusinessButton.Click += new System.EventHandler(this.EndBusinessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.takeAwayRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.dineInRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.creditCardPay);
            this.splitContainer1.Panel1.Controls.Add(this.cashPayButton);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.clearAllButton);
            this.splitContainer1.Panel1.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.minusQtyButton);
            this.splitContainer1.Panel1.Controls.Add(this.cashAmount);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.totalPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.serviceTax);
            this.splitContainer1.Panel1.Controls.Add(this.tax);
            this.splitContainer1.Panel1.Controls.Add(this.subTotal);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.ItemListInCart);
            this.splitContainer1.Panel1.Controls.Add(this.cashierNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Controls.Add(this.categoryContainer);
            this.splitContainer1.Panel2.Controls.Add(this.foodListContainer);
            this.splitContainer1.Panel2.Controls.Add(this.clearSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.searchButton);
            this.splitContainer1.Panel2.Controls.Add(this.searchBar);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 681);
            this.splitContainer1.SplitterDistance = 662;
            this.splitContainer1.TabIndex = 1;
            // 
            // takeAwayRadioButton
            // 
            this.takeAwayRadioButton.AutoSize = true;
            this.takeAwayRadioButton.Location = new System.Drawing.Point(581, 12);
            this.takeAwayRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.takeAwayRadioButton.Name = "takeAwayRadioButton";
            this.takeAwayRadioButton.Size = new System.Drawing.Size(98, 21);
            this.takeAwayRadioButton.TabIndex = 25;
            this.takeAwayRadioButton.TabStop = true;
            this.takeAwayRadioButton.Text = "Take Away";
            this.takeAwayRadioButton.UseVisualStyleBackColor = true;
            this.takeAwayRadioButton.CheckedChanged += new System.EventHandler(this.TakeAwayRadioButton_CheckedChanged);
            // 
            // dineInRadioButton
            // 
            this.dineInRadioButton.AutoSize = true;
            this.dineInRadioButton.Location = new System.Drawing.Point(495, 12);
            this.dineInRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dineInRadioButton.Name = "dineInRadioButton";
            this.dineInRadioButton.Size = new System.Drawing.Size(74, 21);
            this.dineInRadioButton.TabIndex = 24;
            this.dineInRadioButton.TabStop = true;
            this.dineInRadioButton.Text = "Dine-In";
            this.dineInRadioButton.UseVisualStyleBackColor = true;
            this.dineInRadioButton.CheckedChanged += new System.EventHandler(this.DineInRadioButton_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(359, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Order Type :";
            // 
            // creditCardPay
            // 
            this.creditCardPay.BackgroundImage = global::AssignmentCSharp.Properties.Resources.creditccardpay;
            this.creditCardPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.creditCardPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditCardPay.FlatAppearance.BorderSize = 0;
            this.creditCardPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCardPay.Location = new System.Drawing.Point(516, 603);
            this.creditCardPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditCardPay.Name = "creditCardPay";
            this.creditCardPay.Size = new System.Drawing.Size(163, 46);
            this.creditCardPay.TabIndex = 21;
            this.creditCardPay.UseVisualStyleBackColor = true;
            this.creditCardPay.Click += new System.EventHandler(this.CreditCardPay_Click);
            // 
            // cashPayButton
            // 
            this.cashPayButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.cashpay;
            this.cashPayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cashPayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashPayButton.FlatAppearance.BorderSize = 0;
            this.cashPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashPayButton.Location = new System.Drawing.Point(516, 546);
            this.cashPayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashPayButton.Name = "cashPayButton";
            this.cashPayButton.Size = new System.Drawing.Size(160, 41);
            this.cashPayButton.TabIndex = 20;
            this.cashPayButton.UseVisualStyleBackColor = true;
            this.cashPayButton.Click += new System.EventHandler(this.CashPayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AssignmentCSharp.Properties.Resources.usericon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(115, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 34);
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
            this.clearAllButton.Location = new System.Drawing.Point(581, 238);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(77, 78);
            this.clearAllButton.TabIndex = 18;
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.remove;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(585, 148);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 71);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // minusQtyButton
            // 
            this.minusQtyButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.quantityminus;
            this.minusQtyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusQtyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusQtyButton.FlatAppearance.BorderSize = 0;
            this.minusQtyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusQtyButton.Location = new System.Drawing.Point(581, 50);
            this.minusQtyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minusQtyButton.Name = "minusQtyButton";
            this.minusQtyButton.Size = new System.Drawing.Size(79, 75);
            this.minusQtyButton.TabIndex = 16;
            this.minusQtyButton.UseVisualStyleBackColor = true;
            this.minusQtyButton.Click += new System.EventHandler(this.MinusQtyButton_Click);
            // 
            // cashAmount
            // 
            this.cashAmount.Location = new System.Drawing.Point(597, 505);
            this.cashAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(73, 22);
            this.cashAmount.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cash amount:";
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(291, 565);
            this.totalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalPrice.Multiline = true;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(212, 62);
            this.totalPrice.TabIndex = 11;
            this.totalPrice.Text = "RM 0";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 41);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total :";
            // 
            // serviceTax
            // 
            this.serviceTax.AutoSize = true;
            this.serviceTax.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTax.Location = new System.Drawing.Point(191, 610);
            this.serviceTax.Name = "serviceTax";
            this.serviceTax.Size = new System.Drawing.Size(27, 29);
            this.serviceTax.TabIndex = 9;
            this.serviceTax.Text = "0";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(189, 562);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(27, 29);
            this.tax.TabIndex = 8;
            this.tax.Text = "0";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(193, 507);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(27, 29);
            this.subTotal.TabIndex = 7;
            this.subTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Service (10%) : RM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tax (6%) : RM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "SubTotal : RM";
            // 
            // ItemListInCart
            // 
            this.ItemListInCart.AllowUserToAddRows = false;
            this.ItemListInCart.AllowUserToDeleteRows = false;
            this.ItemListInCart.AllowUserToResizeColumns = false;
            this.ItemListInCart.AllowUserToResizeRows = false;
            this.ItemListInCart.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemListInCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemListInCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemListInCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemListInCart.ColumnHeadersHeight = 40;
            this.ItemListInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ItemListInCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.id,
            this.ItemName,
            this.quantity,
            this.price,
            this.total});
            this.ItemListInCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemListInCart.EnableHeadersVisualStyles = false;
            this.ItemListInCart.Location = new System.Drawing.Point(3, 46);
            this.ItemListInCart.Margin = new System.Windows.Forms.Padding(0);
            this.ItemListInCart.Name = "ItemListInCart";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemListInCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemListInCart.RowHeadersVisible = false;
            this.ItemListInCart.RowHeadersWidth = 51;
            this.ItemListInCart.RowTemplate.Height = 24;
            this.ItemListInCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemListInCart.Size = new System.Drawing.Size(572, 452);
            this.ItemListInCart.TabIndex = 3;
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
            // cashierNameLabel
            // 
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameLabel.Location = new System.Drawing.Point(148, 14);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(99, 25);
            this.cashierNameLabel.TabIndex = 1;
            this.cashierNameLabel.Text = "John Doe";
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
            // categoryContainer
            // 
            this.categoryContainer.Location = new System.Drawing.Point(19, 42);
            this.categoryContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryContainer.Name = "categoryContainer";
            this.categoryContainer.Size = new System.Drawing.Size(679, 79);
            this.categoryContainer.TabIndex = 9;
            // 
            // foodListContainer
            // 
            this.foodListContainer.AutoScroll = true;
            this.foodListContainer.Location = new System.Drawing.Point(19, 175);
            this.foodListContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodListContainer.Name = "foodListContainer";
            this.foodListContainer.Size = new System.Drawing.Size(667, 482);
            this.foodListContainer.TabIndex = 8;
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AssignmentCSharp.Properties.Resources.clearsearch;
            this.clearSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(523, 128);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(131, 34);
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
            this.searchButton.Location = new System.Drawing.Point(468, 128);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(37, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(19, 135);
            this.searchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(431, 22);
            this.searchBar.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(614, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "                                                                                 " +
    "                                        ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Menu";
            // 
            // POSpageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "POSpageForm";
            this.Text = "POS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListInCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ItemListInCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label serviceTax;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cashAmount;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button minusQtyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button creditCardPay;
        private System.Windows.Forms.Button cashPayButton;
        private System.Windows.Forms.Button endBusinessButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.FlowLayoutPanel foodListContainer;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel categoryContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.RadioButton takeAwayRadioButton;
        private System.Windows.Forms.RadioButton dineInRadioButton;
        private System.Windows.Forms.Button backButton;
    }
}