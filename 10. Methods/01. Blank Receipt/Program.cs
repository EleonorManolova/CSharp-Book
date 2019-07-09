using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintMiddle();
            PrintDown();

        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintMiddle()
        {
            Console.Write("Charged to");
            Console.WriteLine("____________________");
            Console.Write("Received by");
            Console.WriteLine("___________________");
            Console.WriteLine("------------------------------");
        }
        static void PrintDown()
        {
            Console.WriteLine("(c) SoftUni");
        }
    }
}
