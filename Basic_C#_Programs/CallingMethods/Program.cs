using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            arithmatic operationByTwo = new arithmatic();

            Console.Write("Enter any number to have operation by two: ");
            int val = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Adding Two to {val}: {operationByTwo.addTwo(val)}");
            Console.WriteLine($"Divide by Two to {val}: {operationByTwo.dividebyTwo(val)}");
            Console.WriteLine($"Multiply by Two to {val}: {operationByTwo.mutiplyByTwo(val)}");

            Console.ReadKey();

        }
    }
}
