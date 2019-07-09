namespace _08.Factorial
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var result = 1;
            for (int i = 2; i <= lines; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
