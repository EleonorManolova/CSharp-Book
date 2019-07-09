namespace EqualWords
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();
            if (word == word2)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
