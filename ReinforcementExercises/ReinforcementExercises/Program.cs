using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Enums enums = new Enums();
            enums.PrintTheWeek();
            Console.WriteLine("");

            Kennel kennel = new Kennel();
            kennel.AddDoggies();
            foreach (Dogs dog in kennel.doggies)
            {
                Console.WriteLine("Name: {0}\r\nAge: {1}\r\nBreed: {2}\r\n", dog.Name, dog.Age, dog._breed);
            }
            Console.ReadLine();

        }
    }
}
