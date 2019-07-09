namespace _1000_Days_After_Birth
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string inputDate = Console.ReadLine();
            var birthday = DateTime.ParseExact(inputDate, "ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
            string afterBirthday = birthday.AddDays(1000).ToString("ddMMyyyy");
            Console.WriteLine(afterBirthday);
        }
    }
}
