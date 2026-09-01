using System;
using System.Collections.Generic;

namespace CSharp14
    {
      class Program
      {
        static void Main(string[] args)
        {
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;

            foreach (char c in gender)
            {
                if (c == 'm')
                {
                    male++;
                }
                else
                    female++;
            }

            Console.WriteLine($"The Number Of the males=  {male}");
            Console.WriteLine($"The Number Of the females=  {female}");

        }
    }
}
