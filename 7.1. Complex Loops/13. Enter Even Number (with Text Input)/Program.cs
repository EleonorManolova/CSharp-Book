namespace _13.Enter_Even_Number__with_Text_Input_
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", n);
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            }
        }
    }
}
