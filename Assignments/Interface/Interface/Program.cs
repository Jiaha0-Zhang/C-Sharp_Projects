using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { firstName = "Sam", lastName = "Smith" }; //instantiation

            employee.Quit(); //call the interface

            Console.ReadLine();
        }
    }
}
