using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = Area(a, h);
            Console.WriteLine(area);
        }
        static double Area(double lenght, double height)
        {
            return (lenght * height) / 2;
        }
    }
}
