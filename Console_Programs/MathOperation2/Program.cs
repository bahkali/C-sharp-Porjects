using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Addition App");
            Console.WriteLine("Please enter two number seperated by enter key: ");
            // Instantiate class
            BasicMath calculator = new BasicMath();
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                // Display the math operation with two parameter
                Console.WriteLine("{0} + {1} = {2}", num1, num2, calculator.addition(num1, num2));
                
            }
            catch
            {
                // without the second number.
                Console.WriteLine("{0} + no value = {1}", num1, calculator.addition(num1));
            }
            Console.ReadKey();
        }
    }
}
