﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Model
{
    public class FoodStock
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        // constructor for existing object in database
        public FoodStock(int id, String name,String category, int quantity, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Quantity = quantity;
        }

        //constructor for new object which doesn't need id 
        //id will be generated automatically when you call save() function
        public FoodStock(String name,String category, int quantity, decimal price)
        {
            this.Id = -1;
            this.Name = name;
            this.Category = category;
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
                    command.CommandText = "Insert into FoodStock(foodId,foodName,category,quantity,price) Values(@foodid,@foodname,@category,@quantity,@price)";
                    command.Parameters.AddWithValue("@foodid", newId);
                    command.Parameters.AddWithValue("@foodname", Name);
                    command.Parameters.AddWithValue("@category", Category);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@price", Price);
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
                    command.CommandText = "UPDATE FoodStock SET FoodName=@foodname,category=@category,quantity=@quantity,price=@price WHERE foodId =@id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@foodname", Name);
                    command.Parameters.AddWithValue("@category", Category);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@price", Price);
                    command.ExecuteNonQuery();
                    cnn.Close();

                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Connection failed");
                MessageBox.Show(e.ToString());
            }
        }

        public static FoodStock findById(int id)
        {
            cnn = new MySqlConnection(connectionString);
            FoodStock foundFoodStockObject = null;

            try
            {
                cnn.Open();
                

                MySqlCommand command = new MySqlCommand("select foodId,foodName,category,quantity,price from foodstock where foodId = "+id, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foundFoodStockObject = new FoodStock(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetDecimal(4));
                }
                cnn.Close();


            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            return foundFoodStockObject; ;
        }

        public void delete()
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


        public static List<FoodStock> getFoodStocks()
        {
            cnn = new MySqlConnection(connectionString);
            List<FoodStock> foodlist = new List<FoodStock>();

            try
            {
                cnn.Open();

                MySqlCommand command = new MySqlCommand("select foodId,foodName,category,quantity,price from foodstock", cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foodlist.Add(new FoodStock(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetDecimal(4)));
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
