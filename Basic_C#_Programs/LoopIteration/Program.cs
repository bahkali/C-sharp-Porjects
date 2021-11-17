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

            int num = 0;
            while (true)
            {
                // Fix the infinite loop
                if(num == 10) { break; }
                Console.Write(num + " ");
                num++;
                
            }
            Console.WriteLine();

            //Part Tree - Loop with condition
            //for (){ }
            //do {} while ();

            //
            // Before termination
            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey();
        }
    }
}
