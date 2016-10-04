using System;

namespace Computer_Shop
{   
    sealed class Smartphone : Computer
    {
        public override string Type
        {
            get; set;
        }
        public Smartphone(string manufacturer = "Unknown", string owner = "Unknown", string status = "Off", float price = 0f) : base(manufacturer, owner, status, price) 
        {
            Type = "Smartphone";
        }
    }
}
