using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopH3
    {
        public static void Main()
        {
            Console.WriteLine("Hexadecimal Converter");
            Console.Write("Please input a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Hex(input));

        }
        /*static string Hex(int num1)
        {
            return num1.ToString("X");
        }*/
        static string Hex(int num1)
        {
            double a = Convert.ToDouble(num1);
            double div = a;
            double remainder = a;
            string conversion = "";

            while (div >= 16)
            {
                remainder = div % 16;
                div = div / 16;
                div = Math.Floor(div);

                if (remainder == 0)
                    conversion = "0" + conversion;
                if (remainder == 1)
                    conversion = "1" + conversion;
                if (remainder == 2)
                    conversion = "2" + conversion;
                if (remainder == 3)
                    conversion = "3" + conversion;
                if (remainder == 4)
                    conversion = "4" + conversion;
                if (remainder == 5)
                    conversion = "5" + conversion;
                if (remainder == 6)
                    conversion = "6" + conversion;
                if (remainder == 7)
                    conversion = "7" + conversion;
                if (remainder == 8)
                    conversion = "8" + conversion;
                if (remainder == 9)
                    conversion = "9" + conversion;
                if (remainder == 10)
                    conversion = "A" + conversion;
                if (remainder == 11)
                    conversion = "B" + conversion;
                if (remainder == 12)
                    conversion = "C" + conversion;
                if (remainder == 13)
                    conversion = "D" + conversion;
                if (remainder == 14)
                    conversion = "E" + conversion;
                if (remainder == 15)
                    conversion = "F" + conversion;
            }
            return div + conversion;
        }

    }
}
