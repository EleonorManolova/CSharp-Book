using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Plus_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var m2 = m + 15;
            if (m2 > 59)
            {
                h += 1;
                m2 = m2 - 60;
            }
            if (h > 23)
            {
                h = h - 24;
            }
            if (m2 < 10)
            {
                Console.WriteLine(h + ":0" + m2);
            }
            else
            {
                Console.WriteLine(h + ":" + m2);
            }
        }
    }
}
