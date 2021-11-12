using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below");

            // Get package weight
            Console.Write("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // Get package width
            Console.Write("Please enter the package width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Get package height
            Console.Write("Please enter the package height: ");
            int packageheight = Convert.ToInt32(Console.ReadLine());

            // Get package length
            Console.Write("Please enter the package length: ");
            int packagelength = Convert.ToInt32(Console.ReadLine());
            // Calculate total Dimension and Quote
            int packageDimensions = packageWeight + packageWidth + packageheight + packagelength;
            int Quote = (packageheight * packageWidth * packagelength) * packageWeight / 100;
            if (packageDimensions <= 500)
            {
                Console.WriteLine($"Your estimated total for shipping this package is: ${Quote}\nThank you!");
            } else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            // Before terminate program
            Console.WriteLine("Press any key to terminate the program");
            Console.ReadKey();
        }
    }
}
