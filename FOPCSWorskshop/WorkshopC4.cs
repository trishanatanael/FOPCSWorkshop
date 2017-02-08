using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopC4
    {
        public static void Main()
        {
            Console.Write("What's your travelling distance (in Km)?");
            double totaldistance = Convert.ToDouble(Console.ReadLine());
            double charge05 = 2.40;

            if (totaldistance <= 0.5)
            {

                Console.WriteLine("${0:0.0}", charge05);
            }
            else if (0.5 < totaldistance && totaldistance <= 9)
            {
                double to85meters = (totaldistance - 0.5)*100;
                double dollarroundup= Math.Ceiling(to85meters)/10*0.04;
                double charge9 = (charge05 + dollarroundup);
                Console.WriteLine("${0:0.0}", charge9);
            }
            else if (totaldistance > 9)
            {
                double over9 = (totaldistance - 9)*100;
                double dollarroundup9 = Math.Ceiling(over9)/10*0.05;
                double chargeover9 = 5.80+dollarroundup9; 
                Console.WriteLine("${0:0.0}", chargeover9);


            }
        }

    }

}
