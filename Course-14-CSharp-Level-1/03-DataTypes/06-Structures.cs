using System;

namespace CSharp14
{

    struct stStudent
    {
        public string FirstName;
        public string LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            stStudent student1;
            stStudent Student2 = new stStudent();

            Console.Write("Enter Your First Name?  ");
            student1.FirstName = Console.ReadLine();
            Console.Write("Enter Your Last Name?  ");
            student1.LastName = Console.ReadLine();
            Console.WriteLine("Student1 Full Name:  " + student1.FirstName + " " + student1.LastName);
            Student2.FirstName = "Mohammed";
            Student2.LastName = "Sami";
            Console.WriteLine("Student2 Full Name:  " + Student2.FirstName + " " + Student2.LastName);

            Console.ReadKey();
        }
    }
}
