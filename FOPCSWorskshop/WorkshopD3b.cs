using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopD3b
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
                    guess = true;
                   
                        switch (trial)
                        {
                            case 1:
                                Console.WriteLine("You are a Wizard!"); break;
                            case 2:
                                Console.WriteLine("You are a Wizard!"); break;
                            case 3:
                                Console.WriteLine("You are a good guess"); break;
                            case 4:
                                Console.WriteLine("You are a good guess"); break;
                            case 5:
                                Console.WriteLine("You are a good guess"); break;
                            default:
                                Console.WriteLine("You are lousy!"); break;
                        }
                        break;

                }
                else
                    {
                    Console.WriteLine("Try again");
                    guess = false;
                }
               
            }
            

        }
    }
}
