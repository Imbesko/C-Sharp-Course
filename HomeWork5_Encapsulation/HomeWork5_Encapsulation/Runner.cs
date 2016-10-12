using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13_14
{
    class Runner
    {
        string PIB;
        public float Time { get; set; }

        public Runner() { }
        public Runner(string PIB = "Unknown", float time = 0f) 
        {
            this.PIB = PIB;
            this.Time = time;
        }
        
        public void PrintRunner()
        {            
            Console.WriteLine("\nName: {0}\ntime: {1}", PIB, Time);
            
        }
    }
}
