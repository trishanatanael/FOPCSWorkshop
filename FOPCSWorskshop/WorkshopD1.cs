using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopD1
    {
        public static void Main()
        {
            bool compare = true;
            int input = 88;
            int luckynum = 88;

            while (compare)
            {
                Console.Write("Please input a number: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == luckynum)
                {
                    Console.WriteLine("Lucky you...");
                    break;
                }
              

            }

        
        }
    }
}


