using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Crossing_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int tribonacciFirst = int.Parse(Console.ReadLine());
            int tribonacciSecond = int.Parse(Console.ReadLine());
            int tribonacciThird = int.Parse(Console.ReadLine());
            int spiralCurrent = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());

            var tribonacciNumbers = new List<int>()
            {
                tribonacciFirst,
                tribonacciSecond,
                tribonacciThird
            };
            var tribonacciCurrent = tribonacciThird;
            while (tribonacciCurrent < 1000000)
            {
                tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;
                tribonacciNumbers.Add(tribonacciCurrent);

                tribonacciFirst = tribonacciSecond;
                tribonacciSecond = tribonacciThird;
                tribonacciThird = tribonacciCurrent;
            }
            var spiralNumbers = new List<int>() { spiralCurrent };
            var spiralCount = 0;
            var spiralStepMul = 1;
            while (spiralCurrent < 1000000)
            {
                spiralCurrent += spiralStepMul * spiralStep;
                spiralNumbers.Add(spiralCurrent);
                spiralCount++;
                if (spiralCount % 2 == 0)
                {
                    spiralStepMul++;
                }
            }
                var found = false;
                for (int i = 0; i < tribonacciNumbers.Count; i++)
                {
                    for (int j = 0; j < spiralNumbers.Count; j++)
                    {
                        if (tribonacciNumbers[i] == spiralNumbers[j] && tribonacciNumbers[i] <= 1000000)
                        {
                            Console.WriteLine(tribonacciNumbers[i]);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
                if (!found) Console.WriteLine("No");
        }
    }
}
