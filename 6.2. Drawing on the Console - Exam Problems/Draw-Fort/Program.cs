namespace Draw_Fort
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var up = lines / 2;
            Console.WriteLine("/{0}\\{1}/{0}\\",
             new string('^', up),
             new string('_', lines * 2 - 4 - 2 * up));

            for (int body = 1; body < lines - 2; body++)
            {
                Console.WriteLine("|{0}|",
                    new string(' ', 2 * lines - 2));
            }

            Console.WriteLine("|{0}{1}{0}|",
             new string(' ', up + 1),
             new string('_', lines * 2 - 4 - 2 * up));
            Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', up),
            new string(' ', lines * 2 - 4 - 2 * up));
            Console.WriteLine();
        }
    }
}
