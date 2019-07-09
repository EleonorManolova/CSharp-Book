namespace EvenPowersof2
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 0; i <= lines / 2; i++)
            {
                Console.WriteLine(num);
                num = num * 4;
            }
        }
    }
}
