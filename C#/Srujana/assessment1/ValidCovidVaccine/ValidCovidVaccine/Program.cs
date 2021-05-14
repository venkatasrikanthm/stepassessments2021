using System;

namespace ValidCovidVaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Aadhar number: ");
            string Aadharnum = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Gender male or femlale");
            string Gender = Console.ReadLine();

            PersonalDetails person = new PersonalDetails(Name,Aadharnum,Age,Gender);

            person.Eligible(Name,Aadharnum,Age,Gender);
        }
       
    }
}
