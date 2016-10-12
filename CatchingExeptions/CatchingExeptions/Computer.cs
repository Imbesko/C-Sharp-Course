using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingExceptions
{
    class Computer
    {
        private float temp;
        public string Name { get; set; }

        public Computer()
        {
            Name = "No-name";
            temp = 0f;
        }

        public Computer(string name, float compTemp)
        {
            Name = name;
            temp = compTemp;
        }

        public void incTemp()
        {
            temp += 10f;
            Console.WriteLine("Current temp of {0} is {1}", Name, temp);
            if (temp > 80)
            {
                 Exception e = new Exception("Computer is broken.");
                 e.HelpLink = "http://microsoft.com";
                 e.Source = "Catching Exceptions by Logos Academy. c"; // в якому проекті помилка
                 throw e;
            }
        }
    }
}
