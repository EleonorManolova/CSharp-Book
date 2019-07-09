namespace LatinAlphabet
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Latin alphabet:");
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(" " + letter);
            }

            Console.WriteLine();
        }
    }
}
