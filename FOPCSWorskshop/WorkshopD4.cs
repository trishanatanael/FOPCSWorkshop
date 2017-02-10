using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopD4
    {
       
        public static void Main()
        {
            string input = "";
            double n = 0.0, guess = 0.0;
            Random random = new Random();

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Double.TryParse(input, out n);

            if (n == 0)
            {
                Console.WriteLine("The sqrt of {0} is 0.000", n);
                return;
            }

             guess = random.NextDouble() * n;// random will never go beyond n and lower than 0 since it nextdouble(0,1) doesnot allow us to enter range

            if (guess * guess != n)
            {
                guess = (guess + (n / guess)) / 2;

                while (guess * guess - n >= 0.00001 || n - guess * guess >= 0.00001)
                {
                    guess = (guess + (n / guess)) / 2;
                }
            }

            Console.WriteLine("The sqrt of {0} is {1:0.###}\n", n, guess);

            return;

        }
    }
}
