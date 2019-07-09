namespace _10.Check_Prime
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var count = lines > 1;
            for (int i = 2; i <= Math.Sqrt(lines); i++)
            {
                if (lines % i == 0)
                {
                    count = false;
                    break;
                }
            }

            if (count)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
        }
    }
}
