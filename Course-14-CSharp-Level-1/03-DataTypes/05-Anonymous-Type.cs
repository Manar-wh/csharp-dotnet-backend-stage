using System;

namespace CSharp14
{
    class Program
    {
        static void Main(string[] args)
        {

            var student = new
            {
                Id = 20,
                FirstName = "Manar",
                LastName = "ALwahedi",

                Address = new
                {
                    City = "Jeddah",
                    Country = "SA",
                }
            };

            Console.WriteLine("Student Info: ");
            Console.WriteLine("ID: " + student.Id);
            Console.WriteLine("FullName: " + student.FirstName + " " +student.LastName);
            Console.Write("Student Address: ");
            Console.WriteLine(student.Address.City + " " + student.Address.Country);
            Console.ReadKey();

        }
    }
}
