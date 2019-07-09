namespace _01.Stupid_Password_Generator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var letter = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 < num; d1++)
            {
                for (int d2 = 1; d2 < num; d2++)
                {
                    for (var l1 = 'a'; l1 < 'a' + letter; l1++)
                    {
                        for (var l2 = 'a'; l2 < 'a' + letter; l2++)
                        {
                            for (int d3 = Math.Max(d1, d2) + 1; d3 <= num; d3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4}", d1, d2, l1, l2, d3);
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
