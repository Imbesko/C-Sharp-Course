using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17_18
{
    class SellManager : Seller
    {
        // Fields
        int numberOfSlaves;

        // Constructor
        public SellManager(string PIB, int age, int salary, int numbOfSales, int numOfSlaves)
            : base(PIB, age, salary, numbOfSales)
        {
            numberOfSlaves = numOfSlaves;   
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Number of slaves: {0}", numberOfSlaves);
        }
    }
}
