using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork7_8
{
    class Program
    {
        static void printArr(int[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit == true)
            {
                Console.Write("Enter the task (1-3): ");
                short task = short.Parse(Console.ReadLine());
                if (task == 1)
                {
                    int row, col;
                    Console.Write("Enter the rows of array: ");
                    row = int.Parse(Console.ReadLine());
                    Console.Write("Enter the columns of array: ");
                    col = int.Parse(Console.ReadLine());
                    int[,] arr = new int[row, col];
                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write("Enter the {0} row and {1} column: ", i, j);
                            arr[i, j] = int.Parse(Console.ReadLine());
                        }
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                            Console.Write(arr[i, j] + " ");
                        Console.WriteLine();
                    }
                    int firstDiagonal = 0, secondDiagonal = 0;
                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < col; j++)
                            if (i == j) firstDiagonal += arr[i, j];
                    for (int i = row; i >= 0; i--)
                        for (int j = 0; j < col; j++)
                            if (i == j) secondDiagonal += arr[i, j];
                    Console.WriteLine("Sum of first diagonal = " + firstDiagonal);
                    Console.WriteLine("Sum of first diagonal = " + firstDiagonal);
                }
                else if (task == 2)
                {
                    Console.Write("Enter the string: ");
                    string str = Convert.ToString(Console.ReadLine());
                    int count = 0, leng = str.Length-1;
                    for (int i = 0; i < leng+1; i++, leng--)
                        if (str[i] == str[leng]) count++;
                    if (count == ((str.Length+1) / 2)) Console.Write("This string is palindrom word.");
                    else Console.Write("This string is not palindrom word.");
                            
                }
                else if (task == 3)
                {
                    Random rand = new Random();
                    int[,] arr1 = new int[5, 5];
                    int[,] arr2 = new int[5, 5];
                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            arr1[i, j] = rand.Next(1, 5);
                            arr2[i, j] = rand.Next(1, 5);
                        }
                    printArr(arr1);
                    Console.WriteLine();
                    printArr(arr2);
                    int count = 0;
                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                            if (arr1[i, j] == arr2[i, j]) count++;
                    Console.Write("\nСхожість двох масивів складає " + (count / 25 * 100));                
                }

                Console.WriteLine("\n\nDo you want to do it once more?\n\t Y - yes, N - no");
                char quit = char.Parse(Console.ReadLine());
                if (quit == 'y' || quit == 'Y') exit = true;
                else exit = false;
            }
        }
    }
}
