using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog: Animal, IAnimalRun, IAnimalSound
    {
        public void run()
        {
            Console.WriteLine("Dog run");
        }
        public void walk()
        {
            Console.WriteLine("Dog walk");
        }
        public void sound()
        {
            Console.WriteLine("Dog sound");
        }
    }
}
