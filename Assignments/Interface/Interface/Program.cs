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
            //instantiation
             IQuittable emobject = new Employee() { firstName = "Sam", lastName = "Smith" }; 

            emobject.Quit(); //call the interface

            Console.ReadLine();
        }
    }
}
