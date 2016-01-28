using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public abstract class Animal
    {
        public string Name;
        public string Species;
        public bool HasClaws;
        public bool HasFur;

        public Animal(string name, string species, bool hasClaws, bool hasFur)
        {
            this.Name = name;
            this.Species = species;
            this.HasClaws = hasClaws;
            this.HasFur = hasFur;
        }

    }
}
