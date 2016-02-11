using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Dog
    {
        string Name;
        int Age;
        DogBreed _Breed;
        public Dog(string name, int age, DogBreed breed)
        {
            Name = name;
            Age = age;
            _Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
