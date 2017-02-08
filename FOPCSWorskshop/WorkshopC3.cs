using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopC3
    {
        public static void Main()
        {
            Console.Write("What's the student's marks?");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (0 <= marks)
            {
                if (marks <= 100)
                {
                    if (marks >= 80)
                        Console.WriteLine("You scored {0} which is A Grade", marks);
                    else if (marks >= 60)
                        Console.WriteLine("You scored {0} which is B Grade", marks);
                    else if (marks >= 40)
                        Console.WriteLine("You scored {0} which is C Grade", marks);
                    else
                    Console.WriteLine("You scored {0} which is F Grade", marks);
                }
                else
                    Console.WriteLine("**Error**");
            }
            else
                Console.WriteLine("**Error**");
        }

    }

}
