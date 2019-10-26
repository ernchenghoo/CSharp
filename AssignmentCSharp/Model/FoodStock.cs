using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Model
{
    class FoodStock
    {
        public int id;
        public String name;
        public int quantity;
        public decimal price;
        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        // constructor for existing object in database
        public FoodStock(int id, String name, int quantity, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        //constructor for new object which doesn't need id 
        //id will be generated automatically when you call save() function
        public FoodStock(String name, int quantity, decimal price)
        {
            this.id = -1;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        //method for saving object into database
        public void save()
        {
            try
            {
                //if id is equal negative 1 that means its a new object
                //because you create object using constructor without passing parameter id
                if (id == -1)
                {
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "Insert into FoodStock(FoodName,quantity,price) Values(@foodname,@quantity,@price)";
                    command.Parameters.AddWithValue("@foodname", name);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();
                }
                else
                {
                    //update the record
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE FoodStock SET FoodName=@foodname,quantity=@quantity,price=@price WHERE foodId =@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@foodname", name);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();

                }
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
        }

        public static FoodStock findById(int id)
        {
            cnn = new MySqlConnection(connectionString);
            FoodStock foundFoodStockObject = null;

            try
            {
                cnn.Open();

                MySqlCommand command = new MySqlCommand("select foodId,foodName,quantity,price from foodstock where foodId = "+id, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foundFoodStockObject = new FoodStock(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetDecimal(3));
                }
                cnn.Close();


            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            return foundFoodStockObject; ;
        }

        public static List<FoodStock> getFoodStocks()
        {
            cnn = new MySqlConnection(connectionString);
            List<FoodStock> foodlist = new List<FoodStock>();

            try
            {
                cnn.Open();

                MySqlCommand command = new MySqlCommand("select foodId,foodName,quantity,price from foodstock", cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foodlist.Add(new FoodStock(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetDecimal(3)));
                }
                cnn.Close();


            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            return foodlist;
        }

        
    }
}

