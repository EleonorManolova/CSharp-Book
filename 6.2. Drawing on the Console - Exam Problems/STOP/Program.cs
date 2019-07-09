namespace STOP
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', lines + 1),
                new string('_', 2 * lines + 1));
            var dots = lines;
            var dotsMid = 2 * lines - 1;
            for (int row = 1; row < lines + 1; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', dots), new string('_', dotsMid));
                dots--;
                dotsMid += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (dotsMid - 5) / 2));
            for (int row = 1; row < lines + 1; row++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', dots), new string('_', dotsMid));
                dots++;
                dotsMid -= 2;
            }
        }
    }
}
