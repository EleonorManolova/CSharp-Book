namespace SleepyCatTom
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int dayoff = int.Parse(Console.ReadLine());
            var gameMin = (365 - dayoff) * 63 + dayoff * 127;
            var difference = 30000 - gameMin;
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
