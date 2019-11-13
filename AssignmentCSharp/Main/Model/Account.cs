using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.Model
{
    public class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int AccountID { get; set; }
        public int TypeID { get; set; }

        public Account(string usnm, string pwd, int accID, string role)
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            TypeID = RoleToID(role);
        }

        public Account(string usnm, string pwd, int accID, int role) //overloaded constructor
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            TypeID = role;
        }

        private int RoleToID(string accType)
        {
            int typeID = 0;
            switch (accType)
            {

                case "Stock Keeper":
                    typeID = 2;
                    break;
                case "Kitchen Staff":
                    typeID = 3;
                    break;
                case "Cashier":
                    typeID = 4;
                    break;
            }
            return typeID;
        }

        public string IDToRole()
        {
            string typeName = "";
            switch (TypeID)
            {
                case 1:
                    typeName = "Admin";
                    break;
                case 2:
                    typeName = "Stock Keeper";
                    break;
                case 3:
                    typeName = "Kitchen Staff";
                    break;
                case 4:
                    typeName = "Cashier";
                    break;
            }
            return typeName;
        }
    }    
}
