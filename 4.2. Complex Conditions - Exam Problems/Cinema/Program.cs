using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var row = double.Parse(Console.ReadLine());
            var column = double.Parse(Console.ReadLine());
            var price = 0.0;

            switch (type)
            {
                case "premiere":
                    price = row * column * 12.0;
                    break;
                case "normal":
                    price = row * column * 7.5;
                    break;
                case "discount":
                    price = row * column * 5.0;
                    break;
            }
            Console.WriteLine("{0:0.00} leva", price);
        }
    }
}
