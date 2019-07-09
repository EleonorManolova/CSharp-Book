namespace MaxNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines - 1; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
            }

            Console.WriteLine(max);
        }
    }
}
