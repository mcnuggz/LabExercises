using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Dog : Animal
    {
        public Dog(string name, string species, bool hasFur, bool hasClaws) : base(name, species, hasClaws, hasFur)
        {

        }
    }
}
