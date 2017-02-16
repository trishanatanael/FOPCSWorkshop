using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopG4
    {
        public static void Main()
        {
            string[] name = new string[] { "John" , "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            int[] MarksSorted= new int[5];
            string[] NameSorted = new string[5];
            
            //a) rank mark
            Console.WriteLine("Ranking");
            int temp = 0;
            string tempName = "";
            int i = 0, j = 0;
            for (i = 0; i < mark.GetLength(0)-1; i++)
            {
                for (j = i + 1; j < mark.GetLength(0); j++)
                {
                    if (mark[i] > mark[j] )
                    {
                        temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;

                        tempName = name[i];
                        name[i] = name[j];
                        name[j] = tempName;
                    }

                }
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t\t{1}", name[i], mark[i]);
            }

            //b/ by name 
            int tempb = 0;
            string tempNameb = "";
           
            for (i = 0; i < mark.GetLength(0) - 1; i++)
            {
                for (j = i + 1; j < mark.GetLength(0); j++)
                {
                    if (name[i].CompareTo(name[j])>0)
                    {
                        tempNameb = name[i];
                        name[i] = name[j];
                        name[j] = tempNameb;

                        tempb = mark[i];
                        mark[i] = mark[j];
                        mark[j] = tempb;

                    }

                }
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t\t{1}", name[i], mark[i]);
            }

        }
    } 
}
