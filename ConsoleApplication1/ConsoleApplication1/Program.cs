using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlanetPhysics jupiter = new PlanetPhysics(71492000, 0.0190e27);
            Console.WriteLine(jupiter.EscapeVelocity());
            PythangTheorem triside1 = new PythangTheorem(5.16, 4.94);
            Console.WriteLine(triside1.PythagoreanTheorem());
            Console.ReadLine();
        }
    }
    public class PlanetPhysics
    {
        private const double GRAVITY = 0.0000000000667;
        private readonly double MASS;
        private readonly double RADIUS;

        public PlanetPhysics(double radius, double mass)
        {
            RADIUS = radius;
            MASS = mass;
        }

        public double EscapeVelocity()
        {
            return Math.Sqrt((2 * GRAVITY * MASS) / RADIUS);
        }
        
        
    }
    public class PythangTheorem
    {
        private readonly double SideA;
        private readonly double SideB;
        public PythangTheorem(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public double PythagoreanTheorem()
        {
            double sideC = Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
            double cSquared = Math.Pow(sideC, 2);
            return cSquared;
        }
    }
}
