namespace _05.Sequence_2k_1
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var num = 1;
            while (num <= lines)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
