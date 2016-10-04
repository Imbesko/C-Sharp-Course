using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[,]
            {
                {5, 10, 13, -4, 10},
                {20, 2, 9, 9, -1},
                {5, 10, 4, 8, 14},
                {6, 1, 2, 6, 10},
                {95, 5, 10, 10, 2}
               };
            var b = new[,]
            {
                {5, 10, 8, -4, 62},
                {20, 2, 9, 9, -1},
                {5, 10, 1, 8, 1},
                {6, 1, 2, 6, -5},
                {95, 5, 1, 3, 2}
            };
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr[i, j] = a[i, j] * b[i, j];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
