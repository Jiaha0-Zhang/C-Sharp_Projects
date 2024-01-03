using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_approval_program_for_car_insurance
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n"+"Have you ever had a DUI? Please input 'True' or 'False'.");
            bool haveDUL = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n" + "How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool isQualified = age > 15 && !haveDUL && tickets <= 3;
            Console.WriteLine("\n"+ "Does the applicant qualify for car insurance" +"\n"+ isQualified);
            Console.ReadLine();
        }
    }
}
