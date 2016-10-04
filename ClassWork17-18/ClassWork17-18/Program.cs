using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller sel1 = new Seller("Anton Seller2", 19, 1200, 36);
            sel1.PrintInfo();
            Console.WriteLine();

            SellManager selMg = new SellManager("Joe Bob manager", 22, 1600, 92, 3);
            selMg.PrintInfo();
            Console.WriteLine();



            PrintClassInfo(selMg);
            Console.WriteLine();

            //Sysadmin sys1 = new Sysadmin("Roger Sysadminko 1294", 56, 5000, "ASUS Zenbook 303");
            //sys1.PrintInfo();
            //sys1.IncSalary();
            //sys1.PrintInfo();

        }

        static void PrintClassInfo(Seller sel)
        {
            sel.PrintInfo();
        }
    }
}
