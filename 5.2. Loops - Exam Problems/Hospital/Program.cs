namespace Hospital
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int Alldays = int.Parse(Console.ReadLine());
            int Checked = 0;
            int Unchecked = 0;
            int doctor = 7;

            for (int day = 1; day <= Alldays; day++)
            {
                int patients = int.Parse(Console.ReadLine());

                if ((day % 3 == 0) && (Unchecked > Checked))
                {
                    doctor++;
                }

                if (patients > doctor)
                {
                    Checked += doctor;
                    Unchecked += patients - doctor;
                }
                else
                    Checked += patients;

            }

            Console.WriteLine("Treated patients: {0}.", Checked);
            Console.WriteLine("Untreated patients: {0}.", Unchecked);
        }
    }
}
