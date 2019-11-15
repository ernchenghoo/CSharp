using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AssignmentCSharp.Main.Model
{
    public class Receipt
    {
        public int Id{get; set;}
        public DateTime DatePrinted { get; set; }
        public decimal Tax { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal Total { get; set; }
        public List<Receipt_Food> FoodOrdered { get; set; }

        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        public Receipt(int id,DateTime datePrinted, decimal tax, decimal serviceTax, decimal total,List<Receipt_Food> foodOrdered)
        {
            this.Id = id;
            this.DatePrinted = datePrinted;
            this.Tax = tax;
            this.ServiceTax = serviceTax;
            this.Total = total;
            this.FoodOrdered = foodOrdered;
        }

        //constructor without id so that when u call save() the id will be generated
        public Receipt(decimal tax, decimal serviceTax, decimal total, List<Receipt_Food> foodOrdered)
        {
            this.Id = -1;
            this.DatePrinted = DateTime.Now;
            this.Tax = tax;
            this.ServiceTax = serviceTax;
            this.Total = total;
            this.FoodOrdered = foodOrdered;
        }

        public void Save()
        {
            try
            {
                //if ID equal -1 means it is a new record
                if(Id == -1)
                {
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();

                    MySqlCommand command = new MySqlCommand("select COUNT(receipt.id),MAX(receipt.id) from receipt", cnn);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    int currentBiggestId = -1;
                    while (dataReader.Read())
                    {
                        if(dataReader.GetInt32(0) == 0)
                        {
                            currentBiggestId = 0;
                        }
                        else
                        {
                            currentBiggestId = dataReader.GetInt32(1);
                        }
                        
                    }
                    cnn.Close();
                    
                    //****************** Saving new receipt***********************
                    int newId = currentBiggestId + 1;
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "Insert into Receipt(id,datePrinted,tax,servicetax,total) VALUES(@id,@dateprinted,@tax,@servicetax,@total)";
                    command.Parameters.AddWithValue("@id", newId);
                    command.Parameters.AddWithValue("@dateprinted", this.DatePrinted.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@tax", this.Tax);
                    command.Parameters.AddWithValue("@servicetax", this.ServiceTax);
                    command.Parameters.AddWithValue("@total", this.Total);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    this.Id = newId;

                    //***************save food order list*******************
                    foreach(Receipt_Food food in FoodOrdered)
                    {
                        //pass receipt id to indicate this food record belongs to this receipt
                        food.Save(this.Id);
                    }
                }
                else
                {
                    //****************** Saving new receipt***********************
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE Receipt SET datePrinted=@dateprinted,tax=@tax,servicetax=@servicetax,total=@total where id=@id";
                    command.Parameters.AddWithValue("@id", this.Id);
                    command.Parameters.AddWithValue("@dateprinted", this.DatePrinted.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@tax", this.Tax);
                    command.Parameters.AddWithValue("@servicetax", this.ServiceTax);
                    command.Parameters.AddWithValue("@total", this.Total);
                    command.ExecuteNonQuery();
                    cnn.Close();

                    //***************save food order list*******************
                    foreach (Receipt_Food food in FoodOrdered)
                    {
                        //pass receipt id to indicate this food record belongs to this receipt
                        food.Save();
                    }

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving food to receipt!"+ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
        public static Receipt FindById(int id)
        {
            cnn = new MySqlConnection(connectionString);
            Receipt foundReceiptObject = null;

            try
            {
                cnn.Open();


                MySqlCommand command = new MySqlCommand("select id,datePrinted,tax,servicetax,total from receipt where id = " + id, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    //get receipt food
                    List<Receipt_Food> foodList = new List<Receipt_Food>();
                    MySqlConnection foodcon = new MySqlConnection(connectionString);
                    foodcon.Open();
                    MySqlCommand getFoodOrder = new MySqlCommand("select receiptid,foodid,foodname,foodprice,quantityOrdered,isDone from receipt_food where receiptid=" + id, foodcon);
                    MySqlDataReader foodOrderDataReader = getFoodOrder.ExecuteReader();
                    while (foodOrderDataReader.Read())
                    {
                        foodList.Add(new Receipt_Food(foodOrderDataReader.GetInt32(0), foodOrderDataReader.GetInt32(1), foodOrderDataReader.GetString(2), foodOrderDataReader.GetDecimal(3), foodOrderDataReader.GetInt32(4), foodOrderDataReader.GetBoolean(5)));
                    }
                    foodcon.Close();
                    foundReceiptObject = new Receipt(dataReader.GetInt32(0), dataReader.GetDateTime(1),dataReader.GetDecimal(2),dataReader.GetDecimal(3),dataReader.GetDecimal(4),foodList);
                }
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return foundReceiptObject; ;
        }

        public static List<Receipt> GetReceipts()
        {
            List<Receipt> receiptList = new List<Receipt>();

            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();


                MySqlCommand command = new MySqlCommand("select id,datePrinted,tax,servicetax,total from receipt ORDER BY datePrinted Asc", cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    //get receipt food
                    List<Receipt_Food> foodList = new List<Receipt_Food>();
                    MySqlConnection foodCon = new MySqlConnection(connectionString);
                    foodCon.Open();
                    MySqlCommand getFoodOrder = new MySqlCommand("select receiptid,foodid,foodname,foodprice,quantityOrdered,isDone from receipt_food where receiptid="+dataReader.GetInt32(0), foodCon);
                    MySqlDataReader foodOrderDataReader = getFoodOrder.ExecuteReader();
                    while (foodOrderDataReader.Read())
                    {
                        foodList.Add(new Receipt_Food(foodOrderDataReader.GetInt32(0), foodOrderDataReader.GetInt32(1), foodOrderDataReader.GetString(2), foodOrderDataReader.GetDecimal(3),foodOrderDataReader.GetInt32(4),foodOrderDataReader.GetBoolean(5)));
                    }
                    foodCon.Close();

                    receiptList.Add(new Receipt(dataReader.GetInt32(0), dataReader.GetDateTime(1), dataReader.GetDecimal(2), dataReader.GetDecimal(3), dataReader.GetDecimal(4), foodList));
                }
                cnn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            return receiptList;
        }

    }
}
