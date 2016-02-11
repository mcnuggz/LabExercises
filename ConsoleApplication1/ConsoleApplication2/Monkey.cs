using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Monkey
    {
        string Name;
        int Age;
        Species _Species;
        bool HasPoo;
        public Monkey()
        {

        }
        public Monkey(string name, int age, Species species, bool hasPoo)
        {
            Name = name;
            Age = age;
            _Species = species;
            HasPoo = hasPoo;
        }
    }
}
