using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // in out зчитувати і записувати в файли принтери сканери і т.д.

namespace FunWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {            
            //File.Create("D:\\Study\\C# projects\\Lesson 1\\C-Sharp-Course\\file1.txt"); // Створює файл
            //File.WriteAllText("\\Study\\C# projects\\Lesson 1\\C-Sharp-Course\\file1.txt", "Peter "); // створює і записує або перезаписує файл
            //File.AppendAllText("\\Study\\C# projects\\Lesson 1\\C-Sharp-Course\\file1.txt", "Bespalko"); // add string tot text
            //File.Delete("\\Study\\C# projects\\Lesson 1\\C-Sharp-Course\\file1.txt");     // delete file
            FileStream f1 = new FileStream("\\Study\\C# projects\\Lesson 1\\C-Sharp-Course\\file1.txt", FileMode.Open, FileAccess.Read); // записувати в файл
            StreamReader read = new StreamReader(f1); // зчитувати з файлу

            List<char> l = new List<char>();
            while (!read.EndOfStream)
            {
                string s = read.ReadLine();
                for (int i = 0; i < s.Length; i++)  
                    l.Add(s[i]);
                l.Add('\r');
                l.Add('\n');
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == 'A' || l[i] == 'a')
                {
                    l.Insert(i, 'a');
                    i++;
                }
                
            }

            FileStream f2 = new FileStream("\\Study\\C# projects\\Lesson 1\\C-Sharp-Course\\file2.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(f2);
            foreach (char c in l)
                write.Write(c);


            write.Close();
            read.Close();
            

        }
    }
}
