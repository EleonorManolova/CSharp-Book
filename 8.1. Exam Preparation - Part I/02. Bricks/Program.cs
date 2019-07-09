namespace _02.Bricks
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var brick = double.Parse(Console.ReadLine());
            var worker = double.Parse(Console.ReadLine());
            var volume = double.Parse(Console.ReadLine());
            double sum = brick / (worker * volume);
            Console.WriteLine(Math.Ceiling(sum));
        }
    }
}
