using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp
{
    class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int AccountID { get; set; }
        public int TypeID { get; set; }

        public Account (string usnm, string pwd, int accID, int typID)
        {
            Email = usnm;
            Password = pwd;
            AccountID = accID;
            TypeID = typID;
        }
    }
}
