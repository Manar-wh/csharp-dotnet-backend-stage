using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime currentDateTime = DateTime.Now;  
            DateTime todaysDate = DateTime.Today; 
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            DateTime maxDateTimeValue = DateTime.MaxValue; 
            DateTime minDateTimeValue = DateTime.MinValue;

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.ReadKey();
        }
    }
}
