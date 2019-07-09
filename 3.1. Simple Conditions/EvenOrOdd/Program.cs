namespace EvenOrOdd
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
