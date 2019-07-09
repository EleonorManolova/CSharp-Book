using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var savedMoney = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var sideTriangle = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());
            var costPerOne = double.Parse(Console.ReadLine());
            var workerCost = double.Parse(Console.ReadLine());

            double size = heightTriangle * sideTriangle / 2.0;
            double sizeRoom = width * lenght;
            double number = Math.Ceiling(sizeRoom / size) + 5;
            double moneyCost = number * costPerOne + workerCost;
            double moneyleft = savedMoney - moneyCost;
            if (moneyleft >= 0)
            {
                Console.WriteLine("{0:f2} lv left.", moneyleft);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(moneyleft));
            }
        }
    }
}
