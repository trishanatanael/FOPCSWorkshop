using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE1a

    {
        public static void Main()
        {

            
            int  factorial = 1;

            Console.Write("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
           

            for (int i = 1; i <= input; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);

            return;


        }
    }
}
