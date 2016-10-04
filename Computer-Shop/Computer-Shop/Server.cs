using System;

namespace Computer_Shop
{
    sealed class Server : Computer
    {
        private int serverNumOfProc;

        public override string Type { get; set; }

        public int NumOfProcessors {
            get { return serverNumOfProc; }
            set { serverNumOfProc = value > 2 ? value : 3; }
        }

        public Server(string manufacturer = "Unknown", string owner = "Unknown", string status = "Off", float price = 0f, int procNumber = 0) : base(manufacturer, owner, status, price) {
            NumOfProcessors = procNumber;
            Type = "Server";
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number of processors: {0}", NumOfProcessors);
        }
        //public override 
    }
}
