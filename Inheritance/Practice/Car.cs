using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Car
    {
        public string brand;
        public int _horsePower;
        public readonly int speed;

        public Car()
        {
            speed = 500;
        }
      
        // Encapsulation
        public int HorsePower 
        {
            get
            {
                if (_horsePower < 150)
                {
                    Console.WriteLine("Can't drive");
                    return -1;
                }

                return _horsePower;
            }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Please set correct power");
                    return;
                }
                _horsePower = value;
            }
        }
    }
}
