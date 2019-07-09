using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double sumEven = 0.00;
            double sumOdd = 0.00;
            double sumOdd2 = 0.00;
            int moneyForBirthday = 10;
            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    sumEven += moneyForBirthday;
                    moneyForBirthday += 10;
                    sumEven = sumEven - 1;
                }
                else
                {
                    sumOdd += 1;
                }
            }
            sumOdd2 = sumOdd * toyPrice;
            
            Console.WriteLine((sumOdd2 + sumEven) >= washingPrice ? 
                $"Yes! {(sumEven + sumOdd2 - washingPrice):0.00}"
                : $"No! {(washingPrice - sumOdd2 - sumEven):0.00}");
        }
    }
}
