using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopF3
    {
        public static void Main()
        {

            //use jagged arrays

            // Declare the array of two elements:
            int[][] subjects = new int[12][];

            // Initialize the elements:
            subjects[0] = new int[4] { 56, 84, 68, 29 };
            subjects[1] = new int[4] { 94, 73, 31, 96 };
            subjects[2] = new int[4] { 41, 63, 36, 90 };
            subjects[3] = new int[4] { 99, 9, 18, 17 };
            subjects[4] = new int[4] { 62, 3, 65, 75 };
            subjects[5] = new int[4] { 40, 96, 53, 23 };
            subjects[6] = new int[4] { 81, 15, 27, 30 };
            subjects[7] = new int[4] { 21, 70, 100, 22 };
            subjects[8] = new int[4] { 88, 50, 13, 12 };
            subjects[9] = new int[4] { 48, 54, 52, 78 };
            subjects[10] = new int[4] { 64, 71, 67, 25 };
            subjects[11] = new int[4] { 16, 93, 46, 72 };

            // Display the array elements:
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("Element {0}", i);

            }


        }
    }
}
