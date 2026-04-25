using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class PlaneTicket
    {
        private string _origin;
        private string _destination;
        private float _cost;
        private string _currency;

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
        public float Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Origin: {Origin}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Cost: {Cost:0} ({Currency})");
            
            if (Currency == "USD")
            {
                Console.WriteLine($"Convert to Rupiah: {Cost * 15000:0}");
            }
            else if (Currency == "IDR")
            {
                Console.WriteLine($"Convert to Dolar: {Cost / 15000:0}");
            }
            
            Console.WriteLine();
        }
    }
}
