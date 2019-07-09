using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double course = double.Parse(Console.ReadLine());
            double salary = (12 + 2.5) * N * M;
            double taxes = 25 / 100.00 * salary;
            double result = (salary - taxes) / 365;
            Console.WriteLine(Math.Round(result * course,2));

        }
    }
}
