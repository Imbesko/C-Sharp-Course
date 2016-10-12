using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Circle : Shape, IInfo
    {
        public int Radius { get; set; }

        public Circle(int r)
        {
            Radius = r;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This is circle with radius {0}cm", Radius);
        }
    }
}
