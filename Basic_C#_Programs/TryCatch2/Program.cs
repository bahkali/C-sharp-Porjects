using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get User age
            Console.Write("Enter your age: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0 || age < 0) throw new ArgumentOutOfRangeException();
                Console.WriteLine($"You have enter { age }");

            }
            catch (ArgumentOutOfRangeException)
            {
                // Error if user enters zero or negative number.
                Console.WriteLine("Age must be positive and not zero.");
            }

            catch (Exception)
            {
                // General error messages.
                Console.WriteLine("Please enter a number.");
            }

            // End Program
            Console.Read();
        }
    }
}
