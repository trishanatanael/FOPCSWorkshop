using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopC6
    {
        public static void Main()
        {
            
            Console.Write("What would you like to order a TV?");
            string tv = Console.ReadLine();
            Console.WriteLine("How many?");
            int numbertv = Convert.ToInt32(Console.ReadLine());
            Console.Write("What would you like to order a DVD?");
            string dvd = Console.ReadLine();
            Console.WriteLine("How many?");
            int numberdvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("What would you like to order a MP3?");
            string mp3 = Console.ReadLine();
            Console.WriteLine("How many?");
            int numbermp3 = Convert.ToInt32(Console.ReadLine());

            if (numbermp3 == 0)
            {
                int totalnomp3 = (numbertv * 900) + (numberdvd * 500);
                if (totalnomp3 > 10000)
                {
                    int totalnomp310 = (totalnomp3 * 85/100);
                    Console.WriteLine("Total price = ${0:#,#}", totalnomp310);
                }
                else if (totalnomp3 > 5000)
                {
                    int totalnomp315 = totalnomp3 * 90/100;
                    Console.WriteLine("Total price = ${0:#,#}", totalnomp315);
                }
                else
                    Console.WriteLine("Total price = ${0:#,0}", totalnomp3);
            }
            else
            {
                if (numbermp3 != 0)
                {
                    int totaltvdvdmp3 = (numbertv * 900) + (numberdvd * 500) + (numbermp3 * 700);
                    if (totaltvdvdmp3 > 10000)
                    {
                        int total1= (numbertv *900 * 85 / 100)+ (numberdvd * 500 * 85 / 100)+ (numbermp3 * 700);
                        Console.WriteLine("Total price = ${0:#,#}", total1);
                    }
                    else if (totaltvdvdmp3 > 10000)
                    {
                        int total2 = (numbertv * 900 * 90 / 100) + (numberdvd * 500 * 90 / 100) + (numbermp3 * 700);
                        Console.WriteLine("Total price = ${0:#,#}", total2);
                    }
                    else

                        Console.WriteLine("Total price = ${0:#,#}", totaltvdvdmp3);
                }
            }
        }

    }

}
