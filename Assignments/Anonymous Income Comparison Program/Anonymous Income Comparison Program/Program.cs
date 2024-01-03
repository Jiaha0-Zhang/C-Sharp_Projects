using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"+"\n"); //print out the program title

            Console.WriteLine("Person 1"); //person 1 info
            Console.WriteLine("What is your hourly Rate?");
            float hourlyRate1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many hours you work per week?");
            int HoursWorkedPerWeek1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n"+"Person 2"); //person 2 info
            Console.WriteLine("What is your hourly Rate?");
            float hourlyRate2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many hours you work per week?");
            int HoursWorkedPerWeek2 = Convert.ToInt32(Console.ReadLine());

            float annualSalary1 = hourlyRate1 * HoursWorkedPerWeek1 * 52; //Calculate person1's annual salary
            Console.WriteLine("\n" + "Annual salary of Person 1 is " + annualSalary1);
            float annualSalary2 = hourlyRate2 * HoursWorkedPerWeek2 * 52; //Calculate person2's annual salary
            Console.WriteLine("Annual salary of Person 2 is " + annualSalary2);

            bool isMoreSalary = annualSalary1 > annualSalary2;  //declare a boolean to compare annual salary between person1 and person2
            Console.WriteLine("\n"+ "Does Person1 make more money than Person2?" +"\n"+isMoreSalary);
            Console.ReadLine();

        }
    }
}
