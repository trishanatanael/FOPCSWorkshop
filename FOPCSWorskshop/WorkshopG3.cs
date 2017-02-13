using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopG3
    {
        public static void Main()
        {
            Console.WriteLine("Input a phrase: ");
            string input = Console.ReadLine();
            //take care of first letter first.
            int i = 0;
            if (i == 0 && char.IsLetter(input[0]))
            {
                //replace the first character
                string a = Convert.ToString(input[0]);
                string aUp = a.ToUpper();
                var aStringBuilder = new StringBuilder(input);
                aStringBuilder.Remove(0, 1);
                aStringBuilder.Insert(0, aUp);
                input = aStringBuilder.ToString();
            }
            for (i =1; i < input.Length; i++)
            {
                if (input[i] == ' ' && (i + 1 < input.Length) && char.IsLetter(input[i + 1]))
                {
                            char b = input[i + 1];
                            string b2 = Convert.ToString(b);
                            string bUp = b2.ToUpper();
                            var aStringBuilder = new StringBuilder(input);
                            aStringBuilder.Remove((i+1), 1);
                            aStringBuilder.Insert((i+1), bUp);
                            input = aStringBuilder.ToString();

                }
            }

            Console.WriteLine("The final string: '{0}'", input);
        }
    }
}
