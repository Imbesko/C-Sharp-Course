using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class DisplayClass
    {
        private int displayPPI;

        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public int WPixels { get; set; }
        public int HPixels { get; set; }
        public float Diagonal { get; set; }
        public int PPI
        {
            get {CalcPPI(); return displayPPI; }
        }

        public DisplayClass(string manufacturer = "Unknown" , string type = "Unknown", int wPixels = 0, int hPixels = 0, float diagonal = 1f)
        {
            Manufacturer = manufacturer;
            Type = type;
            WPixels = wPixels;
            HPixels = hPixels;
            Diagonal = diagonal;
            CalcPPI();
        }

        private void CalcPPI()
        {
            displayPPI = Convert.ToInt32(Math.Sqrt(WPixels * WPixels + HPixels * HPixels) / Diagonal);
        }
    }
}
