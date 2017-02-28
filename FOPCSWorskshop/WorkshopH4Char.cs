using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopH4notchar
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence");
            string input = Console.ReadLine();

            Console.WriteLine("Please enter a character that you would like to change");
            string c1Input = Console.ReadLine();

            Console.WriteLine("Please enter a character that will replace the previous character");
            string c2Input = Console.ReadLine();
            
            Console.WriteLine(Substitute(input, c1Input, c2Input));
            Console.WriteLine();

        }
        static string Substitute(string s1, string c1, string c2)
        {
            s1 = s1.Replace(c1, c2);
            return s1;
        }
        /*{
            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (s1.Substring(i, 1).Equals(c1))
                {
                    s1 = s1.Replace(c1, c2);
                    return s1;
                }
            }
                
        }*/
    }
}

