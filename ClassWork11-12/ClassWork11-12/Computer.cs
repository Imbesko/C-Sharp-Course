using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class Computer
    {
        public string manufacturer;
        public string type;
        public bool isOn;
        public float price;

        public static int warranty;

        //public Computer() : this("Unknown", "Unknown", false) {
        //    Console.WriteLine("Simple Ctor");
        //}
        //public Computer(string name) : this (name, "Unknown", false) { }
        //public Computer(string name, string type) : this (name, type, false) { }

        public Computer(string name = "Unknown", string type = "Unknown", bool isOn = false)
        {
            manufacturer = name;
            this.type = type;
            this.isOn = isOn;
            Console.WriteLine("Main Ctor " + manufacturer);
        }
        

        public void PrintStatus()
        {
            Console.WriteLine("Manufacturer is " + manufacturer);
            Console.WriteLine("Computer is " + (isOn ? "ON" : "OFF."));  
        }

        static Computer()
        {
            warranty = 24;
        }
        public static void PrintWarranty()
        {
            Console.WriteLine("Warranty is: {0} month", warranty);
        }
    }
}
