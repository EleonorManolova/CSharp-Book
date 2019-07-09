namespace _04.Special_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            for (var d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            if (lines % d1 == 0 && lines % d2 == 0 && lines % d3 == 0 && lines % d4 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", d1, d2, d3, d4);
                            }
                        }
                    }
                }
            }
        }
    }
}
