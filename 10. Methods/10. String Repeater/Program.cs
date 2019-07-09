using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str, count));
        }
        static string RepeatString (string str, int count)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }
            return repeatedString;
        }
    }
}
