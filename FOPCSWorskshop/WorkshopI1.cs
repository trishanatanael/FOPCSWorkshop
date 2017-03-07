using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopI1
    {
        public static void Main()
        {
            /*You are required to take as input an amount (dollar.cents).Assume that the amount
is between 5 cents(inputted as 0.05) and 3 dollars 50 cents(inputted as 3.50).
Further assume that we would always input nearest to 5 cents(i.e., values like 2.23
are not keyed in).The duty of your program is to dispense this amount(accurately!)
using a combination of coins. We have coins of denomination 100, 50, 20, 10 and 5
cents.More than one coin of a denomination can be used. Yeah I know what you
are thinking – simply issue all five cent coins; right? Cannot ma - easy but no
challenge.We are requesting the program to use the “minimum - number - of - coins”
principle.For example, if a request were made for 1.95 then the computer would
issue one 100 - cent coin, one 50 - cent coin, two 20 - cent coins and one 5 - cent coin.
The trick is to always start with the largest denomination and slowly go down.Try
your luck – but don’t loose money!*/

            Console.WriteLine("Please enter amount: ");

            string inputAmount = Console.ReadLine();
            bool iCond = inputAmount.Length == 3;
            double inputCheck = double.Parse(inputAmount);

            if (iCond)
            {
                inputAmount= inputAmount+ 0.01;
            }

            if (inputCheck >= 0.05 && inputCheck <= 3.50)

                minCoinsOut(inputAmount);
            else
                Console.WriteLine("Please enter amount between 0.05 to 3.50");
        }
        static void minCoinsOut(string input)
        {
            int firstDigit = 0;
            int bhdDot = 0;
            int fifthyC = 0 , twentyC = 0, fiveC = 0;

            if (input.Length == 1)
                firstDigit = int.Parse(input);
            else
            {
                int.TryParse(input.Split('.')[0], out firstDigit);
                int.TryParse(input.Split('.')[1], out bhdDot);
                bhdDot = (int)Math.Round(bhdDot / 5.0) * 5; //interesting method. need to note
            }

            if (bhdDot != 0)
            {
                while (bhdDot >= 50)
                {
                    bhdDot = bhdDot - 50;
                    fifthyC++;
                }
                while (bhdDot >= 20)
                {
                    bhdDot = bhdDot - 20;
                    twentyC++;
                }
                while (bhdDot >= 5)
                {
                    bhdDot = bhdDot - 5;
                    fiveC++;
                }
            }
            else
            {
                fifthyC = 0;
                twentyC = 0;
                fiveC = 0;
            }

            Console.WriteLine("Issue ({0}) 100-cent coin, ({1}) 50-cent coin, ({2}) 20-cent coins and ({3}) 5-cent coin", firstDigit,fifthyC,twentyC,fiveC);

            //The trick is to always start with the largest denomination and slowly go down.
            //output: “minimum - number - of - coins”
        }
    }
}

