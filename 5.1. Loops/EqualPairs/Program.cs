using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int cursum = 0;
            int prsum = 0;
            int maxDiff = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                prsum = cursum;
                cursum = 0;
                cursum += int.Parse(Console.ReadLine());
                cursum += int.Parse(Console.ReadLine());
                if (i > 0)
                {
                    diff = Math.Abs(cursum - prsum);
                    if (diff > maxDiff && diff != 0)
                        maxDiff = diff;
                }

            }
            if (prsum == cursum || n == 1)
                Console.WriteLine("Yes, value={0}", cursum);
            else
                Console.WriteLine("No, maxdiff={0}", maxDiff);

        }
    }
}
