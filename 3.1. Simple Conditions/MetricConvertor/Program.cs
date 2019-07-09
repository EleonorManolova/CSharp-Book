
namespace MetricConvertor
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            string from = Console.ReadLine().ToLower();
            string to = Console.ReadLine().ToLower();

            if (from == "mm")
            {
                num = num / 1000;
            }
            else if (from == "cm")
            {
                num = num / 100;
            }
            else if (from == "mi")
            {
                num = num / 0.000621371192;
            }
            else if (from == "in")
            {
                num = num / 39.3700787;
            }
            else if (from == "km")
            {
                num = num / 0.001;
            }
            else if (from == "ft")
            {
                num = num / 3.2808399;
            }
            else if (from == "yd")
            {
                num = num / 1.0936133;
            }

            if (to == "mm")
            {
                num = num * 1000;
            }
            else if (to == "cm")
            {
                num = num * 100;
            }
            else if (to == "mi")
            {
                num = num * 0.000621371192;
            }
            else if (to == "in")
            {
                num = num * 39.3700787;
            }
            else if (to == "km")
            {
                num = num * 0.001;
            }
            else if (to == "ft")
            {
                num = num * 3.2808399;
            }
            else if (to == "yd")
            {
                num = num * 1.0936133;
            }
            Console.WriteLine(num + " " + to);
        }
    }
}
