using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProgram
{
    class Program
    {
        static void Main2(string[] args)
        {
            //List<int> l1 = new List<int> { };                // LIST
            //l1.Add(5);
            //l1.Add(9);
            //l1.Add(12);

            //foreach (int elem in l1)
            //    Console.WriteLine(elem);
            //Console.WriteLine("Count = " + l1.Count);

            //l1.AddRange(new int[] {5, 100, 200, 900});
            //Console.WriteLine("l1 has 5? - " + l1.Contains(5));
            //l1.Clear();                                     // почистить лист
            //int[] arInt = new int[] {1, 2, 3, 0, -5, 100};
            //l1.AddRange(arInt);                             // добавить в конец
            //l1.Insert(1, 100500);                           // добачить в индекс елемент
            //l1.Sort();

            //int[] ar1 = l1.ToArray();                       // перевод 

            //foreach (int elem in l1)
            //    Console.WriteLine(elem);
            //foreach (int elem in ar1)
            //    Console.WriteLine(elem);

            Queue<string> people = new Queue<string>(); // ОЧЕРЕДЬ 

            people.Enqueue("Andrew Troelsen");
            people.Enqueue("Ivan Ivanovich");
            people.Enqueue("Galina Ivanovna");
            people.Enqueue("Terminator");

            //foreach (string person in people)
            //    Console.WriteLine("Near cassa: " + person); // people.Peek();
            //Console.WriteLine(people.Peek());
            //people.Dequeue();
            //Console.WriteLine(people.Dequeue());
            //Console.WriteLine(people.Dequeue());


        }
        static void Main()
        {
            Console.Write("Please enter your code: ");
            string code = Console.ReadLine();

            Console.WriteLine("Code is good " + Check(code)) ;
        }

        static bool Check(string code)
        { 
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < code.Length; i++)
            {
                char ch = (char)code[i];
                if (ch == '(' || ch == '{' || ch == '[')
                    s.Push(ch);
                else if (ch == ')' || ch == '}' || ch == ']')
                    if (s.Count > 0)                    
                        if (Math.Abs(ch - s.Peek()) <= 2) s.Pop();
                        else return false;                    
                    else return false;
            }

            if (s.Count > 0) return false;
            else return true;
        }
    }
}
