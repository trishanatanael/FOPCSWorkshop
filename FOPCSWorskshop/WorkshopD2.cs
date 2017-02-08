using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    using System;
    class WorkshopD2
    {
        public static void Main()
        {
            int myIntA, myIntB, fact, lcm;
            string myInputA, myInputB;

            Console.Write("Please enter a number for variable A: ");
            myInputA = Console.ReadLine();
            myIntA = Int32.Parse(myInputA);

            Console.Write("Please enter another number for variable B: ");
            myInputB = Console.ReadLine();
            myIntB = Int32.Parse(myInputB);

            fact = myIntA * myIntB;

            while (myIntA != myIntB)
            {
                if (myIntA < myIntB)
                {
                    Console.WriteLine("B is bigger than A");
                    myIntB = myIntB - myIntA;
                }
                else
                {
                    Console.WriteLine("A is bigger than B");
                    myIntA = myIntA - myIntB;
                }
            }
            lcm = fact / myIntA;
            Console.WriteLine("The LCM is {0}", lcm);
        }
    }
}

