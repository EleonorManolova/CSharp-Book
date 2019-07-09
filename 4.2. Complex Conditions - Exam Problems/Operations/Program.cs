namespace Operations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            var result = 0.00;

            if (symbol == "+" || symbol == "-" || symbol == "*")
            {

                if (symbol == "+")
                {
                    result = n1 + n2;
                }
                else if (symbol == "-")
                {
                    result = n1 - n2;
                }
                else if (symbol == "*")
                {
                    result = n1 * n2;
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, symbol, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "/" || symbol == "%")
            {
                if (n2 == 0)
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                else
                {
                    if (symbol == "/")
                    {
                        result = n1 / n2;
                        Console.WriteLine("{0} {1} {2} = {3:F2}", n1, symbol, n2, result);
                    }
                    else if (symbol == "%")
                    {
                        result = n1 % n2;
                        Console.WriteLine("{0} {1} {2} = {3}", n1, symbol, n2, result);
                    }
                }
            }
        }
    }
}
