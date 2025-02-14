﻿namespace PointInTheFigure2
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            bool outRectangle1 = ((x < 0 || x > 3 * h) || (y < 0 || y > h));
            bool outRectangle2 = ((x < h || x > 2 * h) || (y < h || y > 4 * h));

            bool inRange1 = ((x > 0 && x < 3 * h) && (y > 0 && y < h));
            bool inRange2 = ((x > h && x < 2 * h) && (y > h && y < 4 * h));

            bool commonBorder = (x > h && x < 2 * h && y == h);

            if (outRectangle1 && outRectangle2)
            {
                Console.WriteLine("outside");
            }
            else if (inRange1 || inRange2 || commonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}

