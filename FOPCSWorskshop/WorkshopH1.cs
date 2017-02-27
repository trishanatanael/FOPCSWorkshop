using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopH1
    {
        public static void Main()
        {
            string s1 = "The bras basah complex";
            string input = "";

            Console.WriteLine("InString Test");
            Console.WriteLine(s1);
            Console.Write("Please enter a string: ");
            input = Console.ReadLine();

            Console.WriteLine(InString(s1, input) ? "True" : "False");

        }
        static bool InString(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            if (s1.Length == 0 || s2.Length == 0 || s2.Length > s1.Length)
                return false;
            else if (s1.Length == s2.Length)
            {
                if (string.Equals(s1, s2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((s1.Length) > (s2.Length))
                {
                    int count = 0;
                    for (int i = 0; i < s1.Length - s2.Length; i++)
                    {
                        if (s1.Substring(i, s2.Length).Equals(s2))
                            count++;
                    }
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
        }
    }
}

