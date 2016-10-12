using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишіть програму, яка зчитує з файлу перший рядок, 
//записує кожне слово з цього рядка в стек та виводить на 
//екран слова у зворотньому порядку. Колекцію зберігайте 
//як змінну-поле в побічному класі.
using System.IO;
namespace HomeWork6_Polymorphism_
{
    //class Test
    //{
    //    public static Stack<string> str = new Stack<string>();
    //}
    class Program
    {    
        static void Main(string[] args)
        {
            FileStream file = new FileStream("C:\\file.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file);
            //Test t = new Test();

            public static Stack<string> str = new Stack<string>();
            string s = read.ReadLine();
            //for (int i = 0; i < t.str.Count; i++)
                str.Add(s);
            

            
        }
        
    }
}


//while (true)
//            {
//                Console.Write("Enter the task (1-3), 0 - Exit: ");
//                byte choose = byte.Parse(Console.ReadLine());
//                if (choose == 0) break;
//                if (choose == 3)
//                {
//                    Vector[] vec = new Vector[3];
//                    for (int i = 0; i < 3; i++)
//                    {
//                        int x = int.Parse(Console.ReadLine());
//                        int y = int.Parse(Console.ReadLine());
//                        vec[i] = new Vector(x, y);
//                    }
//                }
//            }