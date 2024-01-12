using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors
{
    internal class Program
    {
        static void Main()
        {
            const string name = "Jay"; //Create a const variable.

            var age = 0; //Create a variable using the keyword “var.”



            JayClass jay = new JayClass("Jay");
            Console.WriteLine("{0} is a {1} years old student.", jay.Name, jay.Age); //Jay is a 20 years old student. Here jay.age is a default value 20.

            JayClass someone = new JayClass("Ted",15);
            Console.WriteLine("{0} is a {1} years old student.", someone.Name, someone.Age); //Ted is a 15 years old student.

            Console.ReadLine();
        }
    }
}
