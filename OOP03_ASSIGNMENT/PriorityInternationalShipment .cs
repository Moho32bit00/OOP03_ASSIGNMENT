using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_ASSIGNMENT
{
    public  class PriorityInternationalShipment : InternationalShipment
    {
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generate Customs report ");
        }

    }
}
