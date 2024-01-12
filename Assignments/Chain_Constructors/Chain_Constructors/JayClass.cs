using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors
{
    public class JayClass
    {
        public string Name;
        public int Age;

        public JayClass(string name) : this(name, 20) //Chain two constructors together. 20 is the default value.
        {

        }

        public JayClass(string name ,int age) 
        {
            Name = name;
            Age = age;
        }
    }
}
