namespace Axe
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var front = 3 * lines;
            Console.WriteLine("{0}**{1}", new string('-', front), new string('-', 5 * lines - 2 - front));
            var middle = 0;

            for (int row = 0; row < lines - 1; row++)
            {
                middle++;
                Console.WriteLine("{0}*{1}*{2}", new string('-', front), new string('-', middle), new string('-', 5 * lines - 2 - front - middle));

            }

            for (int i = 0; i < lines / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', front), new string('-', middle), new string('-', 5 * lines - 2 - front - middle));
            }

            for (int row = 1; row <= lines / 2; row++)
            {
                if (row != lines / 2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', front), new string('-', middle), new string('-', 5 * lines - 2 - front - middle));
                }

                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', front), new string('*', middle), new string('-', 5 * lines - 2 - front - middle));
                }

                middle += 2;
                front--;
            }
        }
    }
}
