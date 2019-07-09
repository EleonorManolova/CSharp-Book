namespace _06.Letters_Combinations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var beginning = char.Parse(Console.ReadLine());
            var end = char.Parse(Console.ReadLine());
            var exeption = char.Parse(Console.ReadLine());
            var count = 0;

            for (char l1 = beginning; l1 <= end; l1++)
            {
                for (char l2 = beginning; l2 <= end; l2++)
                {
                    for (char l3 = beginning; l3 <= end; l3++)
                    {
                        if (l1 != exeption && l2 != exeption && l3 != exeption)
                        {
                            count++;
                            Console.Write("{0}{1}{2} ", l1, l2, l3);
                        }
                    }
                }
            }

            Console.Write(count);
            Console.WriteLine();
        }
    }
}
