using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopG2a
    {
        public static void Main()
        {
            /*2. Write a C# program to determine if a given string is a palindrome.
            a.Your program should take a string from the console and test if the word is a
palindrome or not using the approach explained by your instructor (you are
expected to follow the steps given by the instructor)
– A palindrome is a word / phrase that reads the same forwards or backwards.*/
            bool isPalindrome = true;
            int min = 0;
            Console.WriteLine("Input a phrase: ");
            string input = Console.ReadLine();
            int max = (input.Length) - 1;

            while (isPalindrome)
            {
                char a = input[min];
                char b = input[max];
                if (min > max)
                {
                    break;
                }
                else if (char.ToLower(a) != char.ToLower(b))
                {
                    isPalindrome = false;
                }
                else isPalindrome = true;
                min++; max--;
            }

            Console.WriteLine(isPalindrome ? "The word is palindrome" : "The word is not palindrome");
        }
    }
}
