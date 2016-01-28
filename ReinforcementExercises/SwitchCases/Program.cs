using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNight
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies movieNight = new Movies();
            movieNight.PopulateMovies();
            movieNight.GatherVotes();
            Console.ReadLine();
        }
    }
}
