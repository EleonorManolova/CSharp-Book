namespace _16.Number_Table
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            for (int row = 0; row <= lines - 1; row++)
            {
                for (int col = 0; col <= lines - 1; col++)
                {
                    var num = row + col + 1;
                    if (num > lines)
                    {
                        num = -num + 2 * lines;
                    }
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
