using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17_18
{
    abstract class Employee //  абстрактный класс                                     sealed - запрет наследования
    {
        protected string empPIB;
        protected int empAge;
        protected int empSalary;

        public int Salary
        {
            get { return empSalary; }
        }
        public Employee()
        {
            Console.WriteLine("*** New employee created ***");
        }

        public Employee(string PIB, int age, int salary)
        {
            empPIB = PIB;
            empAge = age;
            empSalary = salary;
            Console.WriteLine("\n*** New employee created ***");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("\tEmployee\nFull name: {0}\nAge: {1}\nSalary: ${2}", empPIB, empAge, Salary);
        }

        public abstract void IncSalary();

        public void DoNothing()
        {
            Console.WriteLine("Nothing...");
        }
      
    }
}
