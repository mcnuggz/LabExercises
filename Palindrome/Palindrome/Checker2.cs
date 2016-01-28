using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Checker2
    {
        string userInput;
        string reverseInput;
        bool isPalindrome;

        public Checker2()
        {
            isPalindrome = false;
        }
        public void getUserInput()
        {
            Console.WriteLine("Enter a word or phrase to be checked: ");
            this.userInput = Console.ReadLine();
        }

        public void reverseUserInput()
        {
            char[] reverseArray = this.userInput.ToCharArray();
            Array.Reverse(reverseArray);
            this.reverseInput = new string(reverseArray);
        }

        public void CheckIsPalindrome()
        {
            if (userInput == reverseInput)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
        }

        public void PrintResult()
        {
            if (isPalindrome == true)
            {
                Console.WriteLine("{0} is a palindrome", userInput);
            }
            else if(isPalindrome == false)
            {
                Console.WriteLine("{0} is not a palindrome", userInput);
            }
        }
    }
}
