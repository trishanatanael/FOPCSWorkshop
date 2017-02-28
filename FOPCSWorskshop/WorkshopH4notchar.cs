using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopH4Char
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence");
            string input = Console.ReadLine();

            Console.WriteLine("Please enter a character that you would like to change");
            char c1Input = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please enter a character that will replace the previous character");
            char c2Input = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine(Substitute(input, c1Input, c2Input));
            Console.WriteLine();

        }
        static string Substitute(string s1, char c1, char c2)
        {
            s1 = s1.Replace(c1, c2);
            return s1;
        }
    }
}

