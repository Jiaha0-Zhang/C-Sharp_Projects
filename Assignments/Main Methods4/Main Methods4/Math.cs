using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Methods4
{
    internal class Math
    {
        public void MathOperation(int x)
        {
            int result = x / 2;
            Console.WriteLine("You have input the number " + "x" + ", the result is " + result);
        }

        public void MathOperation2(int x, out int result) //a method with output parameters.
        {
            result = x / 5;
        }

        public void MathOperation(int x, int y) //Overload a method.
        {
            int result = x + y;

        }
    }

}
