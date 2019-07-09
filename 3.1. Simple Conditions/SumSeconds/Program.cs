namespace SumSeconds
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var seconds = num1 + num2 + num3;
            var minutes = 0;

            if (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }

            if (seconds > 60)
            {
                minutes += 1;
                seconds -= 60;
            }

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
