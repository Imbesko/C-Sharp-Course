using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            PrintInfoAboutI(c);            

            Rectangle r = new Rectangle(0, 0, 5, 7);
            r.PrintInfo();

            Triangle t = new Triangle(0, 0, 3, 3, 9, 9);            
            t.PrintInfo();

            Console.WriteLine("Rectangle has {0} points\nTriangle has {1} points", r.GetNumberOfPoints(), t.GetNumberOfPoints());
        }

        static void PrintInfoAboutI(IInfo inf)
        {
            inf.PrintInfo();
        }
    }
}
