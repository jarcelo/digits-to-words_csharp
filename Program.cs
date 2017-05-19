using System;

namespace DigitsToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var TEN = 10;
            var ONE_HUNDRED = 100;
            var ONE_THOUSAND = 1000;
        
            var digits = int.Parse(Console.ReadLine());

            var thousands = digits / ONE_THOUSAND;
            var thousandsRemainder = digits % ONE_THOUSAND;

            var hundreds = thousandsRemainder / ONE_HUNDRED;
            var hundredsRemainder = thousandsRemainder % ONE_HUNDRED;

            var tens = hundredsRemainder / TEN;
            var tensRemainder = hundredsRemainder % TEN;

            var thousandsPart = (thousands > 0) ? onesArray[thousands] + " thousand " : "";
            var hunredsPart = (hundreds > 0) ? onesArray[hundreds] + " hundred " : "";

            var output = thousandsPart + hunredsPart + TranslateTens(hundredsRemainder);

            Console.WriteLine(output);
            Console.ReadLine();
        }

        private static string TranslateTens(int hundredsRemainder)
        {
            if(hundredsRemainder < 20) 
            {
                return onesArray[hundredsRemainder];
            }
            else 
            {
                var tens = hundredsRemainder / 10;
                var tensRemainder = hundredsRemainder % 10;
                return tensArray[tens] + " " + onesArray[tensRemainder];
            }
        }

        static string[] onesArray = new String[] {
            "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen"
        };

        static string[] tensArray = new String[] {
            "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };
    }
}
