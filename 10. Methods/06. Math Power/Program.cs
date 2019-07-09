using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            Console.WriteLine(NumPow(num, power));
        }
        static double NumPow(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
