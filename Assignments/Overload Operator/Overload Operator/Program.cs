using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee() { Id = 1, FirstName = "Sam", LastName = "Smith" }; //instantiation


            Employee em2 = new Employee() { Id = 2, FirstName = "John", LastName = "Johnson" }; //instantiation

            bool isMatched = em1 == em2;  // compare objects
            Console.WriteLine(isMatched);

            Console.ReadLine();
        }
    }
}
