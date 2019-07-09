namespace Perimeter_Circle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            var perimeter = Math.PI * 2 * radius;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
