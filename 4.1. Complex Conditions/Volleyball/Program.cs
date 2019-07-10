namespace Volleyball
{
    using System;

    public class Program
    {
        public static void Main()
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
