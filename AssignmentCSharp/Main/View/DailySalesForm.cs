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
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace AssignmentCSharp.Main.View
{
    public partial class DailySalesForm : Form
    {
        static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";
        MySqlConnection cnn = new MySqlConnection(connectionString);
        public DailySalesForm()
        {
            InitializeComponent();
        }

        List<Receipt_Food> foodSold = new List<Receipt_Food>();
        List<Receipt> dailySales = new List<Receipt>();

        private void SalesReport_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            SalesList.Items.Clear();
            foreach (Receipt sale in DisplaySales())
            {
                string[] listRow = new string[] { sale.Id.ToString(), sale.DatePrinted.ToString(), sale.Total.ToString()};
                ListViewItem lvi = new ListViewItem(listRow);
                lvi.Tag = sale;
                SalesList.Items.Add(lvi);
            }

            FoodSalesList.Items.Clear();
            foreach (Receipt_Food food in DisplayFoodSold())
            {
                string[] listRow = new string[] { food.FoodName, food.FoodPrice.ToString(), food.QuantityOrdered.ToString() };
                ListViewItem lvi = new ListViewItem(listRow);
                lvi.Tag = food;
                FoodSalesList.Items.Add(lvi);
            }

            GrandTotalLabel.Text += "  RM" + calculateGrandTotal().ToString();
            ServiceChargeLabel.Text += "- RM" + calculateTotalServiceTax().ToString();
            TaxLabel.Text += "- RM" + calculateTotalTax().ToString();
            RevenueLabel.Text += "RM" + calculateTotalRevenue().ToString();

        }
        private List <Receipt> DisplaySales()
        {            
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();                
                String sql = "SELECT * from receipt WHERE DATE(`datePrinted`) = CURDATE()";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
               
                
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dailySales.Add(new Receipt(dataReader.GetInt32(0), dataReader.GetDateTime(1), 
                        dataReader.GetDecimal(2), dataReader.GetDecimal(3), dataReader.GetDecimal(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
            return dailySales;
        }
        private List<Receipt_Food> DisplayFoodSold()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                String sql = "SELECT SUM(receipt_food.quantityOrdered), receipt_food.receiptid, " +
                    "receipt_food.foodid, receipt_food.foodname, receipt_food.foodprice, receipt_food.quantityOrdered, " +
                    "receipt_food.isDone FROM `receipt_food` inner join receipt on receipt_food.receiptid=receipt.id " +
                    "WHERE DATE(`datePrinted`) = CURDATE() group by receipt_food.foodid";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);


                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    foodSold.Add(new Receipt_Food(dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetString(3),
                        dataReader.GetDecimal(4), dataReader.GetInt32(0), dataReader.GetBoolean(6)));
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
            return foodSold;
        }

        private decimal calculateTotalRevenue ()
        {
            decimal revenueSum = 0;

            foreach (Receipt sales in dailySales)
            {
                revenueSum += (sales.Total - sales.ServiceTax - sales.Tax);
            }
            return revenueSum;            
        }

        private decimal calculateTotalTax()
        {
            decimal taxSum = 0;

            foreach (Receipt sales in dailySales)
            {
                taxSum += sales.Tax;
            }
            return taxSum;
        }

        private decimal calculateTotalServiceTax()
        {
            decimal svcTaxSum = 0;

            foreach (Receipt sales in dailySales)
            {
                svcTaxSum += sales.ServiceTax;
            }
            return svcTaxSum;
        }

        private decimal calculateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (Receipt sales in dailySales)
            {
                grandTotal += sales.Total;
            }
            return grandTotal;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homePageFormReference.clearAllTextBox();
            Program.homePageFormReference.Show();
        }

        private void PrintButon_Click(object sender, EventArgs e)
        {
            string path = null;
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.Description = "Select location for report to generate";
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                try
                {
                    generateReport(path);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void generateReport(string pt)
        {           
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pt + "/Daily Sales Report.pdf", FileMode.Create));
            doc.Open();

            PdfContentByte cb = writer.DirectContent;
            cb.BeginText();
            //font styles
            BaseFont boldCalibri = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            BaseFont calibri = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            int yAxis = 780;
            //document title
            cb.SetFontAndSize(boldCalibri, 32);
            cb.SetTextMatrix(220, yAxis);
            cb.ShowText("Sales report");
            //document title end
            yAxis -= 50;

            cb.SetFontAndSize(calibri, 18);
            cb.SetTextMatrix(60, yAxis);
            cb.ShowText("Date: " + DateTime.Today.ToString("dd/MM/yyyy"));
            yAxis -= 40;
            //food section
            //title
            cb.SetFontAndSize(boldCalibri, 18);            
            cb.SetTextMatrix(60, yAxis);
            cb.ShowText("Food Sold");
            cb.EndText();
            cb.MoveTo(60, yAxis - 5);
            cb.LineTo(450, yAxis - 5);
            cb.Stroke();
            cb.BeginText();
            cb.SetFontAndSize(boldCalibri, 12);
            //title end
            yAxis -= 25;
            //header
            cb.SetTextMatrix(62, yAxis);
            cb.ShowText("Food Name");
            cb.SetTextMatrix(180, yAxis);
            cb.ShowText("Quantity");
            cb.SetTextMatrix(280, yAxis);
            cb.ShowText("Unit Price");
            cb.SetTextMatrix(400, yAxis);
            cb.ShowText("Total Price");
            //header end

            //data
            yAxis -= 20;
            cb.SetFontAndSize(calibri, 12);
            foreach (Receipt_Food food in foodSold)
            {
                cb.SetTextMatrix(62, yAxis);
                cb.ShowText(food.FoodName.ToString());
                cb.SetTextMatrix(180, yAxis);
                cb.ShowText(food.QuantityOrdered.ToString());
                cb.SetTextMatrix(280, yAxis);
                cb.ShowText("RM" + food.FoodPrice.ToString());
                cb.SetTextMatrix(400, yAxis);
                cb.ShowText("RM" + (food.FoodPrice * food.QuantityOrdered).ToString());

                yAxis -= 15;

            }
            //food data end

            yAxis -= 40;
            //order section
            //order title
            cb.SetFontAndSize(boldCalibri, 18);
            cb.SetTextMatrix(60, yAxis);
            cb.ShowText("Orders");
            cb.EndText();
            cb.MoveTo(60, yAxis - 5);
            cb.LineTo(450, yAxis - 5);
            cb.Stroke();
            cb.BeginText();
            //order title end
            yAxis -= 25;
            //order header
            cb.SetFontAndSize(boldCalibri, 12);
            cb.SetTextMatrix(62, yAxis);
            cb.ShowText("ID");
            cb.SetTextMatrix(180, yAxis);
            cb.ShowText("Time of order");
            cb.SetTextMatrix(400, yAxis);
            cb.ShowText("Total Sales");
            //order header end
            yAxis -= 20;
            //order data
            cb.SetFontAndSize(calibri, 12);
            foreach (Receipt sales in dailySales)
            {
                cb.SetTextMatrix(62, yAxis);
                cb.ShowText(sales.Id.ToString());
                cb.SetTextMatrix(180, yAxis);
                cb.ShowText(sales.DatePrinted.TimeOfDay.ToString());
                cb.SetTextMatrix(400, yAxis);
                cb.ShowText("RM" + sales.Total.ToString());
                yAxis -= 15;
                
                if (yAxis <= 50)
                {
                    //generate new header for following page
                    cb.EndText();
                    doc.NewPage();
                    cb.BeginText();
                    cb.SetFontAndSize(boldCalibri, 12);
                    cb.SetTextMatrix(60, yAxis);
                    yAxis = 780;
                    cb.SetTextMatrix(62, yAxis);
                    cb.ShowText("ID");
                    cb.SetTextMatrix(180, yAxis);
                    cb.ShowText("Time of order");
                    cb.SetTextMatrix(400, yAxis);
                    cb.ShowText("Total Sales");
                    cb.SetFontAndSize(calibri, 12);
                    yAxis -= 20;
                }
            }         
            //order data end
            yAxis -= 40;
            //tax, service charge, revenue and grand total
            cb.SetTextMatrix(400, yAxis);
            cb.ShowText("Grand Total:    RM" + calculateGrandTotal().ToString());
            yAxis -= 15;
            cb.SetTextMatrix(386, yAxis);
            cb.ShowText("Service Charge:  - RM" + calculateTotalServiceTax().ToString());
            yAxis -= 15;
            cb.SetTextMatrix(439, yAxis);
            cb.ShowText("GST:  - RM" + calculateTotalTax().ToString());
            yAxis -= 20;
            cb.SetFontAndSize(boldCalibri, 16);
            cb.SetTextMatrix(362, yAxis);
            cb.ShowText("Total Revenue:   RM" + calculateTotalRevenue().ToString());
            yAxis -= 15;          

            cb.EndText();            

            doc.Close();
            MessageBox.Show("Pdf Created Successfully");
        }

        private void SalesList_OnDoubleClick(object sender, EventArgs e)
        {
            if (SalesList.SelectedItems.Count > 0)
            {
                var selectedSale = (Receipt)SalesList.SelectedItems[0].Tag;
                Program.LoadSalesReportDetails(selectedSale);
            }
            else
            {
                return;
            }
        }
    }
}
