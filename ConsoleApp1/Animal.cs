using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Name { get; set; }
    }
    public interface IAnimalSound
    {
        void sound();
    }
    public interface IAnimalRun
    {
        void run();
        void walk();
    }
    public interface IAnimalFly
    {
        void fly();
    }
}
