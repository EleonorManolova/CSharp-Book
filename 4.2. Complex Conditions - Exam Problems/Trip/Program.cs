namespace Trip
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            double result = 0.00;
            string destination = "Bulgaria";

            if (budget <= 100)
            {
                if (season == "summer")
                    result = 0.3 * budget;
                else if (season == "winter")
                    result = 0.7 * budget;
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                    result = 0.4 * budget;
                else if (season == "winter")
                    result = 0.8 * budget;
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                result = 0.9 * budget;
            }

            string location = "Camp";

            if (season == "winter" || destination == "Europe")
            {
                location = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1}", location, string.Format("{0:0.00}", result));
        }
    }
}
