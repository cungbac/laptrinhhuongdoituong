using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;
        private string maritalStatus;
        public string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public int Age
        { get; set; }
    }
}
