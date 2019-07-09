namespace TicketPrice
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrnight = Console.ReadLine();
            double taxiRate;
            if (dayOrnight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            double price;
            if (distance < 20)
                price = 0.70 + distance * taxiRate;
            else if (distance < 100)
                price = 0.09 * distance;
            else
                price = 0.06 * distance;
            Console.WriteLine(price);
        }
    }
}
