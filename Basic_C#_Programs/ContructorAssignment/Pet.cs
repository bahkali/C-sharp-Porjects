using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorAssignment
{
    class Pet
    {
        public Pet(): this("", 0, false)
        {
        }

        //Chained Constructor
        public Pet(string name, int age, bool cute)
        {
            this.name = name;
            this.age = age;
            this.cute = cute;
        }
        public int age { get; set; }
        public string name { get; set; }
        public bool cute { get; set; }
    }
}
