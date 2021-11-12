using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");

            // Get the Age
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if DUI
            Console.Write("Have you ever have a DUI? (true or false) ");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // Get number of speeding tickets 
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Determine if qualified and display the result
            Console.WriteLine("Qualified? ");
            Console.WriteLine(age > 15 && (dui == false) && speedingTickets < 3);

            // Before Terminate Program.
            Console.WriteLine("Press any key to terminate.");
            Console.ReadKey();
        }
    }
}
