namespace InvalidNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var inRange = (number >= 100 && number <= 200 || number == 0);
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
