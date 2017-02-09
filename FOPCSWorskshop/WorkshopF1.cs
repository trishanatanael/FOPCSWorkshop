using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopF1
    {
        public static void Main()
        {
            string[] salesMonth = new string[12] {"January","February","March",
                                               "April","May","June","July",
                                               "August","September","October",
                                               "November","December"};
            //12 rows of staements
            int[] salesInfo = new int[12] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21};
            int i=0;
            double totalSales;
            double aveSales;
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("{0} \t\t\t {1}", salesMonth[i], salesInfo[i]);

            }
            totalSales = salesInfo.Sum();
            Console.WriteLine(totalSales);

            int maxSales = salesInfo.Max();
            Console.WriteLine("Max sales is {0}", maxSales);

            int minSales = salesInfo.Min();
            Console.WriteLine("Min sales is {0}", minSales);

            aveSales = Convert.ToDouble(totalSales /i);
            Console.WriteLine("Average sales this year is {0}", aveSales);

        }
    }
}
