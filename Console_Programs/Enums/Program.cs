using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of week? ");
            try
            {
                // Get the user input
                string day = Console.ReadLine();

                //DayOfWeek newDay;
                //Convert the input into Enum
                //bool checkDay = Enum.TryParse(day, out newDay);
                // Output day entered
                Console.WriteLine(Enum.Parse(typeof(DayOfWeek), day));
                
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadKey();
        }
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
