namespace _03.Stop_Number
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            while (m >= n)
            {
                if (m % 2 == 0 && m % 3 == 0)
                {
                    if (m == s) break;
                    Console.Write("{0} ", m);
                }

                m--;
            }
        }
    }
}
