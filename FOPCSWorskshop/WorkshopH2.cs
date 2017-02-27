using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopH2
    {
        public static void Main()
        {
            string s1 = "The brown fox";
            string input = "";

            Console.WriteLine("FindWord Test");
            Console.WriteLine(s1);
            Console.Write("Please enter a string: ");
            input = Console.ReadLine();

            Console.WriteLine(FindWord(s1, input));

        }
        static int FindWord(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

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
        }
    }
}

