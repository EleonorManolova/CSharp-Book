namespace _15.Number_Pyramid
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var num = 1;
            for (int row = 1; row <= lines; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    if (col >= 1)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(num);
                    num++;
                    if (num > lines)
                        break;
                }

                Console.WriteLine();
                if (num > lines)
                    break;
            }
        }
    }
}
