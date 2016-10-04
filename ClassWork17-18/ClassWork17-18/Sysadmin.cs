using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17_18
{
    class Sysadmin : Employee
    {
        string computerModel;

        public Sysadmin(string PIB, int age, int salary, string compModel) : base(PIB, age, salary)
        {
            computerModel = compModel;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Computer model: {0}", computerModel);
        }
        public override void IncSalary()
        {
            empSalary += 200;
        }
        public new void DoNothing()
        {
            Console.WriteLine("Nothing from SYSADMIN...");
        }
    }
}
