using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Cat
    {
        string Name;
        int Age;
        CatBreed _Breed;
        public Cat()
        {

        }

        public Cat(string name, int age, CatBreed breed)
        {
            Name = name;
            Age = age;
            _Breed = breed;
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
}
