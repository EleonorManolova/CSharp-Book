namespace _10.Rectangle_with_Stars
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            int numRows = lines;

            Console.WriteLine(new string('%', lines * 2));
            if (lines % 2 == 0) numRows--;
            for (int i = 0; i < numRows; i++)
            {
                if (i == numRows / 2)
                {
                    Console.Write("%{0}{1}{0}%",
                    new string(' ', (2 * lines - 4) / 2),
                    new string('*', 2));
                }
                else
                {
                    Console.Write("%{0}{0}%",
                    new string(' ', (2 * lines - 2) / 2));
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('%', lines * 2));
        }
    }
}
