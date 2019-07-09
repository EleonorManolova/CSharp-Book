namespace Rombus_of_Stars
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var stars = 1;
            var spaces = lines - 1;

            for (int row = 0; row < lines; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int i = 0; i < stars - 1; i++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
                stars++;
                spaces--;
            }

            spaces = 1;
            stars = lines - 1;
            for (int row = 0; row < lines - 1; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int i = 0; i < stars - 1; i++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
                stars--;
                spaces++;
            }
        }
    }
}
