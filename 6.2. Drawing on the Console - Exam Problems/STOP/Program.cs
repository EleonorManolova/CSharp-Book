using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', n + 1),
                new string('_', 2 * n + 1));
            var dots = n;
            var dotsMid = 2 * n - 1;
            for (int row = 1; row < n+1; row++)
            {

                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', dots), new string('_', dotsMid));
                dots--;
                dotsMid += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (dotsMid - 5) / 2));
            for (int row = 1; row < n + 1; row++)
            {

                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', dots), new string('_', dotsMid));
                dots++;
                dotsMid -= 2;
            }
        }
    }
}
