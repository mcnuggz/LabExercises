using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class WideReceiver : Player
    {
        public float catchPercentage;
        private bool caughtPass;
        public WideReceiver(string name, int age, int jerseyNumber, float weight, float speed) : base( name, age, jerseyNumber, weight, speed)
        {
            
        }

        public void catchPass()
        {
            Random r = new Random();
            int result = r.Next(1, 2);
            if(result == 2)
            {
                caughtPass = true;
            }
            else
            {
                caughtPass = false;
            }
        }

        private void Celebrate()
        {
            Console.WriteLine("Awwwww yeah baby!");
        }
    }
}
