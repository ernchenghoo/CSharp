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
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        // constructor for existing object in database
        public FoodStock(int id, String name, int quantity, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        //constructor for new object which doesn't need id 
        //id will be generated automatically when you call save() function
        public FoodStock(String name, int quantity, decimal price)
        {
            this.Id = -1;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        //method for saving object into database
        public void save()
        {
            try
            {
                //if id is equal negative 1 that means its a new object
                //because you create object using constructor without passing parameter id
                if (Id == -1)
                {
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand("select COUNT(foodstock.id) from foodstock", cnn);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    int currentBiggestId = -1;
                    while (dataReader.Read())
                    {
                        currentBiggestId = dataReader.GetInt32(0);
                    }

                    int newId = currentBiggestId + 1;
                    command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "Insert into FoodStock(foodId,foodName,quantity,price) Values(@foodid,@foodname,@quantity,@price)";
                    command.Parameters.AddWithValue("@foodid", newId);
                    command.Parameters.AddWithValue("@foodname", Name);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@price", Price);
                    command.ExecuteNonQuery();

                    this.Id = newId;
                }
                else
                {
                    //update the record
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE FoodStock SET FoodName=@foodname,quantity=@quantity,price=@price WHERE foodId =@id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@foodname", Name);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@price", Price);
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

