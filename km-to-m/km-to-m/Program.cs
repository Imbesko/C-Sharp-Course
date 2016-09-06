using System;

namespace km_to_m_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKm, numOfM;
            numOfKm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numOfKm +"km * 1000 = " + numOfKm * 1000 + "m");
        }
    }
}
