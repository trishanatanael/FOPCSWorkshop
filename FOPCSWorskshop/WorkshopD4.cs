using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopD4
    {
        public static void Main()
        {
            Console.WriteLine("Please input a number: ");
            //input=N
            int N = Convert.ToInt32(Console.ReadLine());
            Random randNum = new Random();
            double G = randNum.Next(1, N);
            Console.WriteLine(G);
            // how to create random number from 1 to n?
            double guess = G * G;
            double difference = 1;
            if (difference >0)
            {
                Console.WriteLine(guess);
            }
            else
            {
                G = (G + N / G) / 2;
                Console.WriteLine("Try again");
                Console.WriteLine(G);

            }

        }
    }
}
