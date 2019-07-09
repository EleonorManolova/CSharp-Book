namespace _101.Crossing_sequences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var a1 = int.Parse(Console.ReadLine());
            var b1 = int.Parse(Console.ReadLine());
            var c1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());

            var d1 = 0;
            int c2 = 0;
            var b3 = b2;
            var a3 = a2;
            bool equal = true;
            while (a1 <= 1000000)
            {
                d1 = a1 + b1 + c1;

                for (int j = 1; a3 <= 1000000; j++)
                {
                    if (a3 == a1 || a3 == b1 || a3 == c1)
                    {
                        equal = false;
                        Console.WriteLine(a3);
                        break;
                    }
                    else if (a3 == d1)
                    {
                        Console.WriteLine(d1);
                        equal = false;
                    }

                    c2 = a3 + b3;
                    if (j % 2 == 0) b3 = b3 + b2;
                    a3 = c2;
                }

                c2 = 0;
                a3 = a2;
                b3 = b2;
                a1 = b1;
                b1 = c1;
                c1 = d1;

                if (equal == false)
                    break;
            }

            if (equal == true) Console.WriteLine("No");
        }
    }
}
