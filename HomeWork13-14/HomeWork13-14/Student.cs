using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13_14
{
    class Student
    {
        readonly int[] evaluation = new int[5];
        string name;
        int GPA;
        string address;
        Random rand = new Random();

        public Student(int[] ev = null, string Name = "Unknown", int gpa = 0, string adres = "Unknown")
        {
            for (int i = 0; i < ev.Length; i++)
                ev[i] = rand.Next(1,12);
        }

        public int CalcAvg(int[] evaluation)
        {
            int average = 0;
            for (int i = 0; i < evaluation.Length; i++)
                average += evaluation[i];
            return (average / 5);
        }
    }
}
