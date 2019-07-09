namespace N_N
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
