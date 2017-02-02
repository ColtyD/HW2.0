using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._0
{
    class NumberToWords
    {
        public static string NumberToWord(int number)
        {

            // This will check the number that gets passed to it
            if (number == 0)
                return "zero";

            if (number < 0)
                return "negative" + NumberToWord(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWord(number / 1000000) + "million";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWord(number / 1000) + "thousand";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWord(number / 100) + "hundred";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and";
                
                // array of the default words that you have to have to make the rest of them
                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number]; // numbers less than twenty are mapped out
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
