namespace _11.Enter_Even_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = 0;
            while (true)
            {
                lines = int.Parse(Console.ReadLine());
                if (lines % 2 == 0)
                {
                    break;
                }

                Console.WriteLine("The number is not even.");
            }

            Console.WriteLine("Even number entered: {0}", lines);
        }
    }
}
