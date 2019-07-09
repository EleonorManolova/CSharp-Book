using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int rabotnici = int.Parse(Console.ReadLine());
            double m2 = 40 / 100.0 * x;
            double grape = m2 * y;
            var wine = grape / 2.5;
            var left = Math.Abs(wine - z);
            if (wine - z < 0)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(left));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(left), Math.Ceiling(left / rabotnici));
            }

        }
    }
}
