namespace SquareFrame
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            for (int row = 0; row < lines; row++)
            {
                if (row == 0 || row == lines - 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }

                for (int col = 0; col < lines - 2; col++)
                {
                    Console.Write(" -");
                }

                if (lines > 1)
                {
                    Console.Write(" ");
                    if (row == 0 || row == lines - 1)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
