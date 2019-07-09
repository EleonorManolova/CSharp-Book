using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDort2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var colSize = n / 2;
            var midSize = 2 * n - 4 - 2 * colSize;
            Console.WriteLine("/{0}\\{1}/{0}\\",
                new string('^', colSize),
                new string('_', midSize));
        }
    }
}
