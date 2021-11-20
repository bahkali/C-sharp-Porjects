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
            basicMath myClass = new basicMath();
            Console.Write("Please enter a number: ");
            
                int num = Convert.ToInt32(Console.ReadLine());
                myClass.divideByTwo(num);
            
            
            // End Program
            Console.ReadKey();
        }
    }
}
