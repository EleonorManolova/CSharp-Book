using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMAx(first,second));
            }
            else if (type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMAx(first, second));
            }
            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                Console.WriteLine(GetMAx(first, second));
            }
        }
        static int GetMAx(int first, int second)
        {
            if (first >= second)
                return first;
            else
                return second;
        }
        static char GetMAx(char first, char second)
        {
            if (first >= second)
                return first;
            else
                return second;
        }
        static string GetMAx(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
                return first;
            else
                return second;
        }

    }
}
