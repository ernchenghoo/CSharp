using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Model
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

        public static List<FoodCategory> getFoodCategory()
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

    }
}
