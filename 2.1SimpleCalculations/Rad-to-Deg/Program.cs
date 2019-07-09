namespace Rad_to_Deg
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var radian = double.Parse(Console.ReadLine());
            var degree = radian * 180 / Math.PI;
            Console.WriteLine(Math.Round(degree, 0));
        }
    }
}
