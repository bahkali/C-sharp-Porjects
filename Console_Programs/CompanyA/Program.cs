using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiate the employee object
            Employee emp1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Print to the screen the name of the emp1 
            emp1.SayName();

            //End Program
            Console.ReadKey();
        }
    }
}
