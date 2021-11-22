using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyB
{
    abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Abstract method to be implemented
        public abstract void SayName();

    }
}
