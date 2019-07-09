namespace _203.Bulls_and_Cows
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var secretNumber = int.Parse(Console.ReadLine());
            var bulls = int.Parse(Console.ReadLine());
            var cows = int.Parse(Console.ReadLine());
            bool solutionFound = false;

            var bullsCount = 0;
            var cowsCount = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                cowsCount = 0;
                bullsCount = 0;
                int guessDigit1 = secretNumber / 1000 % 10;
                int guessDigit2 = secretNumber / 100 % 10;
                int guessDigit3 = secretNumber / 10 % 10;
                int guessDigit4 = secretNumber % 10;

                int currentNumber = i;
                int currentNumber1 = currentNumber / 1000 % 10;
                int currentNumber2 = currentNumber / 100 % 10;
                int currentNumber3 = currentNumber / 10 % 10;
                int currentNumber4 = currentNumber % 10;
                if (currentNumber1 == 0 || currentNumber2 == 0 || currentNumber3 == 0 || currentNumber4 == 0)
                    continue;

                int digitToCheck1 = currentNumber1;
                int digitToCheck2 = currentNumber2;
                int digitToCheck3 = currentNumber3;
                int digitToCheck4 = currentNumber4;

                if (digitToCheck2 == guessDigit2)
                {
                    bullsCount++;
                    guessDigit2 = -1;
                    digitToCheck2 = -2;
                }

                if (digitToCheck3 == guessDigit3)
                {
                    bullsCount++;
                    guessDigit3 = -1;
                    digitToCheck3 = -2;
                }

                if (digitToCheck1 == guessDigit1)
                {
                    bullsCount++;
                    guessDigit1 = -1;
                    digitToCheck1 = -2;
                }

                if (digitToCheck4 == guessDigit4)
                {
                    bullsCount++;
                    guessDigit4 = -1;
                    digitToCheck4 = -2;
                }

                if (digitToCheck1 == guessDigit2)
                {
                    cowsCount++;
                    guessDigit2 = -1;
                    digitToCheck1 = -2;
                }

                if (digitToCheck1 == guessDigit3)
                {
                    cowsCount++;
                    guessDigit3 = -1;
                    digitToCheck1 = -2;
                }

                if (digitToCheck1 == guessDigit4)
                {
                    cowsCount++;
                    guessDigit4 = -1;
                    digitToCheck1 = -2;
                }

                if (digitToCheck2 == guessDigit1)
                {
                    cowsCount++;
                    guessDigit1 = -1;
                    digitToCheck2 = -2;
                }

                if (digitToCheck2 == guessDigit3)
                {
                    cowsCount++;
                    guessDigit3 = -1;
                    digitToCheck2 = -2;
                }

                if (digitToCheck2 == guessDigit4)
                {
                    cowsCount++;
                    guessDigit4 = -1;
                    digitToCheck2 = -2;
                }

                if (digitToCheck3 == guessDigit2)
                {
                    cowsCount++;
                    guessDigit2 = -1;
                    digitToCheck3 = -2;
                }

                if (digitToCheck3 == guessDigit1)
                {
                    cowsCount++;
                    guessDigit1 = -1;
                    digitToCheck3 = -2;
                }

                if (digitToCheck3 == guessDigit4)
                {
                    cowsCount++;
                    guessDigit4 = -1;
                    digitToCheck3 = -2;
                }

                if (digitToCheck4 == guessDigit2)
                {
                    cowsCount++;
                    guessDigit2 = -1;
                    digitToCheck4 = -2;
                }

                if (digitToCheck4 == guessDigit3)
                {
                    cowsCount++;
                    guessDigit3 = -1;
                    digitToCheck4 = -2;
                }

                if (digitToCheck4 == guessDigit1)
                {
                    cowsCount++;
                    guessDigit1 = -1;
                    digitToCheck4 = -2;
                }

                if (bullsCount == bulls && cowsCount == cows)
                {
                    if (solutionFound)
                        Console.Write(" ");
                    Console.Write($"{i}");
                    solutionFound = true;
                }
            }

            if (!solutionFound)
                Console.WriteLine("No");
        }
    }
}
