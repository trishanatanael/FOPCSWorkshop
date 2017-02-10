using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE2
    { 
 
        public static void Main()
        { 
            E2PrintHeader();
            double i = 1.0;
            double inverse = 0.0, akar2 = 0.0, kuadrat = 0.0;
            for (i = 1.0; 10.0 >= i; i++)
            {
                inverse = 1 / i;
                akar2 = Math.Sqrt(i);
                kuadrat = Math.Pow(i, 2);
                Console.WriteLine("{0:0.0}\t\t\t{1:0.0##}\t\t\t{2:0.0##}\t\t\t{3:0.0}", i, inverse, akar2, kuadrat);
            }

        }
 
        public static void E2PrintHeader()
        { 
            Console.WriteLine("NO\t\t\tINVERSE\t\t\tSQUARE ROOT\t\t\tSQUARE");
            for (int i = 0; 45 >= i; i++)
            { Console.Write("- ");
                
            }
            Console.WriteLine("");

        }
    }
}
