using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Interface_Collections_
{
    class Program
    {
        static bool Check(string symbols)
        {
            Stack<char> stack = new Stack<char>();
            int count = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                char ch = (char)symbols[i];
                if (ch == '1') count++;
            }
            if (count % 2 == 0) return true;
            return false;
        }
        static bool Symetric(string symb)
        {
            Stack<string> symetric = new Stack<string>();
            char[] sideToZero = new char[symb.Length];
            for (int i = 0; i < symb.Length; i++)
            {
                char ch = (char)symb[i];
                sideToZero[i] = ch;
                if (ch == '0') break;
            }
            for (int i = symb.Length - 1, j = 0; i >= symb.Length / 2; i--, j++)
                if (sideToZero[j] != (char)symb[i]) return false;
            return true;
        }

        static void Main(string[] args)
        {
            bool quit = true;
            while (quit == true)
            {
                Console.Write("Enter the taks (1-3), 0 - exit: ");

                byte choose = byte.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    Console.Write("Please, enter your code: ");
                    string code = Console.ReadLine();
                    if (Check(code)) Console.WriteLine("The symbols '1' is pair numbers.");
                    else Console.WriteLine("The symbols '1' is odd numbers.");
                }
                if (choose == 2)
                {
                    Queue<string> words = new Queue<string>();

                    words.Enqueue("if");
                    words.Enqueue("Abrakadabra");
                    words.Enqueue("IF");
                    int count = 0;
                    foreach (string el in words)
                    {
                        if (el == "If" || el == "if" || el == "IF") count++;
                        Console.WriteLine("Queue word: " + el);
                    }
                    Console.WriteLine("\nThe word 'if' repeat {0} times.", count);
                }
                if (choose == 3)
                {
                    Console.Write("Please, enter the numbers: ");
                    string symetric = Console.ReadLine();

                    if (Symetric(symetric)) Console.WriteLine("This stack is symetric.");
                    else Console.WriteLine("This stack is NOT symetric.");
                }
                if (choose == 0) break;
            }

        }
    }
}
