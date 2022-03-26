using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiConsoleApp
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public string NumPassenger { get; set; }
        
        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            Console.WriteLine("OnDuty: {0}", OnDuty);
            Console.WriteLine("NumPassenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
