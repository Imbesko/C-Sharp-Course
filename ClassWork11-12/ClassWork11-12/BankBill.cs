using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class BankBill
    {
        public long money;
        public string name;
        public long id;
        

        public static float stavka = 0.04f;

        public BankBill(string nameV = "Gave", long idV = 0, long moneyV = 0)
        {
            name = nameV;
            id = idV;
            money = moneyV;
            Console.WriteLine("Bill with id {0} was created.", id);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Bill id: {0}\nName: {1}\nAmount of money: ${2}\nStavka: {3}%", id, name, money, stavka);
        }
        public static void PrintInfoAboutBills()
        {
            Console.WriteLine("This bills were created on 10th lesson in IT Academy LOGOS. Version 18.6");
        }
    }
}
