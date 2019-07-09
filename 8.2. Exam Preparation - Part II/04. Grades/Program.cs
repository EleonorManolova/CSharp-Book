namespace _04.Grades
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double topstudents = 0.00;
            double verygoodStudents = 0.00;
            double goodStudents = 0.00;
            double failStudents = 0.00;
            double allGrades = 0.00;
            for (int i = 1; i <= n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5) topstudents++;
                else if (grade >= 4) verygoodStudents++;
                else if (grade >= 3) goodStudents++;
                else failStudents++;
                allGrades += grade;
            }

            Console.WriteLine("Top students: {0:f2}%", topstudents / n * 100.0);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", verygoodStudents / n * 100.0);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", goodStudents / n * 100.0);
            Console.WriteLine("Fail: {0:f2}%", failStudents / n * 100.0);
            Console.WriteLine("Average: {0:f2}", allGrades / n);
        }
    }
}
