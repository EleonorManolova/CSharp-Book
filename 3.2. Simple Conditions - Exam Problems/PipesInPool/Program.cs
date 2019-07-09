namespace PipesInPool
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double vfull = (p1 + p2) * h;
            if (vfull <= v)
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(vfull / v * 100),
                    Math.Truncate(p1 * h / vfull * 100),
                    Math.Truncate(p2 * h / vfull * 100));
            else
            {
                Console.WriteLine("For " + h + " hours the pool overflows with " + (vfull - v) + " liters.");
            }
        }
    }
}
