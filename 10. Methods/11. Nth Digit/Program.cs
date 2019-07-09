using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(num, index));
        }
        static int FindNthDigit (int num, int index)
        {
            var index10 = 1;
            for (int i = 0; i < index-1; i++)
            {
                index10 = index10 * 10;
            }
            var result = num / index10 % 10;
            return result;
        }
    }
}
