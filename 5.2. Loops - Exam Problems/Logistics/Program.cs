namespace Logistics
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var sumtons = 0.0;
            var microbus = 0.0;
            var truck = 0.0;
            var train = 0.0;

            for (int i = 0; i < lines; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                double currency;
                if (tons <= 3)
                {
                    currency = 200;
                    microbus += tons;
                }
                else if (tons <= 11)
                {
                    currency = 175;
                    truck += tons;
                }
                else
                {
                    currency = 120;
                    train += tons;
                }

                sum += currency * tons;
                sumtons += tons;
            }

            Console.WriteLine("{0:0.00}", sum / sumtons);
            Console.WriteLine("{0:0.00}%", microbus / sumtons * 100);
            Console.WriteLine("{0:0.00}%", truck / sumtons * 100);
            Console.WriteLine("{0:0.00}%", train / sumtons * 100);
        }
    }
}
