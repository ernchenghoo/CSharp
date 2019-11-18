using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.Model
{
    public class FoodStock
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Boolean AllowSendEmail { get; set; }
        public byte [] Image { get; set; }

        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        // constructor for existing object in database
        public FoodStock(int id, String name,String category, int quantity, decimal price, bool allowSendEmail,Byte[] image)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Quantity = quantity;
            this.AllowSendEmail = allowSendEmail;
            this.Image = image;
        }

        //constructor for new object which doesn't need id 
        //id will be generated automatically when you call save() function
        public FoodStock(String name,String category, int quantity, decimal price, bool allowSendEmail,Byte[] image)
        {
            this.Id = -1;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Quantity = quantity;
            this.AllowSendEmail = allowSendEmail;
            this.Image = image;
        }

        public FoodStock(int id,int quantity)
        {
            this.Id = id;
            this.Quantity = quantity;
        }

        public FoodStock(int id, bool allowSendEmail)
        {
            this.Id = id;
            this.AllowSendEmail = allowSendEmail;
        }

        //method for saving object into database
        public void Save()
        {
            try
            {
                //if id is equal negative 1 that means its a new object
                //because you create object using constructor without passing parameter id
                if (Id == -1)
                {
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand("select COUNT(foodstock.foodId),Max(foodstock.foodId) from foodstock", cnn);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    int currentBiggestId = -1;
                    while (dataReader.Read())
                    {
                        if (dataReader.GetInt32(0) == 0)
                        {
                            currentBiggestId = 0;
                        }
                        else
                        {
                            currentBiggestId = dataReader.GetInt32(1);
                        }
                    }
                    cnn.Close();

                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    int newId = currentBiggestId + 1;
                    command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "Insert into FoodStock(foodId,foodName,category,quantity,price,allowSendEmail,image) Values(@foodid,@foodname,@category,@quantity,@price,@allowsendemail,@image)";
                    command.Parameters.AddWithValue("@foodid", newId);
                    command.Parameters.AddWithValue("@foodname", Name);
                    command.Parameters.AddWithValue("@category", Category);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@price", Price);
                    command.Parameters.AddWithValue("@allowsendemail", AllowSendEmail);
                    command.Parameters.Add(new MySqlParameter("@image", Image));
                    command.ExecuteNonQuery();
                    cnn.Close();

                    this.Id = newId;
                }
                else
                {
                    //update the record
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE FoodStock SET FoodName=@foodname,category=@category,quantity=@quantity,price=@price,allowsendemail=@allowsendemail,image=@image  WHERE foodId =@id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@foodname", Name);
                    command.Parameters.AddWithValue("@category", Category);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@price", Price);
                    command.Parameters.AddWithValue("@allowsendemail", AllowSendEmail);
                    command.Parameters.Add(new MySqlParameter("@image", Image));
                    command.ExecuteNonQuery();
                    cnn.Close();

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.ToString());
            }
        }

        public static FoodStock FindById(int id)
        {
            cnn = new MySqlConnection(connectionString);
            FoodStock foundFoodStockObject = null;

            try
            {
                cnn.Open();
                

                MySqlCommand command = new MySqlCommand("select foodId,foodName,category,quantity,price,allowSendEmail,image from foodstock where foodId = "+id, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foundFoodStockObject = new FoodStock(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetDecimal(4), dataReader.GetBoolean(5), (byte[])dataReader[6]);
                }
                cnn.Close();


            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            return foundFoodStockObject; ;
        }

        public void Delete()
        {
            try
            {
                //dalete the record
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = cnn;
                command.CommandText = "delete from FoodStock where foodId =@id";
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                cnn.Close();
             
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed");
                MessageBox.Show(e.ToString());
            }
        }

        public void AddStock()
        {
            try
            {
                //dalete the record
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = cnn;
                command.CommandText = "update FoodStock set Quantity=@quantity, allowsendemail=@allowsendemail where foodId =@id";
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@quantity", Quantity);
                command.Parameters.AddWithValue("@allowsendemail", AllowSendEmail);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed");
                MessageBox.Show(e.ToString());
            }
        }

        public void ValidToSendEmail()
        {
            try
            {
                //dalete the record
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = cnn;
                command.CommandText = "update FoodStock set allowSendEmail=@allowsendemail where foodId =@id";
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@allowsendemail", AllowSendEmail);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed");
                MessageBox.Show(e.ToString());
            }
        }


        public static List<FoodStock> GetFoodStocks()
        {
            cnn = new MySqlConnection(connectionString);
            List<FoodStock> foodlist = new List<FoodStock>();

            try
            {
                cnn.Open();

                MySqlCommand command = new MySqlCommand("select foodId,foodName,category,quantity,price,allowSendEmail,image from foodstock", cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foodlist.Add(new FoodStock(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetDecimal(4), dataReader.GetBoolean(5), (byte[])dataReader["Image"]));
                }
                cnn.Close();


            }
            catch(Exception e)
            {
                MessageBox.Show("Connection failed");
                Console.WriteLine(e.ToString());
            }
            return foodlist;
        }

        
    }
}

