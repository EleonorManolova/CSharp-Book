using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayoff = int.Parse(Console.ReadLine());
            int gamemin = 0;
            int difference = 0;
            gamemin = ((365 - dayoff) * 63 + dayoff * 127);
            difference = 30000 - gamemin;
            if (difference < 0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(difference / 60), Math.Abs(difference % 60));
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
               // Console.WriteLine(Math.Abs(-1));
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Abs(difference / 60), Math.Abs(difference % 60));
            }

        }
    }
}
