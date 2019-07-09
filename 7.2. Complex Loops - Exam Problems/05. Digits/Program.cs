namespace _05.Digits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var first = (n / 100 % 10);
            var second = (n / 10 % 10);
            var last = (n % 10);

            for (int row = 1; row <= first + second; row++)
            {
                for (int col = 1; col <= first + last; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= first;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= second;
                    }
                    else
                    {
                        n += last;
                    }

                    Console.Write("{0} ", n);
                }

                Console.WriteLine();
            }
        }
    }
}
