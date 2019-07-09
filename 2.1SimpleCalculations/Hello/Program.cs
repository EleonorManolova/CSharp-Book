namespace Hello
{
    using System;

    public class Program
    {
        public static void Main()
        {
            //Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
