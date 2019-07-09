using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var first = (n/100 % 10);
            var second = (n / 10 % 10);
            var last = (n % 10);
            // Console.WriteLine("{0} {1}",N, M);

            for (int row = 1; row <= first+second; row++)
            {
                for (int col = 1; col <= first+last; col++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - first;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - second;
                    }
                    else
                    {
                        n = n + last;
                    }
                    Console.Write("{0} ",n);
                   
                }
                Console.WriteLine();
            }
        }
    }
}
