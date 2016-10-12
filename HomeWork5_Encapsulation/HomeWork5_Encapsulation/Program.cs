using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the task(1-3): ");
            byte choose = byte.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Student std = new Student();
                std.PrintInfo();

                Student std1 = new Student("George", "Shevchenka 9");
                std1.PrintInfo();

                Student std2 = new Student(null, "Moris", "Shaytana 20");
                std2.PrintInfo();

                Student std3 = new Student(std2);
                std3.PrintInfo();
            }
            if (choose == 2)
            {
                Random rand = new Random();
                Runner[] arr = new Runner[3];
                for (int i = 0; i < arr.Length; i++)
                {
                    string name = "Runner " + i;
                    double time = rand.NextDouble() + rand.Next(0, 20);                    
                    arr[i] = new Runner(name, (float)time);
                }             
                for (int i = 0; i < arr.Length; i++)                
                    arr[i].PrintRunner();                    
                
                float min = arr[0].Time;
                int minIndex = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i].Time < min)
                    {
                        min = arr[i].Time;
                        minIndex = i;
                    }
                }

                Console.WriteLine("\n\nFastest runner:");
                arr[minIndex].PrintRunner();
            }
            if (choose == 3)
            { 
                
            }
        }
    }
}
