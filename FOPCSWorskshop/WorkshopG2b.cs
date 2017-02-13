using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopG2b
    {
        public static void Main()
        {
            bool isPalindrome = true;
            int min = 0;
            Console.WriteLine("Input a phrase: ");
            string input = Console.ReadLine();
           

            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetter(input[i])))
                {
                    input = input.Remove(i, 1);
                
                    i--;
                }

            }
            int max = (input.Length) - 1;

            Console.WriteLine(max);

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
