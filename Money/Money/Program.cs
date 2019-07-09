using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = double.Parse(Console.ReadLine());
            var uian = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            var bitbgn = bitcoin * 1168;
            var uianbgn = (uian * 0.15) * 1.76;
            var euro = (bitbgn + uianbgn) / 1.95;
            var resultcom = (comission / 100) * euro;
            Console.WriteLine(euro - resultcom);

        }
    }
}
