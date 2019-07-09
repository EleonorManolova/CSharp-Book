using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Magic_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;2
            int d4 = 0;
            int d5 = 0;
            int d6=0;
            while (d1<=9)
            {
                d2 = 0;
                while (d2<=9)
                {
                    d3 = 0;
                    while (d3 <= 9)
                    {
                        d4 = 0;
                        while (d4 <=9)
                        {
                            d5 = 0;
                            while (d5<=9)
                            {
                                d6 = 0;
                                while (d6 <= 9)
                                {
                                    if (d1 * d2 * d3 * d4 * d5 * d6 == num)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", d1, d2, d3, d4, d5, d6);
                                    }
                                    d6++;
                                }
                                
                                d5++;
                            }
                            d4++;
                        }
                        d3++;
                    }
                    d2++;
                }
                d1++;
            }
            //for (int d1 = 0; d1 <= 9; d1++)
            //{
            //    for (int d2 = 0; d2 <= 9; d2++)
            //    {
            //        for (int d3 = 0; d3 <= 9; d3++)
            //        {
            //            for (int d4 = 0; d4 <= 9; d4++)
            //            {
            //                for (int d5 = 0; d5 <= 9; d5++)
            //                {
            //                    for (int d6 = 0; d6 <= 9; d6++)
            //                    {
            //                        if (d1*d2*d3*d4*d5*d6 == num)
            //                        {
            //                            Console.Write("{0}{1}{2}{3}{4}{5} ", d1,d2,d3,d4,d5,d6);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
                

        }
    }
}
