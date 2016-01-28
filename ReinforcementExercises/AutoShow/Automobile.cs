using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShow
{
    public abstract class Automobile
    {
        //ford, chevy..
        public string Brand { get; set; }
        //suv, sedan..
        public string Model { get; set; }
        //escape, sonata...
        public string Make { get; set; }
        public int NumberOfPassengers { get; set; }
        public int NumberOfDoors { get; set; }
        public int Acceleration = 0;
        public List<Automobile> autoList;
        public Automobile(string brand, string model, string make, int passengerCount, int numberofDoors)
        {
            this.Brand = brand;
            this.Model = model;
            this.Make = make;
            this.NumberOfPassengers = passengerCount;
            this.NumberOfDoors = numberofDoors;

            autoList = new List<Automobile>();
        }
        public void Accelerate()
        {
            Acceleration++;
        }
        public void Decelerate()
        {
            if (Acceleration != 0)
            {
                Acceleration--;
            }
        }

        public void PrintCar()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Passenger Seats: " + NumberOfPassengers);
            Console.WriteLine("Number of Doors: " + NumberOfDoors);
            Console.WriteLine("");
        }
        public void PrintList()
        {
            foreach (Sedan car in autoList)
            {
                
            }
        }
    }
}
