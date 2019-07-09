namespace _08.Increasing_Elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxsum = 0;
            var prev = 0;

            for (int i = 0; i < lines; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if ((i == 0) || (num > prev))
                {
                    sum++;
                }
                else
                    sum = 1;
                if (sum > maxsum) maxsum = sum;
                prev = num;
            }

            Console.WriteLine(maxsum);
        }
    }
}
