using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Methods4
{
    internal class Program
    {
        static void Main()
        {
            Math math = new Math(); //instantiate the class.

            Console.WriteLine("Please input a number");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            math.MathOperation(inputNum);
            
            Console.ReadLine();
        }
    }

    static class justAClass //Declare a class to be static.
    {
        public static void Hello()
        {
            Console.WriteLine("This is a static class");
        }
    }
}
