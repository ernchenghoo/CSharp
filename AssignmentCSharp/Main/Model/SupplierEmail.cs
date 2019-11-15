using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AssignmentCSharp.Main.Model
{
    class SupplierEmail
    {
        public int SupplierId { get; set; }
        public String CompanyName { get; set; }
        public String Email { get; set; }
        public String ContactPerson { get; set; }

        //public static MySqlConnection cnn;
        public static string connectionString = "server=localhost;database=pos;uid=root;pwd=;";

        public SupplierEmail(int supplierId,String companyName,String email, String ContactPerson)
        {
            this.SupplierId = supplierId;
            this.CompanyName = companyName;
            this.Email = email;
            this.ContactPerson = ContactPerson;
        }


    }
}
