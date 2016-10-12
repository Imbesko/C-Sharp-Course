using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Rectangle : Shape, IInfo, IPointy
    {
        private Point[] points = new Point[2];

        public Rectangle() { }

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            points[0] = new Point() { X = x1, Y = y1 };
            points[1] = new Point { X = x2, Y = y2 };
        }

        public Rectangle(Point p1, Point p2)
        {
            points[0] = p1;
            points[1] = p2;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This is Rectangle with points: ");
            points[0].PrintInfo();
            points[1].PrintInfo();
            //Console.WriteLine("This is Rectangle with points:\n{0}\n{1}", points[0], points[1].ToString());
        }

        public int GetNumberOfPoints()
        {
            return 4;
        }
    }
}
