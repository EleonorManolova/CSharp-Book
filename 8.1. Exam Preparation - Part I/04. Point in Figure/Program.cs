namespace _04.Point_in_Figure
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var insideLeft = (x >= 2 && x <= 12) &&
                (y >= -3 && y <= 1);
            var insideRight = (x >= 4 && x <= 10) &&
                (y >= -5 && y <= 3);

            if (insideLeft || insideRight)
            {
                Console.WriteLine("in");
            }
            else Console.WriteLine("out");
        }
    }
}
