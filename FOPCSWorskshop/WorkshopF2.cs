using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopF2
    {
        public static void Main()
        {
            //what if you want to put a random number as the array input??
            int pos_min, temp;
            int[] arr = new int[20] { 1,2,3,14,15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,16, 17,18,19,20};
            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
            //to print array!
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

        }
    }
}
