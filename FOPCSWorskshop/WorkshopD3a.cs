using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopD3a
    {
        public static void Main()
        {
            Random num = new Random();
            int randNum = num.Next(0, 10);
            int trial = 0;

            bool guess = false;
            while (!guess)
            {
                ++trial;
                Console.Write("Guess the Number. Input your guess(0-9): ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == randNum)
                {
                    Console.WriteLine("Congrat\'s you got it right!");
                    Console.WriteLine("Attempt took {0}", trial);
                    break;
                
                }
                else
                    Console.WriteLine("Please try again.");
                    guess = false;
               
            }
            

        }
    }
}
