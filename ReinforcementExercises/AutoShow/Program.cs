using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShow
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Coupe coupe1 = new Coupe("Ford", "Coupe", "Mustang", 2, 2);
            Sedan sedan1 = new Sedan("Chevy", "Sedan", "Cobalt", 4, 4);
            Sedan sedan2 = new Sedan("Honda", "Sedan", "Fit", 4, 4);
            coupe1.PrintCar();
            sedan2.PrintList();


            Console.ReadLine();
        }
    }
}
