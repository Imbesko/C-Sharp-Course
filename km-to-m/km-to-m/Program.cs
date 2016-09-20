using System;

namespace if_else_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float price_call = 30;
                float price_per_km = 5;
                float result;
                Console.Write("Enter the distance (km): ");
                float distance = float.Parse(Console.ReadLine());
                if (distance == -1) break;
                if (distance > 1) price_per_km += distance;
                result = price_per_km + price_call;
                Console.WriteLine("You have to pay {0} grn", result);
            }
        }
    }
}
