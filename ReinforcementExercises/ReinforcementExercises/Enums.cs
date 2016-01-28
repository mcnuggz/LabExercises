using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementExercises
{
    enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    enum Weather { Sunny, Cloudy, Snowy, Rainy, Foggy, Mostly_Cloudy, Mostly_Sunny, Partly_Cloudy}
    public class Enums
    {
        public void PrintTheWeek()
        {
            Console.WriteLine("{0}: {1}", WeekDays.Monday, Weather.Rainy);
            Console.WriteLine("{0}: {1}", WeekDays.Tuesday, Weather.Cloudy);
            Console.WriteLine("{0}: {1}", WeekDays.Wednesday, Weather.Mostly_Sunny);
            Console.WriteLine("{0}: {1}", WeekDays.Thursday, Weather.Mostly_Cloudy);
            Console.WriteLine("{0}: {1}", WeekDays.Friday, Weather.Partly_Cloudy);
            Console.WriteLine("{0}: {1}", WeekDays.Saturday, Weather.Rainy);
            Console.WriteLine("{0}: {1}", WeekDays.Sunday, Weather.Cloudy);
        }
    }
}
