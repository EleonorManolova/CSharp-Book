namespace MaxNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines - 1; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                    min = num;
            }

            Console.WriteLine(min);
        }
    }
}
