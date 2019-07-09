using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minarea = int.Parse(Console.ReadLine());
            bool printNo = true;
            for (int top = -n; top < n; top++)
            {
                for (int left = -n; left < n; left++)
                {
                    for (int bottom = top + 1; bottom <= n; bottom++)
                    {
                        for (int right = left + 1; right <= n; right++)
                        {
                            var widht = right - left;
                            var height = bottom - top;
                            var area = widht * height;
                            if (area >= minarea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", top, left, bottom, right, area);
                                printNo = false;
                            }
                                
                        }
                    }
                }
            }
            if(printNo)
                Console.WriteLine("No");


        }
    }
}
