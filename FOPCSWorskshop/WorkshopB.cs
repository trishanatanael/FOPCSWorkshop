using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopB
    {
        public static void Main()
        {
            double d = 0;
            Console.WriteLine(Math.Pow(d, 0.5));
            double e = 25;
            Console.WriteLine(Math.Pow(e, 0.5));
            double f = 3;
            Console.WriteLine("{0:#.###}", (Math.Pow(f, 0.5)));

            double g = 0;
            Console.WriteLine("{0:0.000}", Math.Pow(g, 0.5));
            double h = 25;
            Console.WriteLine("{0:0.000}", Math.Pow(h, 0.5));
            double i = 3;
            Console.WriteLine("{0:0.000}", Math.Pow(i, 0.5));
            double j = 300;
            Console.WriteLine("{0:0.000}", Math.Pow(j, 0.5));

            double salary = 1000;
            double housing = (0.1 * salary);
            double transport = (0.03 * salary);
            double income = (salary + housing + transport);
            Console.WriteLine("${0: #,0.00}", income);

            double temp = 100;
            double farh = ((temp * 1.8) + 32);
            Console.WriteLine(farh);

            double x = 0;
            double y = ((5 * Math.Pow(x, 2)) - (4 * x) + 3);
            Console.WriteLine(y);

            double x1 = 1;
            double y1 = 1;
            double x2 = 10;
            double y2 = 1;
            double areax = Math.Pow((x2 - x1), 2);
            double areay = Math.Pow((y2 - y1), 2);
            double sqrt = (areax + areay);
            double distance = Math.Sqrt(sqrt);
            Console.WriteLine(distance);

            double taximin = 2.40;
            double taxikm = 10.23;
            double taxiextra = (taxikm * 0.4);
            double taxifare = (taximin + taxiextra);

            Console.WriteLine("{0}", taxifare);

            double charge = Math.Round(taxifare, 1);
            Console.WriteLine("{0:0.00}", charge);

            double charge9 = Math.Ceiling(taxifare*10) / 10;
            Console.WriteLine(charge9);

            double sidea = 1;
            double sideb = 1;
            double sidec = 3;
            double s = (sidea + sideb + sidec) / 2;
            double area = Math.Sqrt((s*(s-sidea)*(s-sideb)*(s-sidec)));
            Console.WriteLine("Invalid dmension, please check and input again");
            Console.WriteLine(area);
        }
    }
}