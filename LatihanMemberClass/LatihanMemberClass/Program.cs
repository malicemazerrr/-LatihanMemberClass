using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();
            PlaneTicket ticket2 = new PlaneTicket();

            ticket1.Origin = "JOGJA";
            ticket2.Origin = "JKT";
            ticket1.Destination = "PKU";
            ticket2.Destination = "PKU";
            ticket1.Cost = 100;
            ticket2.Cost = 750000;
            ticket1.Currency = "USD";
            ticket2.Currency = "IDR";

            ticket1.PrintSummary();
            ticket2.PrintSummary();

        }
    }
}
