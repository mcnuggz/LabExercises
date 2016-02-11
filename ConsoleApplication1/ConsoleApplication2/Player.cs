using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Player
    {
        string Name;
        int Age;
        public Player()
        {
            
        }
        public Player(string name, int age)
        {
            Name = name;
            Age = age; ;
        }
        public void SayHi()
        {
            Console.WriteLine("Hello");
        }

        public void GetBackToWork()
        {
            Console.WriteLine("Nah I'm good, thanks.");
        }
    }
}
