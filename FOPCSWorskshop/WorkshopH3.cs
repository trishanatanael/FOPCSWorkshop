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
            double num2 = Convert.ToDouble(num1);
            double div = num2;
            double rem = num2;
            string hexconversion = "";

            while (div >= 16)
            {
                rem = div % 16;
                div = div / 16;
                div = Math.Floor(div);

                if (rem == 0)
                    hexconversion = "0" + hexconversion;
                if (rem == 1)
                    hexconversion = "1" + hexconversion;
                if (rem == 2)
                    hexconversion = "2" + hexconversion;
                if (rem == 3)
                    hexconversion = "3" + hexconversion;
                if (rem == 4)
                    hexconversion = "4" + hexconversion;
                if (rem == 5)
                    hexconversion = "5" + hexconversion;
                if (rem == 6)
                    hexconversion = "6" + hexconversion;
                if (rem == 7)
                    hexconversion = "7" + hexconversion;
                if (rem == 8)
                    hexconversion = "8" + hexconversion;
                if (rem == 9)
                    hexconversion = "9" + hexconversion;
                if (rem == 10)
                    hexconversion = "A" + hexconversion;
                if (rem == 11)
                    hexconversion = "B" + hexconversion;
                if (rem == 12)
                    hexconversion = "C" + hexconversion;
                if (rem == 13)
                    hexconversion = "D" + hexconversion;
                if (rem == 14)
                    hexconversion = "E" + hexconversion;
                if (rem == 15)
                    hexconversion = "F" + hexconversion;
            }
            return div + hexconversion;
        }

    }
}
