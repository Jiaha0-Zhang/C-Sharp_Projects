using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class MathOperations
    {
        public int Square(int x)
        {
            return x * x;
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public int MinusFive (int x)
        {
            return x - 5;
        }

        public int AddFive(int x)
        {
            return x + 5;
        }
    }
}
