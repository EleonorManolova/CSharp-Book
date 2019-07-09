using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                    p1 += 1;
                else if (num < 400)
                    p2 += 1;
                else if (num < 600)
                    p3 += 1;
                else if (num < 800)
                    p4 += 1;
                else if (num >= 800)
                    p5 += 1;

            }
            Console.WriteLine("{0:0.00}%", p1 / n * 100);
            Console.WriteLine("{0:0.00}%", p2 / n * 100);
            Console.WriteLine("{0:0.00}%", p3 / n * 100);
            Console.WriteLine("{0:0.00}%", p4 / n * 100);
            Console.WriteLine("{0:0.00}%", p5 / n * 100);
        }   
    }
}
