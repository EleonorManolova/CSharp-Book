using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < count; i++)
            {
                var letter = char.Parse(Console.ReadLine());  
                result = result + Encrypt(letter);
            }
            Console.WriteLine(result);
        }
        static string Encrypt(char letter)
        {
            var result = "";
            if(letter >= 100)
            {
                string firstNum = (letter / 100).ToString();
                string lastNum = (letter % 10).ToString();
                result = firstNum + lastNum;
                result = (char)(letter + letter % 10) + result;
                result = result + (char)(letter - letter / 100);
                return result;
            }
            else
            {
                string firstNum = (letter / 10).ToString();
                string lastNum = (letter % 10).ToString();
                result = firstNum + lastNum;
                result = (char)(letter + letter % 10) + result;
                result = result + (char)(letter - letter / 10);
                return result;
            }

        }
    }
}
