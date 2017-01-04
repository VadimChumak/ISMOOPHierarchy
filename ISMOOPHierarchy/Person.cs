using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    abstract class Person
    {
        protected string name;
        protected string lastname;
        public Person() : this("Unknown", "Unknown") { }
        public Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
    }
}
