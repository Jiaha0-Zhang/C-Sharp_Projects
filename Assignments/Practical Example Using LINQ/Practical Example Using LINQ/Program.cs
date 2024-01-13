using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Example_Using_LINQ
{
    internal class Program
    {
        static void Main()
        {
            string[] students = new string[] { "Lacey", "Trisha", "Gavin", "Josh", "Joe", "Landon", "Kyndreshia" }; //Specify the data source.

            IEnumerable<string> studentQuery = from student in students where student.Length >= 6 select student; //Define the query expression.

            foreach (string student in studentQuery) //Execute the query.
            {
                Console.WriteLine(student + " ");
            }
            Console.ReadLine();
        }
    }
}
