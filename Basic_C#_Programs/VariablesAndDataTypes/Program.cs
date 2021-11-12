using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name, last name, age, and weight separeted by Enter.");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string weigth = Console.ReadLine();
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Age: " + age + "\nWeigth: " + weigth);
            Console.Read();
        }
    }
}
