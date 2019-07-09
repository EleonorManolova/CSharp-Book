namespace EvenOddPositons
{
    using System;

   public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            double OddSum = 0.0;
            double OddMin = double.MinValue;
            double OddMax = double.MaxValue;
            double EvenSum = 0.0;
            double EvenMin = double.MinValue;
            double EvenMax = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    OddSum += num;
                    if (i == 0)
                    {
                        OddMax = num;
                        OddMin = num;
                    }
                    else if (num < OddMin)
                        OddMin = num;
                    else if (num > OddMax)
                        OddMax = num;
                }
                else
                {
                    EvenSum += num;
                    if (i == 1)
                    {
                        EvenMax = num;
                        EvenMin = num;
                    }
                    else if (num < EvenMin)
                        EvenMin = num;
                    else if (num > EvenMax)
                        EvenMax = num;
                }
            }

            if (n > 1)
            {
                Console.WriteLine("OddSum=" + OddSum);
                Console.WriteLine("OddMin=" + OddMin);
                Console.WriteLine("OddMax=" + OddMax);
                Console.WriteLine("EvenSum=" + EvenSum);
                Console.WriteLine("EvenMin=" + EvenMin);
                Console.WriteLine("EvenMax=" + EvenMax);
            }
            else
            {
                if (OddSum == 0)
                {
                    Console.WriteLine("OddSum=" + OddSum);
                    Console.WriteLine("OddMin=No");
                    Console.WriteLine("OddMax=No");
                }
                else
                {
                    Console.WriteLine("OddSum=" + OddSum);
                    Console.WriteLine("OddMin=" + OddMin);
                    Console.WriteLine("OddMax=" + OddMax);
                }

                Console.WriteLine("EvenSum=" + EvenSum);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
