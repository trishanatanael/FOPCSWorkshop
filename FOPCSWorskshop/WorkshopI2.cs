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
            /*Write a program for the following:
            a.Declare an array of dimension 10(index 0… 9).
            b.Generate 50 Random integers in the range 0 … 9.
            c.Store the number of occurrences (count) in the array appropriately.
            d.Print a table that would list the numbers and the number of occurrences.
            Addition:
            -Try to print an histogram for the above
            -How would the program be affected if the range of numbers
            randomly generated is between - 5 and + 5 ?*/

            //int[] number = new int[10];
            int[] output = new int[50];
            Random random = new Random();
            int inArr = 0;
            for (int i = 0; i < output.Length; i++)
            {   
                inArr = random.Next(0, 10);
                output[inArr]++;
            }
            for (int j = 0; j < output.Length; j++)
            {
                Console.WriteLine("{0}",output[j]);
            }
        }
    }
}

