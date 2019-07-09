using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            var a = double.Parse(Console.ReadLine());
            var face = 0.0;
            if (figure == "square")
            {
                face = a * a;
            }
            else if (figure == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                face = a * b;
            }
            else if (figure == "circle")
            {
                face = Math.PI * a * a;
            }
            else if (figure == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                face = a * h / 2.0;
            }
            Console.WriteLine(Math.Round(face, 3));

        }
    }
}
