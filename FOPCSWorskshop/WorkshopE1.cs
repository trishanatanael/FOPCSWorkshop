using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE1

    {
        public static void Main()
        {
            string input;
            int i=1, numberOut = 1;

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out numberOut);

            for (i = 1; i <numberOut; i++)
            {
                numberOut = i * numberOut;
            }

           


        }
    }
}
