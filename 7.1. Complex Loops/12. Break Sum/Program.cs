using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Break_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasToEnd = false;
            for (int i = 1; i <= 3; i++)
            {
                if (hasToEnd == false)
                {
                    for (int j = 3; j >= 1; j--)
                    {
                        if (i + j == 2)
                        {
                            hasToEnd = true;
                            break;
                        }
                        Console.WriteLine(i + " " + j);
                    }
                }
            }
        }
    }
}
