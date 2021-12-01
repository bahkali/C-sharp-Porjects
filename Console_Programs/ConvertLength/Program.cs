using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program convert measurements: convert measurement in feet and inches into centimeters
            // using the formula that 1 inch is equal to 2.54 centimeters.
            const double centimeter_per_inch = 2.54;
            const int inches_per_foot = 12;

            // Get the Feet and inches
            Console.WriteLine("Enter two integers, one for feet and one for inches, separeted by enter");
            int feet = Convert.ToInt32(Console.ReadLine());
            int inches = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The numbers you entered are "
                +feet+ " for feet and " +inches+ " for inches.");

            // Calculate total inches
            int totalInches = inches_per_foot * feet + inches;
            Console.WriteLine("The total number of inches = " + totalInches);

            // Convert Inches into Centimeters
            double centimeter = centimeter_per_inch * totalInches;
            Console.WriteLine("The number of centimeters = " + centimeter);
            Console.Read();
        }
    }
}
