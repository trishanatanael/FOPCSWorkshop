using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopI2
    {
        public static void Main()
        {
            /*
            c.Store the number of occurrences (count) in the array appropriately.
            d.Print a table that would list the numbers and the number of occurrences.
            Addition:
            -Try to print an histogram for the above
            -How would the program be affected if the range of numbers
            randomly generated is between - 5 and + 5 ?*/

            int[] numberArr = new int[10];
            int inside = 0;
            Random randomNo = new Random();
           

            Console.WriteLine("Number\t\tOutput");
            for (int i = 0; i < 50; i++)
            {   
                inside = randomNo.Next(0, 10);//Next(min,max value -1)
                numberArr[inside]++;
               
            }
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0}\t\t", numberArr[j]);
                for (int k = 0; k < numberArr[j]; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





        }
    }
}

