using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> petList = new List<Animal>();
            Cat meowser = new Cat("Meowser", "Cat", true, true);
            Dog pepper = new Dog("Pepper", "Dog", true, true);
            Turtle rocky = new Turtle("Rocky", "Turtle", false, false);

            petList.Add(meowser);
            petList.Add(pepper);
            petList.Add(rocky);

            foreach (Animal pet in petList)
            {
                Console.WriteLine(pet.Name + ": " + pet.Species);
            }
            Console.ReadLine();
        }
    }
}
