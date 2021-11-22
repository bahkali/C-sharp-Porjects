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
            emp.Id = 24;
            emp.firstName = "Sample";
            emp.lastName = "Student";
            //Call the method to display full name
            emp.SayName();

            //Using Interface implemented
            IQuittable emp1 = new Employee();
            emp1.Quit();

            //Operators
            Employee emp2 = new Employee();
            emp2.Id = 24;

            Console.WriteLine(emp == emp2);

            // End Program
            Console.ReadKey();
        }
    }
}
