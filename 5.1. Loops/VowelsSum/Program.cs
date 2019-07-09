namespace VowelsSum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = Console.ReadLine();

            var sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == 'a') sum += 1;
                else if (lines[i] == 'e') sum += 2;
                else if (lines[i] == 'i') sum += 3;
                else if (lines[i] == 'o') sum += 4;
                else if (lines[i] == 'u') sum += 5;
            }

            Console.WriteLine("Vowels sum = " + sum);
        }
    }
}
