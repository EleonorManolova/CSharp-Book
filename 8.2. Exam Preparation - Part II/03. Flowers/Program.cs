using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var boughtChrys = int.Parse(Console.ReadLine());
            var boughtRose = int.Parse(Console.ReadLine());
            var boughtTulip = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var holiday = Console.ReadLine().ToLower();

            var priseChrys = 0.00;
            var priseRose = 0.00;
            var priseTulip = 0.00;

            if (season == "summer" || season == "spring")
            {
                priseChrys = 2;
                priseRose = 4.1;
                priseTulip = 2.5;
            }
            else
            {
                priseChrys = 3.75;
                priseRose = 4.5;
                priseTulip = 4.15;
            }
            if (holiday == "y")
            {
                priseChrys = priseChrys + 0.15 * priseChrys;
                priseRose = priseRose + 0.15 * priseRose;
                priseTulip = priseTulip + 0.15 * priseTulip;
            }
            double sum = priseChrys * boughtChrys + priseRose * boughtRose + priseTulip*boughtTulip;
            if (boughtTulip > 7 && season == "spring")
                sum = sum - 0.05 * sum;
            if (boughtRose >= 10 && season == "winter")
                sum = sum - 0.1 * sum;
            if (boughtTulip + boughtRose + boughtChrys > 20)
                sum = sum - 0.2 * sum;
            Console.WriteLine("{0:f2}", sum +2);
        }
    }
}
