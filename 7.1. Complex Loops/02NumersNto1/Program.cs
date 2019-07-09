namespace NumersNto1
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            for (int i = lines; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
