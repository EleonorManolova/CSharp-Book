namespace _201.Passion_Days
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            var enter = Console.ReadLine();
            var count = 0;
            decimal price = 0.00m;
            while (enter != "mall.Enter")
            {
                enter = Console.ReadLine();
            }

            while (true)
            {
                string purchase = Console.ReadLine();
                char[] charPurchase = purchase.ToCharArray();
                if (purchase == "mall.Exit")
                    break;

                for (int i = 0; i < charPurchase.Length; i++)
                {
                    char letter = charPurchase[i];

                    if (letter >= 'A' && letter <= 'Z')
                        price = 0.5m * letter;
                    else if (letter >= 'a' && letter <= 'z')
                        price = 0.3m * letter;
                    else if (letter == '%')
                        price = money / 2.0m;
                    else if (letter == '*')
                    {
                        money += 10;
                        continue;
                    }
                    else
                        price = letter;

                    if (money < price || money == 0) continue;

                    money -= price;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine($"No purchases. Money left {money:f2} lv.");
            }
            else
                Console.WriteLine($"{count} purchases. Money left: {money:f2} lv.");
        }
    }
}
