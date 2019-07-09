using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            ReadAndProcessMessage(count);
        }
        static void ShowSuccessMessage (string operation, string message)
        {
            var result =$"Successfully executed {operation}.";
            Console.WriteLine(result);
            for (int i = 0; i < result.Length; i++)
                Console.Write("=");
            Console.WriteLine();
            Console.WriteLine($"{message}.");
            
        }
        static void ShowWarningMessage(string message)
        {
            var result = $"Warning: {message}.";
            Console.WriteLine(result);
            for (int i = 0; i < result.Length; i++)
                Console.Write("=");
            Console.WriteLine();
        }
        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            var result = $"Error: Failed to execute {operation}.";
            Console.WriteLine(result);
            for (int i = 0; i < result.Length; i++)
                Console.Write("=");
            Console.WriteLine();
            Console.WriteLine($"Reason: {message}.");
            Console.WriteLine($"Error code: {errorCode}.");
        }
        static void ReadAndProcessMessage(int count)
        {
            for (int i = 0; i < count; i++)
            {

                var messageType = Console.ReadLine();
                if (messageType == "error")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    var errorCode = int.Parse(Console.ReadLine());
                    ShowErrorMessage(operation, message, errorCode);
                }
                if (messageType == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    ShowSuccessMessage(operation, message);
                }
                if (messageType == "warning")
                {
                    var message = Console.ReadLine();
                    ShowWarningMessage(message);
                }
                Console.WriteLine();
            }
        }
    }
}
