using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork9_10
{
    class Program
    {
        static void Swap(ref int num1, ref int num2)
        {            
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sum1(int num1, int num2, int num3 = 0)
        {
            return num1 + num2 + num3;
        }
        static void printInfo(string name, int age)
        {
            Console.WriteLine(name + "; Age : " + age);
        }
        static string returnInfo(string name, int age)
        {
            return String.Format("{0}; Age: {1}", name, age); 
        }
        static void plusMinus(int num1, int num2, out int sum, out int minus)
        {
            sum = num1 + num2;
            minus = num1 - num2;
        }
        static void Sum2(out int sum, params int[] numbers)
        { 
            sum = 0;
            foreach (int num in numbers)
                sum += num;            
        }
        
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit == true)
            {
                Console.Write("Enter the f-st number: ");
                int number_1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the s-nd number: ");
                int number_2 = int.Parse(Console.ReadLine());
                int sum, minus;
                //Console.WriteLine("Sum0: " + Sum(number_1,number_2));               
                //Console.WriteLine("Sum1: " + Sum1(number_1, number_2, 100));
                //plusMinus(number_1,number_2, out sum, out minus);
                //Console.WriteLine("Sum of 2 numbers = " + sum);
                //Console.WriteLine("Subtraction of 2 numbers = " + minus);
                //Swap(ref number_1, ref number_2);
                //Console.WriteLine("num1 = {0}\nnum2 = {1}", number_1, number_2);
                int sum;
                Sum2(out sum, 5, 15);
                Console.WriteLine("Sum2: " + sum);
                Sum2(out sum, 5, 15, 20, 7);
                Console.WriteLine("Sum2: " + sum);
                Sum2(out sum, 5, 15, 8, 20);
                Console.WriteLine("Sum2: " + sum);


                Console.WriteLine("\n\nDo you want to do it once more?\n\t Y - yes, N - no");
                char quit = char.Parse(Console.ReadLine());
                if (quit == 'y' || quit == 'Y') exit = true;
                else if (quit == 'n' || quit == 'N') exit = false;
                else exit = true;
            }            
        }
    }
}
