using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public static bool operator == (Employee em1, Employee em2)
        {
            return (em1.Id == em2.Id);
        }

        public static bool operator != (Employee em1, Employee em2)
        { 
            return !(em1.Id == em2.Id);
        }
    }
}
