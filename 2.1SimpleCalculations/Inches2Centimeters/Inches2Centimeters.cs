namespace Inches2Centimeters
{
    using System;

    public class Inches2Centimeters
    {
        public static void Main()
        {
            Console.Write("Enter Inches:");
            var size = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters:" + (size * 2.54));

        }
    }
}
