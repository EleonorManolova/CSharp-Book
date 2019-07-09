namespace Square_of_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            for (int row = 0; row < lines; row++)
            {
                Console.Write("*");
                for (int col = 0; col < lines - 1; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
