namespace _11.Increasing_4_Numbers
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var minarea = int.Parse(Console.ReadLine());
            bool printNo = true;
            for (int top = -lines; top < lines; top++)
            {
                for (int left = -lines; left < lines; left++)
                {
                    for (int bottom = top + 1; bottom <= lines; bottom++)
                    {
                        for (int right = left + 1; right <= lines; right++)
                        {
                            var widht = right - left;
                            var height = bottom - top;
                            var area = widht * height;
                            if (area >= minarea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", top, left, bottom, right, area);
                                printNo = false;
                            }
                        }
                    }
                }
            }

            if (printNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}
