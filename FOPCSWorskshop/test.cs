using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class test
    {
        public static void Main()
        {
            string input;
            int cA = 0, cE = 0, cI = 0, cO = 0, cU = 0;
            int cTotal;
            //Console.WriteLine('a' - 'A');

            Console.Write("Please enter a line: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' || input[i] == 'a')
                {
                    cA++;
                }
                else if (input[i] == 'E' || input[i] == 'e')
                {
                    cE++;
                }
                else if (input[i] == 'I' || input[i] == 'i')
                {
                    cI++;
                }
                else if (input[i] == 'O' || input[i] == 'o')
                {
                    cO++;
                }
                else if (input[i] == 'U' || input[i] == 'u')
                {
                    cU++;
                }
            }

            cTotal = cA + cE + cI + cO + cU;

            Console.WriteLine("Total vowels: {0}\nA: {1}\nE: {2}\nI: {3}\nO: {4}\nU: {5}", cTotal, cA, cE, cI, cO, cU);

            return;

        }
    }
}
