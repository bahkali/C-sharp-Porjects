using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyB
{
    class Employee : Person
    {
        // Implement the method 
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
