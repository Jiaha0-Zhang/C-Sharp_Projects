using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week");
                string enterText = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), enterText); //another example: Colors orange = (Colors) Enum.Parse(typeof(Colors), "Red, Yellow");
     
                Console.WriteLine("The day of the week you entered is: " + day );
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }
    }
}
