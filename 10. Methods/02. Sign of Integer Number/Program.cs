using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintResult(num);
        }
        static void PrintResult(int num)
        {
            if (num <0)
                Console.WriteLine($"The number {num} is negative.");
            else if (num == 0)
                Console.WriteLine($"The number 0 is zero.");
            else
                Console.WriteLine($"The number {num} is positive.");
        }
    }
}
