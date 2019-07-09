using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) /2), new string('#', n));
            for (int row = 1; row <= n - 2; row++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', (n - 1) / 2), new string('.', n - 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('#', (n + 1) / 2), new string('.', n - 2));
            var dotsOut = 1;
            var dotsIn = 2 * n - 5;
            for (int row = 1; row <= n - 2; row++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dotsOut), new string('.', dotsIn));
                dotsOut++;
                dotsIn -= 2;
            }
            Console.WriteLine("{0}#{0}", new string('.', dotsOut));
        }
    }
}
