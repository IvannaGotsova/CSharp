using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CSharp
{
    public class DateTimes
    {
        //DateTime

        DateTime firstDateTime = new DateTime();
        DateTime secondDateTime = new DateTime(1990, 1, 1);
        DateTime thirdDateTime = new DateTime(1990, 1, 1, 5, 0, 0);
        DateTime fourthDateTime = new DateTime(1990, 1, 1, 5, 0, 0, DateTimeKind.Utc);

        DateTime currentDateTime = DateTime.Now; 
        DateTime todaysDate = DateTime.Today; 
        DateTime currentDateTimeUTC = DateTime.UtcNow;

        DateTime maxDateTimeValue = DateTime.MaxValue; 
        DateTime minDateTimeValue = DateTime.MinValue;

        //TimeSpan
  
        static DateTime currrentDiteTime = new DateTime(1990, 1, 1);

        static TimeSpan timeSpan = new TimeSpan(10, 10, 10);

        static DateTime newDate = currrentDiteTime.Add(timeSpan);

        TimeSpan newTimeSpan = newDate.Subtract(currrentDiteTime);

        //ToString()

        static string dateToString = "01-01-1990 00:00:00";
        DateTime stringToDate = DateTime.Parse(dateToString);


        public void PrintDateTimes()
        {
            Console.WriteLine("First date: {0}", firstDateTime);
            Console.WriteLine("Second date: {0}", secondDateTime);
            Console.WriteLine("Third date: {0}", thirdDateTime);
            Console.WriteLine("Fourth date: {0}", fourthDateTime);
            Console.WriteLine("Current DateTime: {0}", currentDateTime);
            Console.WriteLine("Today`s date: {0}", todaysDate);
            Console.WriteLine("Current DateTime: {0}", currentDateTimeUTC);
            Console.WriteLine("Max DateTime: {0}", maxDateTimeValue);
            Console.WriteLine("Min DateTime: {0}", minDateTimeValue);
            Console.WriteLine("New Date: {0}", newDate);
            Console.WriteLine("New TimeSpan: {0}", newTimeSpan);
            Console.WriteLine("String to Date: {0}", stringToDate);
        }

        public void FormatDateTimes()
        {
            DateTime dateTimeToFormat = new DateTime(1990, 12, 31, 5, 0, 0);

            CultureInfo bulgarianCultureInfo = new CultureInfo("bg-BG");
            CultureInfo englishCultureInfo = new CultureInfo("en-EN");
            Console.WriteLine("Bulgarian format: {0}", dateTimeToFormat.ToString("d", bulgarianCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("d", englishCultureInfo));
            Console.WriteLine("Bulgarian format: {0}", dateTimeToFormat.ToString("D", bulgarianCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("D", englishCultureInfo));

            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("f", englishCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("F", englishCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("g", englishCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("G", englishCultureInfo));

            Console.WriteLine("Bulgarian format: {0}", dateTimeToFormat.ToString("M", bulgarianCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("O", englishCultureInfo));

            Console.WriteLine("Bulgarian format: {0}", dateTimeToFormat.ToString("r", bulgarianCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("r", englishCultureInfo));

            Console.WriteLine("Bulgarian format: {0}", dateTimeToFormat.ToString("t", bulgarianCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("t", englishCultureInfo));

            Console.WriteLine("Bulgarian format: {0}", dateTimeToFormat.ToString("y", bulgarianCultureInfo));
            Console.WriteLine("English format: {0}", dateTimeToFormat.ToString("y", englishCultureInfo));

            Console.WriteLine(dateTimeToFormat.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(dateTimeToFormat.ToString(englishCultureInfo));
            Console.WriteLine(dateTimeToFormat.ToString(bulgarianCultureInfo));
        }
    }
}
