using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Strings
    {
        static string firstName = "Ivan";
        static string middleName = "Ivanov";
        static string lastName = "Ivanov";
        static int age = 44;
        static string city = "Sofia";
        static string country = "Bulgaria";
        static string email = "example@example.com";
        static string phoneNumber = "+359000000000";

        string formatString = string.Format("His name is {0} {1} {2}. He is from {3}, {4}. He is {5} years old. His email is {6} and his phone number is {7}.", firstName, middleName, lastName, city, country, age, email, phoneNumber);

        string interpolatedString = $"His name is {firstName} {middleName} {lastName}. He is from {city}, {country}. He is {age} years old. His email is {email} and his phone number is {phoneNumber}.";

        string nullString = null;
        string whiteSpace = " ";

        public void PrintStrings()
        {
            Console.WriteLine(formatString);

            Console.WriteLine(interpolatedString);

            Console.WriteLine(formatString == interpolatedString);
            Console.WriteLine(formatString.Equals(interpolatedString + " "));

            Console.WriteLine(string.IsNullOrEmpty(formatString));
            Console.WriteLine(string.IsNullOrEmpty(nullString));
            Console.WriteLine(string.IsNullOrEmpty(whiteSpace));
        }

        public void ManipulationStringArrays()
        {
            string[] arrayStrings = formatString.Split(' ', '.', ',').ToArray();
            Console.WriteLine(arrayStrings[3]);
            Console.WriteLine(arrayStrings[4]);
            Console.WriteLine(arrayStrings[5]);
            Console.WriteLine(arrayStrings.Length);
        }

        public void FormatStrings()
        {
            Console.WriteLine("Currency: {0:C2}", 12345,67890);
            Console.WriteLine("Added two 0: {0:D6}", 12345);
            Console.WriteLine("{0:P}", 12345);
            Console.WriteLine("{0:X}", 12345);
            Console.WriteLine("{0:0.00}", 12345);
            Console.WriteLine("{0:0.00}", 12345.6789);
            Console.WriteLine("{0:#.##}", 12345);
            Console.WriteLine("{0:#.##}", 12345.6789);
        }
    }
}
