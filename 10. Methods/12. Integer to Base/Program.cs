using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }
        static string IntegerToBase(int number,int toBase)
        {
            string result = "";
            while (number != 0)
            {
                string devide = (number % toBase).ToString();
                number = number / toBase;
                result = devide+result;
            }
            return result;
        }
    }
}
