using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102.Magic_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startYear = int.Parse(Console.ReadLine());
            var endYear = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            bool result = true;

            for (int year = startYear; year <= endYear; year++)
            {
                sum += year;
                for (int month = 1; month <= 12; month++)
                {
                    sum += month * 10000;
                    for (int date = 1; date <= 31; date++)
                    {
                        
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (date == 31) break;
                        }
                        if (month == 2)
                        {
                            if (date == 29 && year % 4 != 0) break;
                            else if (date == 30) break;
                        }
                        sum += date * 1000000;

                        var d8 = sum % 10;
                        var d7 = sum / 10 % 10;
                        var d6 = sum / 100 % 10;
                        var d5 = sum / 1000 % 10;
                        var d4 = sum / 10000 % 10;
                        var d3 = sum / 100000 % 10;
                        var d2 = sum / 1000000 % 10;
                        var d1 = sum / 10000000 % 10;
                        var Number = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                            d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                            d3 * (d4 + d5 + d6 + d7 + d8) +
                            d4 * (d5 + d6 + d7 + d8) +
                            d5 * (d6 + d7 + d8) +
                            d6 * (d7 + d8) +
                            d7 * d8;

                        //Console.WriteLine(sum);
                        if (Number == magicNumber)
                        {
                            Console.WriteLine("{0:00-00-0000}", sum);
                            result = false;
                        }
                        sum = sum - date * 1000000;
                    }
                    sum = sum - month * 10000;
                }
                sum = sum - year * 1;
            }
            if (result) Console.WriteLine("No");
        }
    }
}
