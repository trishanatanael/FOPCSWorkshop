using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE4
    {
        public static void Main()
        {
            int sum = 0;
            bool isPerfect = true;
            Console.WriteLine("Plear input a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
           
            List<int> factors = new List<int>();

            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                    factors.Add(i);
            }
            sum = factors.Sum();

            if (sum == input)
                isPerfect = true;
            else
                isPerfect = false;
            Console.WriteLine(isPerfect ? "{0} is a perfect number": "{0} is not a perfect number",input);
            return;
        }
    }
}