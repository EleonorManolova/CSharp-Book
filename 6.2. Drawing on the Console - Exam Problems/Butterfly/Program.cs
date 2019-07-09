using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Буттерфлъ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int row = 1; row <= n - 1; row++)
            {  
                if(row == n - 1)
                    Console.WriteLine("{0}@{0}", new string(' ', n - 1));
                else if (row % 2 == 0)
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                else
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                
            }
            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0)
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                else
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));

            }


        }
    }
}
