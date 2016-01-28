using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Checker
    {
        public void PalindromeChecker()
        {
            bool menu = true;      
            string presstoLeave = "Q";
            Console.WriteLine("Press Q to quit program or ENTER to continue" + Environment.NewLine);

            while (menu == true)
            {                
                string initial = "";
                Console.WriteLine("Enter a String to check for Palindrome");
                string input = Console.ReadLine().ToLower();
                int inputLength = input.Length;

                if (inputLength <= 1)
                {
                    Console.WriteLine("You did not enter the string.");
                    continue;
                }
                else
                {

                    for (int j = inputLength - 1; j >= 0; j--)
                    {
                        initial = initial + input[j];
                    }

                    if (initial == input)
                    {
                        Console.WriteLine(input + " is palindrome" + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine(input + " is not a palindrome" + Environment.NewLine);
                    }
                }
           
                string userKillCommand = Console.ReadLine();

                if (userKillCommand.ToLower() == presstoLeave.ToLower())
                {
                    break;
                }
            }
                       
        }
    }
}
