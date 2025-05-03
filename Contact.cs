using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManger
{
    internal class Contact
    {
        public string  Name { get; set; }
        public string  Phone_Number { get; set; }
        public string  Email { get; set; }
        public Contact(string _Name, string _Phone_Number, string _Email) 
        
        { 
            Name = _Name;
            Phone_Number = _Phone_Number;
            Email = _Email;
        
        }
        public override string ToString() 
        {
            return $"Name: {Name} , Phone: {Phone_Number}, Email: {Email}";
        
        }



    }
}
