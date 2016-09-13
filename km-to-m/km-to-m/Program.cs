using System;

namespace if_else_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                if (num1 == 'q') break;
                Console.Write("Enter the action: ");
                char act = char.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                float num2 = float.Parse(Console.ReadLine());
                switch (act)
                {
                    case '+': Console.WriteLine(num1 + num2); break;
                    case '-': Console.WriteLine(num1 - num2); break;
                    case '*': Console.WriteLine(num1 * num2); break;
                    case '/': Console.WriteLine(num1 / num2); break;
                    default: Console.WriteLine("Please, enter the correct action: "); break;
                }
                
            }
        }
    }
}
