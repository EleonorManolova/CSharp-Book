namespace StudyRoom
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double cols = (w - 1) / 0.7;
            double row = l / 1.2;
            int seats = (int)cols * (int)row - 3;
            Console.WriteLine(seats);
        }
    }
}
