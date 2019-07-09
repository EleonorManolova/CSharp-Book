namespace _06.Number_in_Range_1to100
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            while (lines < 1 || lines > 100)
            {
                Console.WriteLine("Invalid number");
                lines = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", lines);
        }

    }
}
