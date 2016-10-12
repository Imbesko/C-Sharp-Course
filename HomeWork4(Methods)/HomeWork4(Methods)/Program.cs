using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_10
{
    class Program
    {
        static void createArr(int[] arr, int size)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 10);
        }
        static void printArr(int[] arr, int size)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        static int indexOfArray(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == number) return i;
            return -1;
        }
        static void SumOrStr(string str, params int[] numb)
        {
            int sum = 0;
            foreach (int num in numb)
                sum += num;
            if (sum > 20) Console.Write(str);
            else Console.Write("Sorry, but sum = " + sum);
        }
        static void createTwoDimArr(int[][] arr, int row)
        {
            Random rand = new Random();
            int count = 0;
            for (int i = 0; i < row; i++)
            {
                arr[i] = new int[rand.Next(2, 8)];
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = ++count;
            }
        }
        static void printTwoDimArr(int[][] arr, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            bool quit = true;
            Random rand = new Random();
            while (quit == true)
            {
                Console.Write("Enter the task (1-3): ");
                short task = short.Parse(Console.ReadLine());
                if (task == 1)
                {
                    Console.Write("Enter the size of array: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.Write("Enter the number, which you want to find: ");
                    int number = int.Parse(Console.ReadLine());
                    createArr(arr, size);
                    Console.WriteLine("result: " + indexOfArray(arr, number));
                    printArr(arr, size);
                }
                if (task == 2)
                {
                    Console.Write("Enter the string: ");
                    string str = Convert.ToString(Console.ReadLine());
                    int size = rand.Next(2, 6);
                    int[] arr = new int[size];
                    createArr(arr, size);
                    SumOrStr(str, arr);
                }
                if (task == 3)
                {
                    int row = rand.Next(2, 8);
                    int[][] arr = new int[row][];
                    createTwoDimArr(arr, row);
                    printTwoDimArr(arr, row);
                }

                Console.Write("\n\nDo you want to do it once more?:\n\tY - yes, N - no: ");
                char yn = char.Parse(Console.ReadLine());
                if (yn == 'y' || yn == 'Y') quit = true;
                else if (yn == 'n' || yn == 'N') quit = false;
                else quit = true;
            }
        }
    }
}
