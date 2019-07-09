namespace Title
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if (gender == "m")
            {
                if (age < 16) Console.WriteLine("Master");
                else Console.WriteLine("Mr.");
            }
            else
            {
                if (age < 16) Console.WriteLine("Miss");
                else Console.WriteLine("Ms.");
            }
        }
    }
}
