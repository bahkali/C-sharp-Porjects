using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "Hello World!";
            string test2 = "It works!!!!";
            Console.WriteLine(test1.PadRight(20, '.'));
            Console.WriteLine(test2.PadLeft(20, '.'));

            Console.ReadKey();
        }
    }
}
