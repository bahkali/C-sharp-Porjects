using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an employee
            Employee emp = new Employee();
            
            emp.firstName = "Sample";
            emp.lastName = "Student";
            //Call the method to display full name
            emp.SayName();

            // End Program
            Console.ReadKey();
        }
    }
}
