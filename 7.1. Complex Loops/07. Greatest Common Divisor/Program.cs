using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine(a);

        }
    }
}
