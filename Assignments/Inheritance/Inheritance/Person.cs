using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {
        public string FirstName { get; set; } //Property to store first name
        public string LastName { get; set; } //Property to store last name

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName +" "+ LastName);
        }
       
    }
}
