using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class PrimeChecker
    {
        int EndOfRange;
        public List<int> primes;
        public PrimeChecker(int endOfRange)
        {
            EndOfRange = endOfRange;
            this.primes = new List<int>() { 1, 2, 3, 5, 7};
        }
        public bool CheckIfPrime(int number)
        {
            if(number % 2 == 0)
            {
                return false;
            }
            for (int checkingNumber = 3; checkingNumber < number; checkingNumber++)
            {
                if (number % checkingNumber == 0 )
                {
                    return false;
                }
            }
            return true;
        }

        public void CreatePrimeList()
        {
            for (int counter = 11; counter <= this.EndOfRange; counter+=2)
            {
                if (CheckIfPrime(counter))
                {
                    primes.Add(counter);
                }
            }
        }
        public void PrintList()
        {
            string path = "primes.txt";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (int prime in primes)
                {
                    writer.WriteLine(prime);
                }
            }
                
            stopwatch.Stop();
            long duration = stopwatch.Elapsed.Seconds;
            Console.WriteLine("Time to complete: " + duration + " seconds");
        }
    }
}
