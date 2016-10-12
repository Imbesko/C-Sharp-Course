using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the task 1 or 2: ");
            byte choose = byte.Parse(Console.ReadLine());
            if (choose == 1)
            {
                int average = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter the " + (i + 1) + " evaluation: ");
                    int eval = int.Parse(Console.ReadLine());
                    average += eval;
                }
                Console.WriteLine("Average is " + average / 3);
            }
            if (choose == 2)
            {
                Console.Write("Enter the radius: ");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Length range is: " + (2 * 3.14 * radius));
            }
        }
    }
}
