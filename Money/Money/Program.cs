namespace Money
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var bitcoin = double.Parse(Console.ReadLine());
            var uian = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            var bitbgn = bitcoin * 1168;
            var uianbgn = (uian * 0.15) * 1.76;
            var euro = (bitbgn + uianbgn) / 1.95;
            var resultcom = (comission / 100) * euro;
            Console.WriteLine(euro - resultcom);
        }
    }
}
