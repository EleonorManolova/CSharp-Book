namespace House
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var stars = 1;
            if (lines % 2 == 0)
            {
                stars = 2;
            }

            for (int row = 0; row < (lines + 1) / 2; row++)
            {
                var dash = (lines - stars) / 2;
                Console.Write(new string('-', dash));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dash));
                Console.WriteLine();
                stars += 2;
            }

            var bodyRow = lines / 2;
            for (int row = 0; row < bodyRow; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', lines - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
