namespace _02.Magic_Combination
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;
            int d6 = 0;

            while (d1 <= 9)
            {
                d2 = 0;
                while (d2 <= 9)
                {
                    d3 = 0;
                    while (d3 <= 9)
                    {
                        d4 = 0;
                        while (d4 <= 9)
                        {
                            d5 = 0;
                            while (d5 <= 9)
                            {
                                d6 = 0;
                                while (d6 <= 9)
                                {
                                    if (d1 * d2 * d3 * d4 * d5 * d6 == number)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", d1, d2, d3, d4, d5, d6);
                                    }

                                    d6++;
                                }

                                d5++;
                            }

                            d4++;
                        }

                        d3++;
                    }

                    d2++;
                }

                d1++;
            }
        }
    }
}
