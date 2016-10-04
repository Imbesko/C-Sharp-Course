using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            while (isOn)
            {
                Console.Clear();
                Console.WriteLine("\nHello! Please enter 0 if you want to stop.\n1 - create computer\n2 - create smartphone\n3 - create server");
                switch(Console.ReadLine())
                {
                    case "1":
                        PersonalComputer pc = new PersonalComputer("ASUS", "Andrew", "On", "Notebook", 1100f);
                        pc.ShowInfo();
                        break;
                    case "2":
                        Smartphone smart = new Smartphone("Lenovo", "Andrew", "OFF", 200f);
                        smart.ShowInfo();
                        break;
                    case "3":
                        Server server = new Server("Intel", "Ostap", "On", 2300f, 5);
                        server.ShowInfo();
                        break;
                    default:
                        isOn = false;
                        break;
                }                
                Console.ReadLine();
            }
        }
    }
}
