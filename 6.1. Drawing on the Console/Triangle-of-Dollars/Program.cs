namespace Triangle_of_Dollars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            for (int row = 1; row <= lines; row++)
            {
                Console.Write("$");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }

                Console.WriteLine();
            }
        }
    }
}
