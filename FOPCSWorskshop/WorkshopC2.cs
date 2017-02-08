using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopC2
    {
        public static void Main()
        {
            /*Write a program that would request for your name, gender and age and would print
            a greeting like this: Write a program that would request for your name, gender and age and would print
            a greeting like this:
            Good morning Uncle Sam ( if Sam, M, 45 is entered)
            (any gentlemen 40 years or more is Uncle any lady 40 years or more is Aunty, if
            less than forty they become just Mr or Ms. as the case may be.) Good morning Uncle Sam ( if Sam, M, 45 is entered)
            (any gentlemen 40 years or more is Uncle any lady 40 years or more is Aunty, if
            less than forty they become just Mr or Ms. as the case may be.) */

            Console.Write("What is your name?");
            string name2 = Console.ReadLine();

            Console.Write("What is your gender (M/F)?");
            string gender2 = Console.ReadLine();

            Console.Write("What is your age?");
            int age40 = Convert.ToInt32(Console.ReadLine());

            if (age40 >= 40)
                if (gender2 == "M" || gender2 == "m")
                    Console.WriteLine("Good morning Uncle " + name2);
                else
                    Console.WriteLine("Good morning Aunty " + name2);
            else if (age40 < 40)
                if (gender2 == "F" || gender2 == "f")
                    Console.WriteLine("Good morning Ms. " + name2);
                else 
                    Console.WriteLine("Good morning Mr. " + name2);
            else
                Console.Write("Invalid data, please correct it");
        }

    }

}
