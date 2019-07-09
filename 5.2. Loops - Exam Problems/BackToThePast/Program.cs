using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal heirMoney = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 18;

            decimal currMoney = 0.00m;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    heirMoney -= 12000m;
                }
                else
                    heirMoney -= (12000m + 50 * age);
                age++;
            }
            Console.WriteLine(heirMoney >= currMoney ? 
                $"Yes! He will live a carefree life and will have {heirMoney:0.00} dollars left." 
                : $"He will need {Math.Abs(heirMoney):0.00} dollars to survive.");
        }
    }
}
