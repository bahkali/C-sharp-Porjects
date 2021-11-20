using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathOperation4
{
    class basicMath
    {
        public void divideByTwo(int value)
        {
            Console.WriteLine($"{value} divide by 2 is {value/2}");
        }
        // output parameter 
        public void addition(out int value)
        {
            value = 10;
            value += 2;
        }
        // Overload the addition method to have two input and one output parameter
        public void addition( int val1 , int val2, out int result)
        {
            result = val1 + val2;
        }
    }
}
