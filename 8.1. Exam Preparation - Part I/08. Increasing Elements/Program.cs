using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxsum = 0;
            var prev = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if ((i == 0) || (num > prev))
                {
                    sum++;
                }
                else
                    sum = 1;
                if (sum > maxsum) maxsum = sum;
                prev = num;

            }
            Console.WriteLine(maxsum);
        }
    }
}
