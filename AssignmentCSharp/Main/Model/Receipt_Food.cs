using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCSharp.Main.Model
{
    public class Receipt_Food
    {
        public int ReceiptId { get; set; }
        public int FoodId { get; set; }
        public String FoodName{get; set;}
        public decimal FoodPrice { get; set; }
        public int QuantityOrdered { get; set; }
        public bool IsDone { get; set; }
        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        public Receipt_Food(int receiptId, int foodId, String foodName, decimal foodPrice, int quantity, bool isDone)
        {
            this.ReceiptId = receiptId;
            this.FoodId = foodId;
            this.FoodName = foodName;
            this.FoodPrice = foodPrice;
            this.QuantityOrdered = quantity;
            this.IsDone = isDone;
        }

        //constructor without the need of receiptid so that receipt will pass its id when save() is called
        public Receipt_Food(int foodId, String foodName, decimal foodPrice, int quantity)
        {
            this.ReceiptId = -1;
            this.FoodId = foodId;
            this.FoodName = foodName;
            this.FoodPrice = foodPrice;
            this.QuantityOrdered = quantity;
            this.IsDone = false;
        }

        public void save()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = cnn;
                command.CommandText = "UPDATE Receipt_Food SET quantityOrdered=@quantityOrdered,isDone=@isDone,foodprice=@foodprice,foodname=@foodname where receiptid=@receiptid and foodid=@foodid";
                command.Parameters.AddWithValue("@receiptid", this.ReceiptId);
                command.Parameters.AddWithValue("@foodid", this.FoodId);
                command.Parameters.AddWithValue("@foodname", this.FoodName);
                command.Parameters.AddWithValue("@foodprice", this.FoodPrice);
                command.Parameters.AddWithValue("@quantityOrdered", this.QuantityOrdered);
                command.Parameters.AddWithValue("@isDone", this.IsDone);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Error saving food to receipt!");
            }            
        }
        public void save(int receiptId)
        {
            this.ReceiptId = receiptId;
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = cnn;
                command.CommandText = "INSERT INTO Receipt_Food(receiptid,foodid,foodname,foodprice,quantityOrdered,isDone) VALUES(@receiptid,@foodid,@foodname,@foodprice,@quantityOrdered,@isDone)";
                command.Parameters.AddWithValue("@receiptid", this.ReceiptId);
                command.Parameters.AddWithValue("@foodid", this.FoodId);
                command.Parameters.AddWithValue("@foodname", this.FoodName);
                command.Parameters.AddWithValue("@foodprice", this.FoodPrice);
                command.Parameters.AddWithValue("@quantityOrdered", this.QuantityOrdered);
                command.Parameters.AddWithValue("@isDone", this.IsDone);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving food to receipt!");
            }
        }
    }
}
