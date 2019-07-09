namespace TradeCommisions
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());

            var comision = -1.0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500) comision = 0.05;
                else if (sales > 500 && sales <= 1000) comision = 0.07;
                else if (sales > 1000 && sales <= 10000) comision = 0.08;
                else if (sales > 1000) comision = 0.12;
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500) comision = 0.045;
                else if (sales > 500 && sales <= 1000) comision = 0.075;
                else if (sales > 1000 && sales <= 10000) comision = 0.10;
                else if (sales > 1000) comision = 0.13;
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) comision = 0.055;
                else if (sales > 500 && sales <= 1000) comision = 0.08;
                else if (sales > 1000 && sales <= 10000) comision = 0.12;
                else if (sales > 1000) comision = 0.145;
            }
            if (comision >= 0)
            {
                Console.WriteLine("{0:f2}", comision * sales);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
