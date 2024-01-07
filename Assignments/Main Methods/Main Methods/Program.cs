using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Methods
{
    internal class Program
    {
        static void Main()
        {
            Math math = new Math();// Instantiation 

            int intAddFive = math.MathOperation(2); //Call the first method 
            Console.WriteLine("Result of intAddFive is : "+intAddFive);

            int decimalAddFive = math.MathOperation(3.6m); //Call the second method
            Console.WriteLine("Result of decimalAddFive is: " + decimalAddFive);

            int stringSquare = math.MathOperation("5"); //Call the third method
            Console.WriteLine("Result of stringSquare is: " + stringSquare);

            Console.ReadLine();
        }
    }
}
