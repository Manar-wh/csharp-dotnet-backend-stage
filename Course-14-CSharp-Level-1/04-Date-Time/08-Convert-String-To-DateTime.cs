using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "6/15/2026";
            DateTime dt1;
           var validDate  = DateTime.TryParse(str, out dt1);
            if (validDate)
            {
                Console.WriteLine(dt1);
            }
            else
                Console.WriteLine($"{str} is not a valid date string");

            str = "102/6/2026";
            DateTime dt2;
            validDate = DateTime.TryParse(str, out dt2);
            if (validDate)
            {
                Console.WriteLine(dt2);
            }
            else
                Console.WriteLine($"{str} is not a valid date string");
        }
    }
}

