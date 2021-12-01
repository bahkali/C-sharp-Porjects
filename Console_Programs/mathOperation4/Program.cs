using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathOperation4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate basicmath class
            basicMath myClass = new basicMath();

            Console.Write("Please enter a number: ");
            // Parse input from user to int
            int num = Convert.ToInt32(Console.ReadLine());

            myClass.divideByTwo(num);

            // Calling a static method , no need to instantiate the class
            basicMath2.MultiplyByTwo(num);

            // End Program
            Console.ReadKey();
        }
    }
}
