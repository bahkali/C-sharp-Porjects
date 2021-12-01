using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignmet
{
    class Program
    {
        static void Main(string[] args)
        {

            // Date Time Assignment
            Console.WriteLine("Current date and time: {0}\n",DateTime.Now);

            // Get the user input
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            DateTime date = DateTime.Now;

            // display time after adding user input.
            Console.WriteLine($"The exact time will be: { date.AddHours(num) }");
            // End Program
            Console.Read();
        }
    }
}
