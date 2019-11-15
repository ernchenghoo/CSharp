﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Main.Model;

namespace AssignmentCSharp.Main.View
{
    public partial class ReceiptPage : Form
    {
        public Receipt MyReceipt { get; set; }

        public ReceiptPage(Receipt receipt,decimal cashPayed)
        {
            InitializeComponent();
            MyReceipt = receipt;
            IntitiallizeReceipt();
            this.amountPaid.Text ="RM " + cashPayed.ToString();
            this.balance.Text = "RM " + (cashPayed - MyReceipt.Total).ToString();
            this.date.Text = MyReceipt.DatePrinted.ToString("yyyy/MM/dd");
            this.time.Text = MyReceipt.DatePrinted.ToString("hh:mm:ss tt");
        }

        private void IntitiallizeReceipt()
        {
            foreach(Receipt_Food food in MyReceipt.FoodOrdered)
            {
                int newNo = this.itemList.Rows.Count+1;
                this.itemList.Rows.Add(newNo, food.FoodName,food.QuantityOrdered,food.FoodPrice*food.QuantityOrdered );
            }
            this.subtotal.Text = "RM "+(MyReceipt.Total - MyReceipt.ServiceTax - MyReceipt.Tax).ToString();
            this.servicetax.Text = "RM " + MyReceipt.ServiceTax.ToString();
            this.tax.Text = "RM " + MyReceipt.Tax.ToString();
            this.totalprice.Text = "RM " + MyReceipt.Total.ToString();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            POSpageForm newPosPage = new POSpageForm();
            newPosPage.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our POS system! Have a nice day =D");
            this.Close();
            Program.homePageFormReference.clearAllTextBox();
            Program.homePageFormReference.Show();
        }
    }
}
