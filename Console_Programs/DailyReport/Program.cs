using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" The Tech Academy ");
            Console.WriteLine("==================");
            Console.WriteLine("Student Daily Report");
            // Collect User Name
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            // Collect Course Name
            Console.WriteLine("What course are you on? ");
            string course = Console.ReadLine();
            // Collect page number and convert it to int 32 bit
            Console.WriteLine("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            // Convert the data to boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            // Collect string information on expriences
            Console.WriteLine("Were there any positive experiences you'd like to provide? Please be specific.");
            String positiveExperience = Console.ReadLine();
            //collect feedback as string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            // convert study hour to int 
            Console.WriteLine("How many hours did you study today?");
            int hourStudy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answer. An Instructor will respond to this shortly. Have a great day!");

            Console.Read();

        }
    }
}
