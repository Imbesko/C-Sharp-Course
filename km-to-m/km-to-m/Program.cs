using System;

namespace km_to_m_converter
{
    class Program
    {
        static void Main(string[] args)
        {            
            String name, product1, product2, day;
            long orderNumber, orderNumber2;
            float price1, price2, priceTotal;

            Console.Write("Hello, barmen.\nEnter the name: ");
            name = Console.ReadLine();
            Console.Write("What is number order?: ");
            orderNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("What is the day of week today?: ");
            day = Console.ReadLine();
            Console.Write("What is the name of first product?: ");
            product1 = Console.ReadLine();
            Console.Write("What is product 1 price?: ");
            price1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("What is the name of second product?: ");
            product2 = Console.ReadLine();
            Console.Write("What is product 2 price?: ");
            price2 = float.Parse(Console.ReadLine());
            priceTotal = price1 + price2;
            Console.WriteLine("Hello "+ name + ". Today is "+ day);
            Console.WriteLine("Number of order: #{0}", orderNumber);
            Console.WriteLine("1. {0} \t {1}\n2. {2} \t {3}", product1, price1, product2, price2);
            Console.WriteLine("total: {0}".ToUpper(), priceTotal);            
            Console.ReadLine();
        }
    }
}
/*
 .Equals() - порівнює 2 стринга
 .Contains() - перевірка 
 .Compare() - 
 .Length() - довжина
 
 */
