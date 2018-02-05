using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        private string name;
        private string address;

        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {
            Name = "not provided";
            Address = "not provided";
        }

        public Person(string pName, string pAddress)
        {
            Name = pName;
            Address = pAddress;
        }

        public override string ToString()
        {
            return $"This person's name is {Name} and their address is {Address}";
        }
    }
}
