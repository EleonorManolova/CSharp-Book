namespace ChangeTiles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());
            double square = N * N - M * O;
            double number = square / (W * L);
            double time = number * 0.2;
            Console.WriteLine(number);
            Console.WriteLine(time);
        }
    }
}
