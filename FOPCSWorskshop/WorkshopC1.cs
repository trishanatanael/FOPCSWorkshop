using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopC1
    {
        public static void Main()
        {
            /* Write a program that would request for your name and gender (M or F assume capital letter) and print a greeting like this:
            Good Morning Mr.Venkat where you entered Venkat for name and M for gender */

            Console.Write("What is your name?");
            string name = Console.ReadLine();

            Console.Write("What is your gender (M/F)?");
            string gender = Console.ReadLine();

            if (gender == "M" || gender == "m")
            {
                Console.WriteLine("Good Morning, Mr. {0}", name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("Good Morning, Ms. {0}", name);
            }
            else
                Console.Write("Invalid data, please correct it");

        }

    }

}
