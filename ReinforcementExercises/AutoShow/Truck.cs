using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShow
{
    public class Truck : Automobile
    {  
        public Truck(string brand, string model, string make, int passengerCount, int numberofDoors) : base(brand, model, make, passengerCount, numberofDoors)
        {
        }
    }
}
