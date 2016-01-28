using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieNight
{
    public class Movies
    {
        List<string> movieList = new List<string>();
        int toyStoryCount = 0;
        int starWarsCount = 0;
        int avengersCount = 0;
        int northCount = 0;
        bool movieMenu = true;
        List<int> votes;

        public void PopulateMovies()
        {
            movieList = new List<string>();
            movieList.Add("Toy Story");
            movieList.Add("Star Wars");
            movieList.Add("Avengers: Age of Ultron");
            movieList.Add("North by Northwest");
        }
        public void GatherVotes()
        {
            while (movieMenu == true)
            {
                for (int i = 0, j = 0; i < 100; i++, j++)
                {
                    int top = Console.CursorTop;
                    int left = Console.CursorLeft;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Which movie would you like to see tonight? Press Q to stop voting at any time!");
                    foreach (string titles in movieList)
                    {
                        Console.WriteLine("{0}", titles);
                    }
                    Console.Write("\r\nToy Story - {0} | Star Wars - {1} | Avengers - {2} | North by NorthWest - {3}\r\n", toyStoryCount, starWarsCount, avengersCount, northCount);
                }
                Console.WriteLine("");
                string movieVote = Console.ReadLine().ToLower();
                if (movieVote == "q")
                {
                    movieMenu = false;
                    DisplayWinner();
                    break;
                }
                switch (movieVote)
                {
                    case "toy story":
                        toyStoryCount++;
                        break;
                    case "star wars":
                        starWarsCount++;
                        break;
                    case "avengers":
                        avengersCount++;
                        break;
                    case "north":
                        northCount++;
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
                Console.Clear();
            }
        }

        private void DisplayWinner()
        {
            votes = new List<int>();
            votes.Add(toyStoryCount);
            votes.Add(starWarsCount);
            votes.Add(avengersCount);
            votes.Add(northCount);
            Console.WriteLine("");
            if (toyStoryCount == votes.Max())
            {
                Console.WriteLine("Toy Story wins with {0} votes", toyStoryCount);
            }
            else if (starWarsCount == votes.Max())
            {
                Console.WriteLine("Star Wars wins with {0} votes", starWarsCount);
            }
            else if (avengersCount == votes.Max())
            {
                Console.WriteLine("Avengers: Age of Ultron wins with {0} votes", avengersCount);
            }
            else if (northCount == votes.Max())
            {
                Console.WriteLine("North by Northwest wins with {0} votes", northCount);
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}