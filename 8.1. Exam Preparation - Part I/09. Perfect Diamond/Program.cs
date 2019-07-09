namespace _09.Perfect_Diamond
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int j = 0; j < row - 1; j++)
                {
                    Console.Write("-*");
                }

                Console.WriteLine();
            }

            for (int row = 1; row <= n - 1; row++)
            {
                for (int k = n - row; k < n; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int j = row + 1; j < n; j++)
                {
                    Console.Write("-*");
                }

                Console.WriteLine();
            }
        }
    }
}
