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

            //Using Interface implemented
            IQuittable emp1 = new Employee();
            emp1.Quit();

            // End Program
            Console.ReadKey();
        }
    }
}
