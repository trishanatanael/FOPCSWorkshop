using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopF3
    {
        static void Main(string[] args)
        {

            // Example for multidimensional array

            int[][] Marks = new int[12][];
            Marks[0] = new int[4] { 56, 84, 68, 29 };
            Marks[1] = new int[4] { 94, 73, 31, 96 };
            Marks[2] = new int[4] { 41, 63, 36, 90 };
            Marks[3] = new int[4] { 99, 9, 18, 17 };
            Marks[4] = new int[4] { 62, 3, 65, 75 };
            Marks[5] = new int[4] { 40, 96, 53, 23 };
            Marks[6] = new int[4] { 81, 15, 27, 30 };
            Marks[7] = new int[4] { 21, 70, 100, 22 };
            Marks[8] = new int[4] { 88, 50, 13, 12 };
            Marks[9] = new int[4] { 48, 54, 52, 78 };
            Marks[10] = new int[4] { 64, 71, 67, 25 };
            Marks[11] = new int[4] { 16, 93, 46, 72 };
            

            // Calculate total for each 
            for (int i = 0; i < 12; i++)
            {
                int avg = 0;

                for (int j = 0; j < 4; j++)
                {
                    avg += Marks[i][j];
                    
                }
                Console.WriteLine("Total marks for each student {0}", avg);

            }
            
            double[] Avg = new double[12];


            // Calculate student average
            for (int i = 0; i < 12; i++)
            {
                double avg = 0.0;

                for (int k = 0; k < 4; k++)
                {
                    avg += Marks[i][k];
                }

                Avg[i] = avg / 4;
                Console.WriteLine("The average for each student {0}",Avg[i]);
            }
            
            // Calculate subject average
            Console.WriteLine("Average per subject:");

            for (int m = 0; m < 4; m++)
            {
                double subAvg = 0.0;
                for (int j = 0; j < 12; j++)
                {
                    subAvg += Marks[j][m];
                }

                subAvg /= 12;
                Console.WriteLine("Subject average {0:0.#####}", subAvg);
            }
            return; 
        }
    }
}

