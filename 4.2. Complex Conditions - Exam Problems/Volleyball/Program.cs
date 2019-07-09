using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holiday = int.Parse(Console.ReadLine());
            var weekend = int.Parse(Console.ReadLine());

            var saturday = (48 - weekend) * 3 / 4.0 + 2 / 3.0 * holiday;
            var sunday = weekend;

            switch (year)
            {
                case "normal":
                    Console.WriteLine(Math.Floor(saturday + sunday));
                    break;
                case "leap":
                    Console.WriteLine(Math.Floor(saturday + sunday + 15 / 100.0 * (saturday + sunday)));
                    break;
            }
        }
         
    }
}
