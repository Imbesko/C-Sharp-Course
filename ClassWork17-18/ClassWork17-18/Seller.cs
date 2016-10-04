using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17_18
{
    class Seller : Employee
    {
        int numberOfSales;

        public Seller(string PIB, int age, int salary, int numbOfSales) : base (PIB, age, salary)
        {
            numberOfSales = numbOfSales;
  
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Number of sales: {0}",numberOfSales);
        }
        public override void IncSalary()
        {
            empSalary += 100;
        }

        public new void DoNothing()
        {
            Console.WriteLine("Nothing from Seller...");
        }
    }
}
