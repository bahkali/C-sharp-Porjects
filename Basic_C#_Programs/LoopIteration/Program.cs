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

            Console.Write("Enter some text to append in the array: ");
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
            int[] arr2 = { 2, 4, 5, 6, 8, 9 };
            Console.WriteLine("Even number from the array:");
            for (int i = 0; i < arr2.Length; i++){
                // print even number from the array
                if(arr2[i] % 2 == 0)
                {
                    Console.Write(arr2[i] + " ");
                }

            }
            Console.WriteLine();
            int attemp = 1;
            string secret = "boat";
            char holder;
            do {
                Console.WriteLine("Enter any letter that can be in the secret word: ");
                // Get only one character from user
                holder = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // check if secret contains the character if not increment attemp
                if (secret.Contains(holder))
                {
                    Console.WriteLine($"Woow good work. the secret word is {secret}");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again..");
                    attemp++;
                }
                
            } while (attemp <= 3);

            //
            // Before termination
            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey();
        }
    }
}
