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
            int age = Convert.ToInt32(Console.ReadLine()); //input age

            Console.WriteLine("\n"+"Have you ever had a DUI? Please input 'True' or 'False'.");
            bool haveDUL = Convert.ToBoolean(Console.ReadLine()); //input true or false to determine haveDUL

            Console.WriteLine("\n" + "How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); //input speeding tickests

            bool isQualified = age > 15 && !haveDUL && tickets <= 3;  //return true if age over 15 And have no DUL And no more than 3 tickets
            Console.WriteLine("\n"+ "Does the applicant qualify for car insurance" +"\n"+ isQualified);
            Console.ReadLine();
        }
    }
}
