using System;
using System.Collections.Generic;
using System.Linq;

namespace ContructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string daysOfWeek = "Monday";

            string[] students = new string[] { "Lacey", "Trisha", "Gavin", "Josh", "Jon", "Landon", "Kyndreshia" };

            IEnumerable<string> studentQuery = from student in students
                                               where student.Length >= 6
                                               select student;

            foreach(string s in studentQuery)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The value of the const variable: {daysOfWeek}");
        }
    }
}
