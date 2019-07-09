namespace _02.Magic_Dates
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var startYear = int.Parse(Console.ReadLine());
            var endYear = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(startYear, 1, 1);
            var number = 0;
            var found = false;

            while (currentDate.Year <= endYear)
            {
                var d8 = currentDate.Year % 10;
                var d7 = currentDate.Year / 10 % 10;
                var d6 = currentDate.Year / 100 % 10;
                var d5 = currentDate.Year / 1000 % 10;
                var d4 = currentDate.Month % 10;
                var d3 = currentDate.Month / 10 % 10;
                var d2 = currentDate.Day % 10;
                var d1 = currentDate.Day / 10 % 10;
                number = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                    d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                    d3 * (d4 + d5 + d6 + d7 + d8) +
                    d4 * (d5 + d6 + d7 + d8) +
                    d5 * (d6 + d7 + d8) +
                    d6 * (d7 + d8) +
                    d7 * d8;
                if (number == magicNumber)
                {
                    Console.WriteLine(currentDate.ToString("dd-MM-yyyy"));
                    found = true;
                }

                currentDate = currentDate.AddDays(1);
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
