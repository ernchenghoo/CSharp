using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCSharp.Model
{
    public class Receipt_Food
    {
        public int ReceiptId { get; set; }
        public FoodStock Food { get; set; }
        public int Quantity { get; set; }
        public bool IsDone { get; set; }
        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        public Receipt_Food(int receiptId, int foodid, int quantity, bool isDone)
        {
            this.ReceiptId = receiptId;
            this.Food = FoodStock.findById(foodid);
            this.Quantity = quantity;
            this.IsDone = isDone;
        }

        //constructor without the need of receiptid so that receipt will pass its id when save() is called
        public Receipt_Food(int foodid, int quantity)
        {
            this.ReceiptId = -1;
            this.Food = FoodStock.findById(foodid);
            this.Quantity = quantity;
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
                command.CommandText = "UPDATE Receipt_Food SET quantity=@quantity,isDone=@isDone where receiptid=@receiptid and foodid=@foodid";
                command.Parameters.AddWithValue("@receiptid", this.ReceiptId);
                command.Parameters.AddWithValue("@foodid", this.Food.Id);
                command.Parameters.AddWithValue("@quantity", this.Quantity);
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
                command.CommandText = "INSERT INTO Receipt_Food(receiptid,foodid,quantity,isDone) VALUES(@receiptid,@foodid,@quantity,@isDone)";
                command.Parameters.AddWithValue("@receiptid", this.ReceiptId);
                command.Parameters.AddWithValue("@foodid", this.Food.Id);
                command.Parameters.AddWithValue("@quantity", this.Quantity);
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
