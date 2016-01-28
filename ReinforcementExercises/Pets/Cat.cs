using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Cat : Animal
    {
        public Cat(string name, string species, bool hasClaws, bool hasFur) : base(name, species, hasClaws, hasFur)
        {

        }
    }
}
