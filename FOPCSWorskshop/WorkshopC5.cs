using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopC5
    {
        public static void Main()
        {
            int sum1, sum2, sum3, middlecalc2, middlecalc1, remainder1, remainder2, remainder3 = 0;
            Console.Write("Please input a three-digit number:");
            int input = Convert.ToInt32(Console.ReadLine());
           

            if (input >= 100 && input <= 999)
            {
                remainder3 = input % 10;
                sum3 = remainder3*remainder3*remainder3;
                Console.WriteLine(sum3);

                remainder2 = input % 100;
                middlecalc2 = (remainder2-remainder3)/ 10;
                sum2 = middlecalc2*middlecalc2*middlecalc2;
                Console.WriteLine(sum2);

                remainder1 = input - remainder2;
                middlecalc1 = remainder1 / 100;
                sum1 = middlecalc1*middlecalc1*middlecalc1;
                Console.WriteLine(sum1);

                int total = sum1 + sum2 + sum3;
                Console.WriteLine(total);

                if (total==input)
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("Input a valid three-digit number");


        }

    }

}
