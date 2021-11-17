using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One  -  Array Iteration
            string[] customerName = { "kaly", "Jessica", "Salihu" };

            Console.Write("Enter some text to append in the array:");
            string str = Console.ReadLine();
            for(int i = 0; i < customerName.Length; i++)
            {
                customerName[i] = string.Concat(customerName[i] ,  str);   
            }
            // Display array list
            foreach( string e in customerName)
            {
                Console.WriteLine(e);
            }

            //Part Two Infinite Loop
            
            while (true)
            {

                // Fix the infinite loop
            }

            //Part Tree - Loop with condition
            for ()
            {
                // < operator
            }
            do {
                // <= operator
            } while ();

            //
            // Before termination
            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey();
        }
    }
}
