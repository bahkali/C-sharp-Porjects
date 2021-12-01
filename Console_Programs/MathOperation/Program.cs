using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intantiate class
            BasicMath calculator = new BasicMath();
            // Call one method and display to screen
            Console.WriteLine("Using the basicMath class: 234 + 2 = {0}", calculator.addition(234));
            // Call second method get a decimal as a parameter and return a int.
            Console.WriteLine("2. 2785.34 + 2 = {0}", calculator.addition(2785.34m));
            // Give a string to method and return a int
            Console.Write("\nNow it's your turn to enter a number: ");
            string n = Console.ReadLine();
            Console.WriteLine("{0} + 2 = {1}", n, calculator.addition(n));

            Console.ReadKey();
        }
    }
}
