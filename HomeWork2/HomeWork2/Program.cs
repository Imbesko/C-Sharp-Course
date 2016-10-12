using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            float pricePerCall = 30f;            
            float price = 0f;
            Console.Write("Enter the distance (km): ");
            float distance = float.Parse(Console.ReadLine());
            Console.Write("Day or night?  D - day,  N - night: ");
            char dn = char.Parse(Console.ReadLine());

            if (distance > 10 && distance <= 20) price = pricePerCall + (distance * 4);
            else if (distance > 20) price = pricePerCall + (distance * 3);
            else if (distance <= 10) price = pricePerCall + (distance * 5);

            if (dn == 'n' || dn == 'N') Console.WriteLine("Price of the fare: " + (price /= 2));
            else Console.WriteLine("Price of the fare: " + price);



        }
    }
}
