using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    class BasicMath
    {
        public int addition(int num1)
        {
            return num1 + 2;
        }

        public int addition(string num1)
        {
            return Convert.ToInt32(num1) + 2;
        }

        public int addition(decimal num1)
        {
            return Convert.ToInt32(num1 + 2);
        }

        //public int subtraction (int num1) {return num1 - 2;}
        //public int division(int num1){ return num1 / 2;}
        //public int division (double num1){ return Convert.ToInt32(num1 / 2);}
        //public int multiplicaiton(int num1){return num1 * 2;}
    }

}
