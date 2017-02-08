using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopA
    {
        public static void Main()
        {
            System.Console.WriteLine("Name: Trisha Natanael");
            System.Console.WriteLine("Email: tcnatanael@gmail.com");

            string name = Console.ReadLine();
            Console.WriteLine("Good Morning, {0}", name);

            int a = 10;
            Console.WriteLine(Math.Pow(a,2));

            double b = 44.98;
            Console.WriteLine(Math.Pow(b, 2));

            double c = 100.1;
            Console.WriteLine("{0:0.00}",c);
            double c1 = 0;
            Console.WriteLine("{0:0.00}", c1);
            double c2 = 3.232;
            Console.WriteLine("{0:0.00}", c2);
            double c3 = 4.555;
            Console.WriteLine("{0:0.00}", c3);


        }
    }
}
