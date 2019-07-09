namespace Arrow
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', (lines - 1) / 2), new string('#', lines));

            for (int row = 1; row <= lines - 2; row++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', (lines - 1) / 2), new string('.', lines - 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('#', (lines + 1) / 2), new string('.', lines - 2));
            var dotsOut = 1;
            var dotsIn = 2 * lines - 5;
            for (int row = 1; row <= lines - 2; row++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dotsOut), new string('.', dotsIn));
                dotsOut++;
                dotsIn -= 2;
            }

            Console.WriteLine("{0}#{0}", new string('.', dotsOut));
        }
    }
}
