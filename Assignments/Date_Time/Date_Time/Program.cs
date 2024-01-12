using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    internal class Program
    {
        static void Main()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date and time is {0}  ", currentTime);

            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(number > 0)
                {
                    DateTime futureTime = currentTime.AddHours(number);
                    Console.WriteLine("After {0} hours, it will be {1}", number, futureTime);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
