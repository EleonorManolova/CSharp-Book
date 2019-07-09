namespace Diamond
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var mid = -1;
            if (lines % 2 == 0) mid = 0;

            for (int row = 1; row <= (lines + 1) / 2; row++)
            {
                var left = (lines - 2 - mid) / 2;
                Console.Write(new string('-', left));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.Write(new string('-', left));
                mid += 2;
                Console.WriteLine();
            }

            mid = (lines - 4);
            for (int row = 1; row < (lines + 1) / 2; row++)
            {
                var left = (lines - 2 - mid) / 2;
                Console.Write(new string('-', left));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.Write(new string('-', left));
                mid -= 2;
                Console.WriteLine();
            }
        }
    }
}
