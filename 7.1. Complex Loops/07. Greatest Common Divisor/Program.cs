namespace _07.Greatest_Common_Divisor
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine(a);
        }
    }
}
