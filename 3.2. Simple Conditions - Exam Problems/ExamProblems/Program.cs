using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int worker = int.Parse(Console.ReadLine());
            var workingDays = 0.9 * days;
            var workingHours = 10.0 * workingDays  * worker;
            var left = Math.Abs(workingHours - hours);
            if (workingHours - hours >= 0)
                Console.WriteLine("Yes!{0} hours left.", workingHours - hours);
            else
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(left));
        }
    }
}
