namespace HotelRoom
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());
            var studioRent = 0.00m;
            var apartmentRent = 0.00m;

            decimal apartmenPrice;

            decimal studioPrice;
            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50m;
                    apartmenPrice = 65m;
                    studioRent = studioPrice * days;
                    apartmentRent = apartmenPrice * days;
                    if (days > 14)
                    {
                        studioRent *= 0.7M;
                        apartmentRent *= 0.9M;
                    }
                    else if (days > 7)
                    {
                        studioRent *= 0.95m;
                    }
                    break;
                case "june":
                case "september":
                    studioPrice = 75.2m;
                    apartmenPrice = 68.7m;
                    studioRent = studioPrice * days;
                    apartmentRent = apartmenPrice * days;
                    if (days > 14)
                    {
                        studioRent *= 0.8M;
                        apartmentRent *= 0.9M;
                    }
                    break;
                case "july":
                case "august":
                    studioPrice = 76m;
                    apartmenPrice = 77m;
                    studioRent = studioPrice * days;
                    apartmentRent = apartmenPrice * days;
                    if (days > 14)
                    {
                        apartmentRent *= 0.9M;
                    }
                    break;

            }

            Console.WriteLine("Apartment: {0:F2} lv.", decimal.Round(apartmentRent, 2));
            Console.WriteLine("Studio: {0:F2} lv.", decimal.Round(studioRent, 2));
        }
    }
}
