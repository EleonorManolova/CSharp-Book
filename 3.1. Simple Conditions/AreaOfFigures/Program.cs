namespace AreaOfFigures
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string figure = Console.ReadLine().ToLower();
            var size = double.Parse(Console.ReadLine());
            var area = 0.0;
            if (figure == "square")
            {
                area = size * size;
            }
            else if (figure == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                area = size * b;
            }
            else if (figure == "circle")
            {
                area = Math.PI * size * size;
            }
            else if (figure == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                area = size * h / 2.0;
            }
            Console.WriteLine(Math.Round(area, 3));

        }
    }
}
