namespace Currency_Converter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var sum = double.Parse(Console.ReadLine());
            var currency1 = Console.ReadLine();
            var currency2 = Console.ReadLine();
            var sumBGN = sum;
            if (currency1 == "USD")
                sumBGN = sum * 1.79549;
            else if (currency1 == "EUR")
                sumBGN = sum * 1.95583;
            else if (currency1 == "GBP")
                sumBGN = sum * 2.53405;

            if (currency2 == "BGN")
                Console.WriteLine("{0} {1}", Math.Round(sumBGN, 2), currency2);
            else if (currency2 == "USD")
                Console.WriteLine("{0} {1}", Math.Round(sumBGN / 1.79549, 2), currency2);
            else if (currency2 == "EUR")
                Console.WriteLine("{0} {1}", Math.Round(sumBGN / 1.95583, 2), currency2);
            else if (currency2 == "GBR")
                Console.WriteLine("{0} {1}", Math.Round(sumBGN / 2.53405, 2), currency2);
        }
    }
}
