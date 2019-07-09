namespace Butterfly
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int row = 1; row <= lines - 1; row++)
            {
                if (row == lines - 1)
                    Console.WriteLine("{0}@{0}", new string(' ', lines - 1));
                else if (row % 2 == 0)
                    Console.WriteLine("{0}\\ /{0}", new string('-', lines - 2));
                else
                    Console.WriteLine("{0}\\ /{0}", new string('*', lines - 2));
            }

            for (int row = 1; row <= lines - 2; row++)
            {
                if (row % 2 == 0)
                    Console.WriteLine("{0}/ \\{0}", new string('-', lines - 2));
                else
                    Console.WriteLine("{0}/ \\{0}", new string('*', lines - 2));
            }
        }
    }
}
