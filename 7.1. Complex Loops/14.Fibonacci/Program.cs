namespace _12.Break_Sum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var f0 = 1;
            var f1 = 1;
            for (int i = 1; i <= lines - 1; i++)
            {
                var sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }

            Console.WriteLine(f1);
        }
    }
}
