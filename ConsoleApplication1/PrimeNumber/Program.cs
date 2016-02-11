using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrimeChecker primeChecker = new PrimeChecker(10000000);
            primeChecker.CreatePrimeList();
            primeChecker.PrintList();
            Console.ReadLine();
        }

    }
}
