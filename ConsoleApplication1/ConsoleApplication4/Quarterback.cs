using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Quarterback : Player
    {
        public string PlayCalled;
        private bool rightHandPasser;
        private bool leftHandPasser;

        public Quarterback(string name, int age, int jerseyNumber, float weight, float speed, bool rightHanded, bool leftHanded) : base(name, age, jerseyNumber, weight, speed)
        {
            rightHandPasser = rightHanded;
            leftHandPasser = leftHanded;     
        }
        public void ThrowPass()
        {

        }

        public void CallPlay()
        {

        }
    }
}
