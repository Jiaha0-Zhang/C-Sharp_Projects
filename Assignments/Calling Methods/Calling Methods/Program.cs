using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a whole number ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            MathOperations math = new MathOperations(); //Create an instance of the MathOperations class

            int square = math.Square(inputNumber);  //call method by a parameter
            Console.WriteLine(inputNumber + " squared is " + square);

            int cube = math.Cube(inputNumber); //call method by a parameter
            Console.WriteLine(inputNumber + " cubed is " + cube);

            int minusFive = math.MinusFive(inputNumber); //call method by a parameter
            Console.WriteLine(inputNumber +" minus Five squals " + minusFive);

            int addFive = math.AddFive(inputNumber); //call method by a parameter
            Console.WriteLine(inputNumber + " add Five squals " + addFive);

            Console.ReadLine();
        }
    }
}
