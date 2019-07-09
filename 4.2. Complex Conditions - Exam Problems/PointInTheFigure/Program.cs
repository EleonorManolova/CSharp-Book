using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if (((0 < x && x < 3 * h) && (0 < y && y < h)) ||
                ((h < x && x < (2 * h)) && (0 < y && y < 4 * h)))
                Console.WriteLine("inside");
            else if (((x == 0 || x == 3 * h) && (0 <= y && y <= h)) ||
                ((x == 2 * h || x == h) && (h <= y && y <= 4 * h)))
                Console.WriteLine("border");
            else if ((y == 0 && (0 <=x && x <= 3 * h)) ||
                (y == 2 * h && (0 <= x && x <= h || 2 * h <=x && x <= 3 * h)) ||
                (y == 4 * h && (h <= x && x <= 2 * h)))
                Console.WriteLine("border");
            else
                Console.WriteLine("outside");
        }
    }
}
