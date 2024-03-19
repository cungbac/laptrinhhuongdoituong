using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bird: Animal, IAnimalFly, IAnimalSound
    {
        public void sound()
        {
            Console.WriteLine("Bird sound");
        }
        public void fly()
        {
            Console.WriteLine("Bird fly");
        }
    }
}
