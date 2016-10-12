using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : Shape, IInfo, IPointy
    {
        private Point[] points = new Point[3];

        public Triangle() { }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            points[0] = new Point(x1, y1);
            points[1] = new Point(x2, y2);
            points[2] = new Point(x3, y3);
        }

        public void PrintInfo()
        {
            Console.WriteLine("This is triangle with coordinates: ");
            points[0].PrintInfo();
            points[1].PrintInfo();
            points[2].PrintInfo();
        }

        public int GetNumberOfPoints()
        {
            return 3;
        }
    }
}
