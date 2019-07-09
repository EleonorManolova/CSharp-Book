namespace Histogram
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                    p1 += 1;
                else if (num < 400)
                    p2 += 1;
                else if (num < 600)
                    p3 += 1;
                else if (num < 800)
                    p4 += 1;
                else if (num >= 800)
                    p5 += 1;

            }

            Console.WriteLine("{0:0.00}%", p1 / lines * 100);
            Console.WriteLine("{0:0.00}%", p2 / lines * 100);
            Console.WriteLine("{0:0.00}%", p3 / lines * 100);
            Console.WriteLine("{0:0.00}%", p4 / lines * 100);
            Console.WriteLine("{0:0.00}%", p5 / lines * 100);
        }
    }
}
