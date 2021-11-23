using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProject
{
    class Program
    {
        

        struct Employee
        {
            public int Id;
            public string firstName;
            public string lastName;
        }
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee(){Id= 1, firstName = "Karl", lastName= "Romero"},
                new Employee(){Id =2, firstName = "Roosevelt", lastName="Murray"},
                new Employee(){Id =3, firstName = "Katherine", lastName="Mckinney"},
                new Employee(){Id =4, firstName = "Marsha", lastName="Gutierrez"},
                new Employee(){Id =5, firstName = "Alyssa", lastName="Chambers"},
                new Employee(){Id =6, firstName = "Joe",  lastName="Mcguire"},
                new Employee(){Id =7, firstName = "Gwendolyn", lastName="Rhodes"},
                new Employee(){Id =8, firstName = "Jodi", lastName="Pierce"},
                new Employee(){Id = 9,firstName =  "Shelia", lastName="Walsh"},
                new Employee(){Id =10, firstName = "Joe", lastName = "Terry" }
            };
            // Print the employee List  
            PrintList(EmployeeList);

            // List 2

            List<Employee> EmployeeList2 = new List<Employee>();
            foreach (var e in EmployeeList)
            {
                EmployeeList2.Add(new Employee() { Id = e.Id, firstName = "Joe", lastName = e.lastName });
            }
            PrintList(EmployeeList2);

            // List 3
            List<Employee> EmployeeList3 = new List<Employee>(EmployeeList2.Where(x => x.Id > 5));
            PrintList(EmployeeList3);

            // List 4
            List<Employee> EmployeeList4 = new List<Employee>(EmployeeList.ConvertAll(e => new Employee() { Id = e.Id, firstName = "Joe", lastName = e.lastName }));
            PrintList(EmployeeList4);

            Console.ReadKey();
        }

        // Method to print the list
        static void PrintList(List<Employee> l)
        {
            foreach (var e in l)
            {
                Console.WriteLine($"{e.Id}  {e.firstName}  {e.lastName}");
            }
            Console.WriteLine();
        }
    }
}
