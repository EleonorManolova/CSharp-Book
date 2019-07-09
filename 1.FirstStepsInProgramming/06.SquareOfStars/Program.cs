namespace _06.SquareOfStars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var rectangleSide = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', rectangleSide));
            for (int i = 0; i < rectangleSide - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', rectangleSide - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', rectangleSide));
        }
    }
}
