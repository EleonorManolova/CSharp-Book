namespace Rectangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = 10;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
