namespace _05.Christmas_Hat
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/|\\{0}", new string('.', (4 * n - 2) / 2));
            Console.WriteLine("{0}\\|/{0}", new string('.', (4 * n - 2) / 2));
            Console.WriteLine("{0}***{0}", new string('.', (4 * n - 2) / 2));

            for (int col = 1; col <= 2 * n - 1; col++)
            {
                Console.Write("{0}*{1}*{1}*{0}",
                    new string('.', (4 * n - 2 * col - 2) / 2),
                    new string('-', col));
                Console.WriteLine();
            }

            Console.WriteLine("{0}", new string('*', 4 * n + 1));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*.");
            }

            Console.Write("*");
            Console.WriteLine();
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }
    }
}
