using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var front = 3 * n;
            Console.WriteLine("{0}**{1}", new string('-', front), new string('-', 5 * n - 2 - front));
            var middle = 0;
            for (int row = 0; row < n-1; row++)
            {
                middle++;
                Console.WriteLine("{0}*{1}*{2}", new string('-', front), new string('-', middle), new string('-', 5 * n - 2 - front -middle));
                
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', front), new string('-', middle), new string('-', 5 * n - 2 - front - middle));
            }
           
            for (int row = 1; row <= n / 2; row++)
            {
                if (row != n/2)
                    Console.WriteLine("{0}*{1}*{2}", new string('-', front), new string('-', middle), new string('-', 5 * n - 2 - front - middle));
                
                else
                    Console.WriteLine("{0}*{1}*{2}", new string('-', front), new string('*', middle), new string('-', 5 * n - 2 - front - middle));
                middle += 2;
                front--;
            }
        }
    }
}
