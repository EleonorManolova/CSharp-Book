using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 3 == 1)
                    sum1 += num;
                if (i % 3 == 2)
                    sum2 += num;
                if (i % 3 == 0)
                    sum3 += num;
            }
            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
