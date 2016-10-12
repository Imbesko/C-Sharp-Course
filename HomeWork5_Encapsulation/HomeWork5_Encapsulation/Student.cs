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
        string nameOfStudent;        
        string address;
        Random rand = new Random();        

        public Student() { }

        public Student(string nameOfStudent, string address)
        {
            this.nameOfStudent = nameOfStudent;
            this.address = address;
        }

        public Student(Student obj) : this(obj.evaluation, obj.nameOfStudent, obj.address) { }

        public Student(int[] ev, string name = "Unknown", string adres = "Unknown")
        {
            for (int i = 0; i < evaluation.Length; i++)
                this.evaluation[i] = rand.Next(1,12);
            nameOfStudent = name;            
            address = adres;
            Console.WriteLine("Student was created.");
        }
                
        public int CalcAvg()
        {
            int average = 0;
            for (int i = 0; i < evaluation.Length; i++)
                average += evaluation[i];
            return (average / 5);
        }
        public void PrintEval(int[] ev)
        {            
            for (int i = 0; i < ev.Length; i++)
                Console.Write(ev[i] + " ");
            Console.WriteLine();
        }
        public void PrintInfo()
        { 
            Console.Write("\n\tStudent\nName student: {0}\nGPA: {1}\nAddress: {2}\nEvaluations: ", nameOfStudent, CalcAvg(), address);
            PrintEval(evaluation);
        }
    }   
}
