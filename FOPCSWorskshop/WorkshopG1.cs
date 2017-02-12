using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopG1
    {
        public static void Main()
        {
            int noA = 0, noE = 0, noI = 0, noO = 0, noU = 0, total = 0;
            Console.WriteLine("Input a phrase: ");
            string input = Console.ReadLine();
            int i;
            string hi = input.ToUpper();
            for (i = 0; i < hi.Length; i++)
            {
                if (hi[i] == 'A')
                {
                    noA++;
                }
                else if (hi[i] == 'E')
                {
                    noE++;
                }
                else if (hi[i] == 'I')
                {
                    noI++;
                }
                else if (hi[i] == 'O')
                {
                    noO++;
                }
                else if (hi[i] == 'U')
                {
                    noU++;
                }
            }
            total = noA + noE + noI + noO + noU;

            Console.WriteLine("Total vowels:\t{5}\n{0}\tA\n{1}\tE\n{2}\tI\n{3}\tO\n{4}\tU", noA, noE, noI, noO, noU,total);

            return;
        }
    }
}
