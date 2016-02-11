using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus();
            Thread.Sleep(3000);
            bus1.StartTheBuses();
            
            Bus bus2 = new Bus();
            Thread.Sleep(9000);
            bus2.StartTheBuses();
            
            Bus bus3 = new Bus();
            Thread.Sleep(4000);
            bus3.StartTheBuses();

            Console.WriteLine("All buses are deployed");
            Console.ReadLine();
        }
    }
    public class Bus
    {
        public static readonly DateTime GLOBALSTARTTIME;
        static Bus()
        {
            GLOBALSTARTTIME = DateTime.Now;
        }
        public void StartTheBuses()
        {
            TimeSpan timeSinceStart = DateTime.Now - GLOBALSTARTTIME;
            Console.WriteLine(timeSinceStart.Seconds);

        }
    }
}
