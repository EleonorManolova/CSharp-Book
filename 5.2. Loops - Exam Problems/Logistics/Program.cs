using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currency = 0.0;
            double sum = 0.0;
            double sumtons = 0.0;
            double microbus = 0.0;
            double truck = 0.0;
            double train = 0.0;

            for (int i = 0; i < n; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    currency = 200;
                    microbus += tons;
                }

                else if (tons <= 11)
                {
                    currency = 175;
                    truck += tons;
                }
                else
                {
                    currency = 120;
                    train += tons;
                }

                sum += currency * tons;
                sumtons += tons;

            }
            Console.WriteLine("{0:0.00}", sum / sumtons);
            Console.WriteLine("{0:0.00}%", microbus / sumtons * 100);
            Console.WriteLine("{0:0.00}%", truck / sumtons * 100);
            Console.WriteLine("{0:0.00}%", train / sumtons * 100);
        }
    }
}
