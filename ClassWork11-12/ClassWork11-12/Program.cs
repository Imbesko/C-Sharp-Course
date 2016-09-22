using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Classes;

namespace OOP_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;
            while (quit == true)
            {
                Computer myComp = new Computer("ASUS", "Ultrabook", true);
                Computer logosComp = new Computer("Samsung", "PC", false);
                Computer petroComp = new Computer("HP");
                myComp.PrintStatus();
                logosComp.PrintStatus();
                petroComp.PrintStatus();
                Computer.PrintWarranty();

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Random rand = new Random();
                long id = rand.Next(111111111, 999999999);
                Console.Write("Please enter amount of your money in $");
                long money = long.Parse(Console.ReadLine());

                BankBill bill1 = new BankBill(name, id, money);
                bill1.PrintInfo();

                BankBill.stavka = 0.08f;
                bill1.PrintInfo();

                BankBill.PrintInfoAboutBills();


                Console.Write("\n\nDo you want to do it again?\n\tY - Yes, N - No: ");
                char yn = char.Parse(Console.ReadLine());
                if (yn == 'n' || yn == 'N') quit = false;
                else quit = true;
            }

        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }
    }

}
