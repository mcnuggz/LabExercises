using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Player
    {
        protected string Name;
        protected int Age;
        protected int JerseyNumber;
        protected float Weight;
        protected float Speed;
        public Player(string name, int age, int jerseyNumber, float weight, float speed)
        {
            Name = name;
            Age = age;
            JerseyNumber = jerseyNumber;
            Weight = weight;
            Speed = speed;
        }

        public void Move()
        {

        }

        public void Listen()
        {

        }

        public int GetJerseyNumber()
        {
            return JerseyNumber;
        }
    }
}
