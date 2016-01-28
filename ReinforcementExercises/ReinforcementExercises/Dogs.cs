using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementExercises
{
    public enum Breed { Austrailian_Shepard, Boxer, Bulldog, Poodle, Beagle, Pug, Husky, Mastiff, Chihuahua, Shihzuh }
    public class Dogs
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Breed _breed { get; set; }
        
        public Dogs(string name, int age, Breed breed)
        {
            this.Name = name;
            this.Age = age;
            this._breed = breed;
        }
    }
}
