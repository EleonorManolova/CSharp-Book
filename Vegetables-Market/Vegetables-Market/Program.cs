namespace Vegetables_Market
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int kgveg = int.Parse(Console.ReadLine());
            int kgfr = int.Parse(Console.ReadLine());
            double resultveg = vegetables * kgveg;
            double resultfr = fruits * kgfr;
            double result = (resultfr + resultveg) / 1.94;
            Console.WriteLine(result);
        }
    }
}
