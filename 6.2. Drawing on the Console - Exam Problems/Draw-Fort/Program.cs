using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            
            var up = n / 2;
            Console.WriteLine("/{0}\\{1}/{0}\\",
             new string('^', up),
             new string('_', n * 2 - 4 - 2 * up));
            for (int body = 1; body < n - 2; body++)
            {
                Console.WriteLine("|{0}|",
                    new string(' ', 2 * n - 2));
            }
            Console.WriteLine("|{0}{1}{0}|",
             new string(' ', up+1),
             new string('_', n * 2 - 4 - 2 * up));
            Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', up),
            new string(' ', n * 2 - 4 - 2 * up));
            Console.WriteLine();
        }
    }
}
