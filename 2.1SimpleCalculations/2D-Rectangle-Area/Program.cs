namespace _2D_Rectangle_Area
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var area = (Math.Max(x1, x2) - Math.Min(x1, x2)) * (Math.Max(y1, y2) - Math.Min(y1, y2));
            var perimeter = 2 * ((Math.Max(x1, x2) - Math.Min(x1, x2)) + (Math.Max(y1, y2) - Math.Min(y1, y2)));
            Console.Write(area);
            Console.WriteLine(perimeter);
        }
    }
}
