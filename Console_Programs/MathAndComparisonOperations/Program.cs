using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total);
            //Console.Read();

            const int numberOfWeeks = 52;

            Console.WriteLine("Anonymous Income Comparison Program");
            // Get detail of person One - hourly rate and hour worked per week
            Console.WriteLine("Persone 1 \nHourly Rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hourWorked1 = Convert.ToInt32(Console.ReadLine());
            
            // Get detail of person Two - hourly rate and hour worked per week
            Console.WriteLine("Persone 2 \nHourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hourWorked2 = Convert.ToInt32(Console.ReadLine());

            // Calculate annual salary of persone 1 and 2
            int AnnualSalary1 = hourlyRate1 * hourWorked1 * numberOfWeeks;
            int AnnualSalary2 = hourlyRate2 * hourWorked2 * numberOfWeeks;
            // Display annual salary of person 1
            Console.WriteLine("Annual Salary of Person 1: " + AnnualSalary1 );

            // Display annual salary of person 2
            Console.WriteLine("Annual Salary of Person 2: " + AnnualSalary2);

            // Compare their annual salary
            Console.WriteLine("Does Persone 1 make more money than Person 2? "+ (AnnualSalary1 > AnnualSalary2));

            Console.Read();

        }
    }
}
