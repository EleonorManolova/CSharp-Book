using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double cols = (w - 1) / 0.7;
            double row = l / 1.2;
            int seats = (int)cols * (int)row - 3;
            Console.WriteLine(seats);

        }
    }
}
