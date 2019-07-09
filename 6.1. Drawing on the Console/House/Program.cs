using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            if (n % 2 == 0)
                stars = 2;
            
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                var dash = (n - stars) / 2;
                Console.Write(new string('-', dash));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dash));
                Console.WriteLine();
                stars += 2;
            }
            var bodyRow = n / 2;
            for (int row = 0; row < bodyRow; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
