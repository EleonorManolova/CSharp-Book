namespace StudyRoom
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m2 = l * (w - 1);
            var Result = (m2 / (0.7 * 1.2)) - 3;
            Console.WriteLine(Math.Truncate(Result));
        }
    }
}
