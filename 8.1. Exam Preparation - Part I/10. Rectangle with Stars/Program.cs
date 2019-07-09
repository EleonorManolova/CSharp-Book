using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int numRows = n;
            
            Console.WriteLine(new string('%', n *2));
            if (n % 2 == 0) numRows--;
            for (int i = 0; i < numRows; i++)
            {
                if (i == numRows / 2) Console.Write("%{0}{1}{0}%",
                   new string(' ', (2 * n - 4) / 2),
                   new string('*', 2));
                
                   else Console.Write("%{0}{0}%",
                   new string(' ', (2 * n - 2) / 2));

                
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', n *2));
        }
    }
}
