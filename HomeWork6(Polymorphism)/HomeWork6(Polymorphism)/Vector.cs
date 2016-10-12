using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Polymorphism_
{
    class Vector
    {
        private int pointA;
        private int pointB;
        private float length;

        public int X { get; set; }
        public int Y { get; set; }
        public float Length { get { return length; } }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
            length = (float)Math.Sqrt(X * X + Y * Y);
        }
    }
}
