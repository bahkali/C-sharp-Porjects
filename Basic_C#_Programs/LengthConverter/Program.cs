using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given lenght in inches , this program outputs the equivalent length in feet and remaining inches.
            Console.WriteLine("Enter Total inches and press Enter:");
            var inches = Console.ReadLine();

            int length = Convert.ToInt32(inches) / 12;
            int remain = Convert.ToInt32(inches) % 12;
            Console.WriteLine(inches + " inch(es) = " + length + " feet (foot) and " + remain + " inch(es).");
            Console.Read();

        }
    }
}
