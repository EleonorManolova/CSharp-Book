using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number <= 999 && number >= -999)
                {
                    Letterize(number);
                }
                else if (number > 999)
                    Console.WriteLine("too large");
                else if (number < -999)
                    Console.WriteLine("too small");

            }
        }

        static void Letterize(int number)
        {
            string[] tonineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] toninety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


            if (number < 0)
            {
                Console.Write("minus ");
                number *= -1;
            }

            if (number >= 0 && number <= 19)
            {
                //Console.WriteLine(tonineteen[number]);

            }
            else if (number >= 20 && number < 100)
            {
                //if (number % 10 == 0)
                //{
                //    Console.WriteLine(toninety[(number / 10) - 2]);
                //}
                //else
                //{
                //    Console.WriteLine(toninety[(number / 10) - 2] + " " + tonineteen[(number % 10)]);

                //}
            }
            else if (number >= 100 && number <= 999)
            {
                if (number % 100 == 0)
                {
                    Console.Write(tonineteen[(number / 100)]);
                    Console.Write("-hundred");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(tonineteen[(number / 100)]);
                    Console.Write("-hundred and ");
                    var number2 = number - number / 100 * 100;
                    if (number2 >= 0 && number2 <= 19)
                    {
                        Console.WriteLine(tonineteen[number2]);
                    }
                    else if (number2 >= 20 && number2 < 100)
                    {
                        if (number % 10 == 0)
                        {
                            Console.WriteLine(toninety[(number2 / 10) - 2]);
                        }
                        else
                        {
                            Console.WriteLine(toninety[(number2 / 10) - 2] + " " + tonineteen[(number2 % 10)]);
                        }
                    }
                }


            }

        }
    }
}
