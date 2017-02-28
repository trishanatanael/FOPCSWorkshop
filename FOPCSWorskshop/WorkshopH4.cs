using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopH4
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence");
            string input = Console.ReadLine();

            Console.WriteLine("Please enter a character that you would like to change");
            char c1Input = Console.ReadKey().KeyChar;

            Console.WriteLine("Please enter a character that you would like to change");
            char c2Input = Console.ReadKey().KeyChar;

            //Console.WriteLine(Substitute(input,c1Input,c2Input));

        }
        /*static string Substitute(string s1, char c1, char c2)
        {

            if (s1.Length == 0 || s2.Length == 0 || s2.Length > s1.Length)
                return -1;
            else if (s1.Length == s2.Length)
            {
                if (string.Equals(s1, s2))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if ((s1.Length) > (s2.Length))
                {
                   int index = s1.IndexOf(s2);
                    if (index >= 0)
                        return index;
                    else
                        return -1;
                }
                else
                    return -1;
                
            }
        }*/
    }
}

