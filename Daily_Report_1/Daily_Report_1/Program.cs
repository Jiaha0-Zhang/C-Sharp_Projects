using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.\nStudent Daily Report." + "\n"); //Print out The Tech Academy and Student Daily Report. 

            Console.WriteLine("What is your name?"); //Print out the question
            string yourName = Console.ReadLine(); //input a string
            Console.WriteLine("Your name is " + yourName + "\n"); //Combine a sentence with the input String .

            Console.WriteLine("What course are you on?"); //Print out the question
            string courseName = Console.ReadLine(); //input a string
            Console.WriteLine("You are on the course " + courseName + "\n"); //Combine a sentence with the input String .

            Console.WriteLine("What page number?"); // Print out the question
            string pageNumber = Console.ReadLine(); //input a string
            Console.WriteLine("You are on the page number " + pageNumber + "\n"); //Combine a sentence with the input String .

            Console.WriteLine("Do you need help with anything?"); //Print out the question
            bool isNeedHelp = false; //declare a boolean
            Console.WriteLine(isNeedHelp + "\n"); //print out the input boolean

            Console.WriteLine("Were there any positive experiences you’d like to share?");
            Console.WriteLine("Nope" + "\n");

            Console.WriteLine("Is there any other feedback you’d like to provide?");
            Console.WriteLine("No feedback so far." + "\n");

            Console.WriteLine("How many hours did you study today?");
            Console.WriteLine("Approximately 5 or 6 hours." + "\n");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! ");

            Console.ReadLine();
        }
    }
}
