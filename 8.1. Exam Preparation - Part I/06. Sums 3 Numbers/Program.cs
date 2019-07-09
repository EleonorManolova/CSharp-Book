using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var max = Math.Max(Math.Max(n1, n2), Math.Max(n2,n3));
            var min = Math.Min(Math.Min(n1, n2), Math.Min(n2, n3));
            var middle = n1 + n2 + n3 - min - max;
            if (min + middle == max)
            {
                Console.WriteLine("{0} + {1} = {2}", min, middle, max);
            }
            else Console.WriteLine("No");
        }
    }
}
