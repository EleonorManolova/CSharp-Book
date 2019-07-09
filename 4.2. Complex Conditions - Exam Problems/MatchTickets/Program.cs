namespace MatchTickets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            decimal transport = 0.00M;
            decimal moneyForTickets = 0.00M;
            decimal moneyDifference = 0.00M;

            if (people <= 4)
                transport = 0.75M * budget;
            else if (people <= 9)
                transport = 0.60M * budget;
            else if (people <= 24)
                transport = 0.50M * budget;
            else if (people <= 49)
                transport = 0.40M * budget;
            else if (people >= 50)
                transport = 0.25M * budget;

            switch (category)
            {
                case "Normal":
                    moneyForTickets = people * 249.99M;
                    break;
                case "VIP":
                    moneyForTickets = people * 499.99M;
                    break;
                default:
                    moneyForTickets = people * 249.99M;
                    break;
            }

            moneyDifference = budget - transport - moneyForTickets;

            string result = string.Format("Yes! You have {0:F2} leva left.", decimal.Round(moneyDifference, 2));

            if (moneyDifference < 0)
            {
                result = string.Format("Not enough money! You need {0:F2} leva.", Math.Abs(decimal.Round(moneyDifference, 2)));
            }

            Console.WriteLine(result);
        }
    }
}
