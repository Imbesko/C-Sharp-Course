using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the task (1-3): ");
            byte choose = byte.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.Write("Enter the size of array: ");
                int size = int.Parse(Console.ReadLine());
                int[,] arr = new int[size, size];
                
                Console.WriteLine("Enter the array:");
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        arr[i, j] = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        Console.Write(arr[i, j] + " ");
                    Console.WriteLine();
                }

                int sumMain = 0, sumLateral = 0;
                // головна діагональ
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        if (i == j) sumMain += arr[i, j];
                // бічна діагональ
                for (int i = 0; i < size; i++)
                    sumLateral += arr[i, size - 1 - i];

                Console.WriteLine("Sum of main diagonal is: {0}\nSum of lateral diagonal is: {1}", sumMain, sumLateral);
            }
            if (choose == 2)
            {
                Console.WriteLine("Enter the string: ");
                string str = Console.ReadLine();
                char[] ch = str.ToCharArray();
                int count = 0;
                for (int i = 0, j = ch.Length - 1; i < ch.Length / 2; i++, j--)
                    if (ch[i] == ch[j]) count++;
                if (count == (ch.Length / 2)) Console.WriteLine("This string is palindrom.");
                else Console.WriteLine("This string is not palindrom");
            }

            if (choose == 3)
            { 
                Random rand = new Random();
                int size = rand.Next(2,7);
                int[,] arr1 = new int[size, size];
                int[,] arr2 = new int[size, size];
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        arr1[i, j] = rand.Next(1, 7);
                        arr2[i, j] = rand.Next(1, 7);
                    }
                Console.WriteLine("\nFirst array:");
                PrintAr(arr1, size);
                Console.WriteLine("\nSecond array:");
                PrintAr(arr2,size);
                int count = 0;
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        if (arr1[i, j] == arr2[i, j]) count++;
                if (count != 0) Console.WriteLine("Two arrays similar to {0}%.", 100 * count / (size * 2));
                else Console.WriteLine("Two arrays similar to 0%.");

            }
        }
        static void PrintAr(int[,] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
