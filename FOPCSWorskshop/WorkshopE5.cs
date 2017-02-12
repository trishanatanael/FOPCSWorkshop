using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE5

    {
        public static void Main()
        {
            //Modify the Prime Number C# program to print out all the prime numbers from 5 to 10000
           
            
            bool isPrime = true;
            Console.WriteLine("Prime number from 1-10000:");

            for (int j = 1; j < 10000; j++)
            {
                isPrime = true;
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;

                    }
                }
                if (isPrime)
                    Console.WriteLine("{0}", j);

            }
            return;

        }
    }
}
