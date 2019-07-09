namespace SquareArea
{
    using System;

    public class SquareArea
    {
        public static void Main()
        {
            Console.WriteLine("Enter a: ");
            var aSize = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + (aSize * aSize));

        }
    }
}
