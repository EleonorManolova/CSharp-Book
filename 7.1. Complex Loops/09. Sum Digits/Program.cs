namespace _09.Sum_Digits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var sum = 0;
            while (lines > 0)
            {
                sum = sum + lines % 10;
                lines = lines / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
