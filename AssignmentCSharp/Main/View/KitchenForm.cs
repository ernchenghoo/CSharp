using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentCSharp.Main.Model;
using System.Threading;

namespace AssignmentCSharp.Main.View
{
    public partial class KitchenForm : Form
    {
        public int currentReceiptCount = 0;
        Thread backgroundCheckThread = null;
        public KitchenForm()
        {
            InitializeComponent();
            this.detail_id.Text = "";
            

            backgroundCheckThread = new Thread(delegate ()
            {

                while (true)
                {
                    UpdateOrderList();
                    Thread.Sleep(1000);
                }
                
            });
            backgroundCheckThread.IsBackground = true;
            backgroundCheckThread.Start();

        }        
        public void UpdateOrderList()
        {
            List<Receipt> orderNotDone = new List<Receipt>();

            foreach (Receipt currReceipt in Receipt.GetReceipts())
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
                MessageBox.Show("There are new orders!");

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

        public void UpdateOrderDetail(int receiptId)
        {
            this.foodList.Rows.Clear();
            Receipt receiptObject = Receipt.FindById(receiptId);

            this.detail_id.Text = receiptObject.Id.ToString();
            this.detail_time.Text = receiptObject.DatePrinted.ToString("yyyy/MM/dd hh:mm:ss tt");

            int totalFoodOrdered = 0;
            foreach(Receipt_Food food in receiptObject.FoodOrdered)
            {
                this.foodList.Rows.Add(this.foodList.Rows.Count + 1, food.FoodName, food.QuantityOrdered);
                totalFoodOrdered += food.QuantityOrdered;
            }

            this.detail_numoffood.Text = totalFoodOrdered.ToString();
            foodList.ClearSelection();

        }

        private void OrderList_OnSelectionChanged(object sender, EventArgs e)
        {
            if (this.orderList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.orderList.SelectedRows[0];

                int orderid = (int)row.Cells[1].Value;
                UpdateOrderDetail(orderid);
            }
            else
            {
                this.foodList.Rows.Clear();
                this.detail_id.Text = "";
                this.detail_time.Text = "";
                this.detail_numoffood.Text = "";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int orderid = Convert.ToInt32(this.detail_id.Text);

                Receipt receiptObj = Receipt.FindById(orderid);

                foreach(Receipt_Food food in receiptObj.FoodOrdered)
                {
                    food.IsDone = true;
                    food.Save();
                }
                currentReceiptCount -= 1;

                //update the orderlist
                List<Receipt> orderNotDone = new List<Receipt>();

                foreach (Receipt currReceipt in Receipt.GetReceipts())
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
                    UpdateOrderDetail(id);
                }


            }
            catch
            {
                MessageBox.Show("No order selected!");
            }
            


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our POS system! Have a nice day =D");
            this.Close();

            //stop the background thread that constantly check DB for new order
            backgroundCheckThread.Abort();


            Program.homePageFormReference.clearAllTextBox();
            Program.homePageFormReference.Show();
        }
    }   
}
