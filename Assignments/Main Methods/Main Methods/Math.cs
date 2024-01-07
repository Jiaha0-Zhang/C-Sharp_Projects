using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Methods
{
    internal class Math
    {
        public int MathOperation(int x)
        {
            return x + 5;
        }

        public int MathOperation(decimal x)
        {
            return (int)x + 5;
        }

        public int MathOperation(string x)
        {
            return int.Parse(x) * int.Parse(x);
        }
    }
}
