using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m2 = l * (w - 1);
            var Result = (m2 / (0.7 * 1.2)) - 3;
            Console.WriteLine(Math.Truncate(Result));

        }
    }
}
