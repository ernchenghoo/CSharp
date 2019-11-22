using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp.Main.Model
{
    public class AccountType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public AccountType(int id, string name)
        {
            ID = id;
            Name = name;
        }       
    }
}
