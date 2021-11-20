using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Class
            BasicMath myClass = new BasicMath();
            // calling the method that take two integers as parameter 
            myClass.addition(first : 2, second : 45);

            // End of Program
            Console.ReadKey();
        }
    }
}
