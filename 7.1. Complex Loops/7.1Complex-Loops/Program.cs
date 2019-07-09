namespace _7._1Complex_Loops
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lines; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
