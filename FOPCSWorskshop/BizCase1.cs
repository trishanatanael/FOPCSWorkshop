using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class BizCase1
    {
        //– The manager of Dafesty Video Rental wanted to avoid frauds and hence noticed
        //that the customer bills in the computer printout gave invoice amount only in
        //numerals and not in words.
        //– You are appointed to provide a suitable program.
        //– Write a C# program that would take in as input a number and convert it into
        //words. Examples as below:
        //1324.00 Dollar One Thousand Three hundred and Twenty Four only.
        // 463.25 Dollar Four hundred and Sixty Three and Cents Twenty Five only
        //HINT:
        // - Try to achieve as close an answer as possible.
        // - Make assumptions/simplification in case of difficulty.
        // - You are told that the bill will always be less than 10000.
        // - Try to design an efficient methodology using computational logic
        // to the maximum extent.
        public static void Main()
        {
            Console.WriteLine("Please enter the amount ($$$$.¢¢): ");
            string input = Console.ReadLine();
            string dollars = "";
            string cents = "";
            string outputDol = "";
            string outputCent = "";
            double doubInput = Convert.ToDouble(input);
            int firstD = 0;
            int secondD = 0;
            int thirdD = 0;
            int fourthD = 0;
            int getDolLength = 0;
            int getCentLength = 0;
            int intDollars = 0;
            int intCents = 0;
            bool boolCent;
       

            //splitting the . and if boolcent = true
            if (input.Contains('.'))
            {
                string[] digits = input.Split('.');
                dollars += digits[0];
                cents += digits[1];
                boolCent = true;
                getDolLength += dollars.Length;
                getCentLength += cents.Length;
                intDollars += Convert.ToInt32(dollars);
                intCents += Convert.ToInt32(cents);
            }
            else
            {
                dollars += Convert.ToInt32(input);
                boolCent = false;
                getDolLength += dollars.Length;
                intDollars += Convert.ToInt32(dollars);
            }

            //for dollars
            if (getDolLength > 0 && doubInput<10000)
            {
                if (getDolLength == 1)
                {
                    string[] nineD = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    fourthD += intDollars;
                    outputDol += nineD[fourthD];
                    return;
                }
                else if (getDolLength == 2)
                {
                    if (intDollars < 20)
                    {
                        string[] teen = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                        fourthD = Convert.ToInt32(dollars.Substring(1, 1));
                        outputDol += teen[fourthD];
                        Console.WriteLine("5");
                        return;
                    }
                    else
                    {
                        string[] ty = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                        string[] nineD = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                        thirdD = Convert.ToInt32(dollars.Substring(0, 1));
                        fourthD = Convert.ToInt32(dollars.Substring(1, 1));
                        outputDol += ty[thirdD - 2] + nineD[fourthD];
                        Console.WriteLine("6");
                        return;
                    }
                }
                else if (getDolLength == 3)
                {
                    string[] ty = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                    string[] teen = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    string[] nineD = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    secondD = Convert.ToInt32(dollars.Substring(0, 1));
                    thirdD = Convert.ToInt32(dollars.Substring(1, 1));
                    fourthD = Convert.ToInt32(dollars.Substring(2, 1));
                    if (thirdD == 1)
                    {
                        outputDol += nineD[firstD] + " thousand " + nineD[secondD] + " hundred " + teen[fourthD];
                        Console.WriteLine("9a");
                        return;
                    }
                    else
                    {
                        outputDol += nineD[firstD] + " thousand " + nineD[secondD] + " hundred " + ty[thirdD] + " " + nineD[fourthD];
                        Console.WriteLine(outputDol);
                        Console.WriteLine("10b");
                        return;
                    }
                }
               else
                {
                    string[] ty = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                    string[] teen = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    string[] nineD = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    firstD = Convert.ToInt32(dollars.Substring(0, 1));
                    secondD = Convert.ToInt32(dollars.Substring(1, 1));
                    thirdD = Convert.ToInt32(dollars.Substring(2, 1));
                    fourthD = Convert.ToInt32(dollars.Substring(3, 1));
                    Console.WriteLine("8");
                    if (thirdD == 1)
                    {
                        outputDol += nineD[firstD] + " thousand " + nineD[secondD] + " hundred " + teen[fourthD];
                        Console.WriteLine("9");
                        return;
                    }
                    else
                    {
                        outputDol += nineD[firstD] + " thousand " + nineD[secondD] + " hundred " + ty[thirdD] + " " + nineD[fourthD];
                        Console.WriteLine("10");
                        return;
                    }
                }
            }

            //for cents

            if (boolCent)
            {
                int firstC = Convert.ToInt32(cents.Substring(0, 1));
                if (firstC == 0)
                {
                    string[] cen = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    outputCent += " And " + cen[firstC] + " Only";
                    Console.WriteLine("11");
                    return;
                }
                else if (firstC == 1)
                {
                    string[] cen = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    int secondC = Convert.ToInt32(cents.Substring(1, 1));
                    outputCent += " And " + cen[secondC] + " Only";
                    Console.WriteLine("12");
                    return;
                }
                else
                {
                    string[] cenTy = new string[] { "Zero", "Ten","Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                    string[] cen = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    int secondC = Convert.ToInt32(cents.Substring(1, 1));
                    outputCent += " And " + cenTy[firstC] + " " + cen[secondC] + " Only";
                    return;
                }
                
            }
            else
            {
                outputCent += " Only";
                Console.WriteLine("14");
            }

            Console.WriteLine("{0} {1}",outputDol, outputCent);

        }

    }


}

