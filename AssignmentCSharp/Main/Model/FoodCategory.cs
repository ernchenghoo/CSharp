using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.Model
{
    class FoodCategory
    {
        public int Id { get; set; }

        public String Category { get; set; }

        public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        public FoodCategory(int id, String category)
        {
            this.Id = id;
            this.Category = category;
        }

        public FoodCategory(String category)
        {
            this.Id = -1;
            this.Category = category;
        }

        public static List<FoodCategory> GetFoodCategory()
        {
            cnn = new MySqlConnection(connectionString);
            List<FoodCategory> foodCategoryList = new List<FoodCategory>();

            try
            {
                cnn.Open();

                MySqlCommand command = new MySqlCommand("select id,category from foodcategory", cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foodCategoryList.Add(new FoodCategory(dataReader.GetInt32(0), dataReader.GetString(1)));
                }
                cnn.Close();


            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            return foodCategoryList;
        }

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
                    MySqlCommand command = new MySqlCommand("select COUNT(foodcategory.id),Max(foodcategory.id) from foodcategory", cnn);
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
                    command.CommandText = "Insert into foodcategory(id,category) Values(@id,@category)";
                    command.Parameters.AddWithValue("@id", newId);
                    command.Parameters.AddWithValue("@category", Category);
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
                    command.CommandText = "UPDATE foodcategory SET category=@category WHERE id =@id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@category", Category);
                    command.ExecuteNonQuery();
                    cnn.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.ToString());
            }
        }

        public static FoodCategory FindById(int id)
        {
            cnn = new MySqlConnection(connectionString);
            FoodCategory foundFoodCategoryObject = null;

            try
            {
                cnn.Open();


                MySqlCommand command = new MySqlCommand("select id,category from foodcategory where id = " + id, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    foundFoodCategoryObject = new FoodCategory(dataReader.GetInt32(0), dataReader.GetString(1));
                }
                cnn.Close();


            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
            return foundFoodCategoryObject; ;
        }

    }
}
