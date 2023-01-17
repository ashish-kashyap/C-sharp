using System;

namespace CSharpFundamentals
{
    class DateTimes
    {
        static void Main(string[] args)
        {
            var DateTime = new DateTime(2022, 1, 16);
            var now = DateTime.Now;
            var today = DateTime.Today;  

            // Console.WriteLine("Hour: " + now.Hour);
            // Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);   // to get tomorrow's date
            var yesterday = now.AddDays(-1);   // Again to get today's date

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            

        }
    }
}