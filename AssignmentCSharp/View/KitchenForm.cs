using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Model;
using System.Threading;

namespace AssignmentCSharp.View
{
    public partial class KitchenForm : Form
    {
        public int currentReceiptCount = 0;
        public KitchenForm()
        {
            InitializeComponent();
            this.detail_id.Text = "";

            Thread t2 = new Thread(delegate ()
            {
                while (true)
                {
                    updateOrderList();
                    Thread.Sleep(1000);
                }
                
            });
            t2.IsBackground = true;
            t2.Start();

        }        
        public void updateOrderList()
        {
            List<Receipt> orderNotDone = new List<Receipt>();

            foreach (Receipt currReceipt in Receipt.getReceipts())
            {
                bool gotUnfinishFood = false;
                foreach(Receipt_Food food in currReceipt.FoodOrdered)
                {
                    if(food.IsDone == false)
                    {
                        gotUnfinishFood = true;
                    }
                }

                if(gotUnfinishFood == true)
                {
                    orderNotDone.Add( currReceipt);                 
                }
            }
            var orderDescList = from receipt in orderNotDone
                                orderby receipt.DatePrinted ascending
                                select receipt;


            int count = orderDescList.Count();
            if (this.currentReceiptCount != count)
            {
                this.currentReceiptCount = count;
                MessageBox.Show("There are a new Order!");

                if (this.InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate () {
                        orderList.Rows.Clear();
                    }));
                }
                else
                {
                    orderList.Rows.Clear();
                }

                foreach (Receipt currReceipt in orderDescList)
                {
                    if (this.InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate () {
                            this.orderList.Rows.Add(currReceipt.DatePrinted.ToString("yyyy/MM/dd hh:mm:ss tt"), currReceipt.Id);
                        }));
                    }
                    else
                    {
                        this.orderList.Rows.Add(currReceipt.DatePrinted.ToString("yyyy/MM/dd hh:mm:ss tt"), currReceipt.Id);
                    }
                }

            }
        }

        public void updateOrderDetail(int receiptId)
        {
            this.foodList.Rows.Clear();
            Receipt receiptObject = Receipt.findById(receiptId);

            this.detail_id.Text = receiptObject.Id.ToString();
            this.detail_time.Text = receiptObject.DatePrinted.ToString("yyyy/MM/dd hh:mm:ss tt");

            int totalFoodOrdered = 0;
            foreach(Receipt_Food food in receiptObject.FoodOrdered)
            {
                this.foodList.Rows.Add(this.foodList.Rows.Count + 1, food.FoodName, food.QuantityOrdered);
                totalFoodOrdered += food.QuantityOrdered;
            }

            this.detail_numoffood.Text = totalFoodOrdered.ToString();

        }

        private void orderList_OnSelectionChanged(object sender, EventArgs e)
        {
            if (this.orderList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.orderList.SelectedRows[0];

                int orderid = (int)row.Cells[1].Value;
                updateOrderDetail(orderid);
            }
            else
            {
                this.foodList.Rows.Clear();
                this.detail_id.Text = "";
                this.detail_time.Text = "";
                this.detail_numoffood.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int orderid = Convert.ToInt32(this.detail_id.Text);

                Receipt receiptObj = Receipt.findById(orderid);

                foreach(Receipt_Food food in receiptObj.FoodOrdered)
                {
                    food.IsDone = true;
                    food.save();
                }
                currentReceiptCount -= 1;

                //update the orderlist
                List<Receipt> orderNotDone = new List<Receipt>();

                foreach (Receipt currReceipt in Receipt.getReceipts())
                {
                    bool gotUnfinishFood = false;
                    foreach (Receipt_Food food in currReceipt.FoodOrdered)
                    {
                        if (food.IsDone == false)
                        {
                            gotUnfinishFood = true;
                        }
                    }

                    if (gotUnfinishFood == true)
                    {
                        orderNotDone.Add(currReceipt);
                    }
                }
                var orderDescList = from receipt in orderNotDone
                                    orderby receipt.DatePrinted descending
                                    select receipt;
                orderList.Rows.Clear();

                foreach (Receipt currReceipt in orderDescList)
                {
                    if (this.InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate () {
                            this.orderList.Rows.Add(currReceipt.DatePrinted.ToString("yyyy/MM/dd hh:mm:ss tt"), currReceipt.Id);
                        }));
                    }
                    else
                    {
                        this.orderList.Rows.Add(currReceipt.DatePrinted.ToString("yyyy/MM/dd hh:mm:ss tt"), currReceipt.Id);
                    }
                }

                this.foodList.Rows.Clear();
                this.detail_id.Text = "";
                this.detail_time.Text = "";
                this.detail_numoffood.Text = "";

                if(this.orderList.RowCount > 0)
                {
                    int id = (int)this.orderList.Rows[0].Cells[1].Value; ;
                    updateOrderDetail(id);
                }


            }
            catch
            {
                MessageBox.Show("No order selected!");
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our POS system! Have a nice day =D");
            this.Close();
        }
    }   
}
