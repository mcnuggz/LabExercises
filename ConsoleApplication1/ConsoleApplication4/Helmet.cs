using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Helmet
    {
        private bool chinstrapFastened = false;
        public bool Fasten()
        {
            return chinstrapFastened = true;
        }
    }
}
