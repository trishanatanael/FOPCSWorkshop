using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE3
    {
        public static void Main()
        {
            Console.WriteLine("Please input a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            for (int i = 2; i <= input - 1; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("The number is a not Prime Number");
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is a Prime Number");
            }
                   
        }
    }
}
