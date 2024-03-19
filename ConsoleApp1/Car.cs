using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        public int maxSpeed = 200;

        // Method
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        // Constructor
        public Car(string modelName, string colorName, int year, int maxSpeed)
        {
            model = modelName;
            color = colorName;
            year = year;
            maxSpeed = maxSpeed;

        }
    }
}
