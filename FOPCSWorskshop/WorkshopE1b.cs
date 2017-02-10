using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE1b

    {
        public static void Main()
        {
            int i=1, numberOut = 1;
            //dont put the input in the loop. only use it as the initalizer or expression
            Console.Write("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (i = input; i > 0; i--)
            {
                numberOut = i * numberOut;
            }
            Console.WriteLine(numberOut);
            return;
        }
    }
}
