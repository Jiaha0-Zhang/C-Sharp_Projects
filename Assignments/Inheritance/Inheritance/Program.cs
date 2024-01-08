using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee {FirstName = "Sample",  LastName = "Student"}; //Instantiation
            employee.SayName(); // Call method SayName() from superclass

            Console.ReadLine(); 
        }
    }
}
