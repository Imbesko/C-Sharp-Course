using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Point : IInfo, IPointy
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Point with coordinates X = {0}, Y = {1}", X, Y);
        }

        public override string ToString()
        {
            return String.Format("Point with coordinates X = {0}, Y = {1}", X, Y);
        }

        public int GetNumberOfPoints()
        {
            return 1;
        }

    }
}
