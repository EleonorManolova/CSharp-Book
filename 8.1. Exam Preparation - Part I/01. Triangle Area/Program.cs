using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());
            var s = 0.00;
            s = Math.Abs(x2 - x3) * Math.Abs(y2 - y1) / 2.0;
            Console.WriteLine(s);
        }
    }
}
