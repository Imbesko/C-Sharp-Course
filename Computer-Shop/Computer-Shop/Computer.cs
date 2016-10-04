using System;

namespace Computer_Shop
{
    abstract class Computer
    {
        //Fields
        private string compStatus;
        private string compType;
        private float compPrice;
        private readonly int compId;

        private static Random rand = new Random();

        // Properties
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public string Status { get { return compStatus; } }
        public abstract string Type { get; set; } 
            
        public float Price
        {
            get { return compPrice; }
            set { compPrice = value > 1499.99f ? 1499.99f : value; }
        }
        public int ID { get { return compId; } }        

        //Constructor
        public Computer(string manufacturer = "Unknown", string owner = "Unknown", string status = "Off", float price = 0f)
        {
            compId = rand.Next(111111111, 999999999);
            Manufacturer = manufacturer;
            Owner = owner;
            compStatus = status; // Directly to field           
            Price = price;
            
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("\n\nId:{0}\nManufacturer: {1}\nOwner: {2}\nStatus: {3}\nType: {4}\nPrice: ${5}", ID, Manufacturer, Owner, Status, Type, Price);            
        }
    }
}
