using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize array
            int[] numbers = { 25, 789, 2910, 89, 104, 58394 };

            try
            {
                // Get value from user
                Console.Write("Enter a number: ");
                // Convert string input to int
                int n = Convert.ToInt32(Console.ReadLine());
                // loop through array and display result.
                foreach (int i in numbers)
                {
                    Console.WriteLine("Number {0} divede by {1} equals to {2}", i, n, (i / n));
                }
            // Catch any exception and display message
            } catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
