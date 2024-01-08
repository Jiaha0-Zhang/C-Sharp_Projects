using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Employee: Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " is quitting!");

        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
