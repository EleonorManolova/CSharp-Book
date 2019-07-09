namespace EqualPairs
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int curSum = 0;
            int prSum = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                prSum = curSum;
                curSum = 0;
                curSum += int.Parse(Console.ReadLine());
                curSum += int.Parse(Console.ReadLine());
                if (i > 0)
                {
                    var diff = Math.Abs(curSum - prSum);
                    if (diff > maxDiff && diff != 0)
                        maxDiff = diff;
                }

            }

            if (prSum == curSum || n == 1)
            {
                Console.WriteLine("Yes, value={0}", curSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
