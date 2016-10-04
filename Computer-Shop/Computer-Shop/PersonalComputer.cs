using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class PersonalComputer : Computer
    {
        string pcType;
        public override string Type { get { return pcType; } set { pcType = value; } }

        public PersonalComputer(string manuf, string owner, string status, string type, float price) : base(manuf, owner, status, price)
        {
            Type = type;
        }

        //public override 
    }
}
