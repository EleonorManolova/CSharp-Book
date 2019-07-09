
namespace numsTo100inText
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string[] tonineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] toninety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (num < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else if (num > 100)
            {
                Console.WriteLine("Invalid number");
            }
            else if (num >= 0 && num <= 19)
            {
                Console.WriteLine(tonineteen[num]);
            }
            else if (num >= 20 && num < 100)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine(toninety[(num / 10) - 2]);
                }
                else
                {
                    Console.WriteLine(toninety[(num / 10) - 2] + " " + tonineteen[(num % 10)]);

                }
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
        }
    }
}