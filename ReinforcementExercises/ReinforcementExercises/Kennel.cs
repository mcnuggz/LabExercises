using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementExercises
{
    public class Kennel
    {
        public List<Dogs> doggies;

        public void AddDoggies()
        {
            doggies = new List<Dogs>();
            doggies.Add(new Dogs("Hulk", 2, Breed.Chihuahua));
            doggies.Add(new Dogs("Louie", 7, Breed.Shihzuh));
            doggies.Add(new Dogs("Elwood", 9, Breed.Austrailian_Shepard));
        }

        public void AddDoggies(string name, int age, Breed breed)
        {
            doggies = new List<Dogs>();
            doggies.Add(new Dogs(name, age, breed));
        }
    }
}
