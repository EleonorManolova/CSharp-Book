using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetables_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int kgveg = int.Parse(Console.ReadLine());
            int kgfr = int.Parse(Console.ReadLine());
            double resultveg = vegetables * kgveg;
            double resultfr = fruits * kgfr;
            double result = (resultfr + resultveg) / 1.94;
            Console.WriteLine(result);
        }
    }
}
