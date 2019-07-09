namespace sunglasses
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
                    Console.Write(new string('*', 2 * lines));
                    Console.Write(new string(' ', lines));
                    Console.Write(new string('*', 2 * lines));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', 2 * lines - 2));
                    Console.Write("*");
                    if (row == (lines - 1) / 2)
                    {
                        Console.Write(new string('|', lines));
                    }
                    else
                    {
                        Console.Write(new string(' ', lines));
                    }

                    Console.Write("*");
                    Console.Write(new string('/', 2 * lines - 2));
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
