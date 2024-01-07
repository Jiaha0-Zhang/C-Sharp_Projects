using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Methods3
{
    internal class Program
    {
        static void Main()
        {
            Math math = new Math(); //instantiation
            Console.WriteLine("Call the method in the class, passing in two numbers.");
            math.MathOperation(6, 8);

            Console.WriteLine("\n"+ "Call the method in the class, specifying the parameters by name.");
            math.MathOperation(a:7 , b: 10);


            Console.ReadLine();
        }
    }
}
