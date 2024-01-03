using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."+"\n"); //print out title

            Console.WriteLine("Please input your package Weight without a weight unit"); 
            float packageWeight = Convert.ToSingle(Console.ReadLine()); //declare packageWeight and assign it with a input number
            if (packageWeight > 50) //execute it if packageWeight greater than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); 
            }
            else if(packageWeight > 0 && packageWeight <=50) //execute it if packageWeight greater than 0 And packageWeight less or equal than 50
            {
                Console.WriteLine("\n" + "Thank you for your cooperation. Your package is not overweight");

                Console.WriteLine("\n"+ "Please input your package Width without a unit");
                float packageWidth = Convert.ToSingle(Console.ReadLine()); //declare packageWidth and assign it with a input number
                Console.WriteLine("\n" + "Please input your package Height without a unit");
                float packageHeight = Convert.ToSingle(Console.ReadLine()); //declare packageHeight and assign it with a input number
                Console.WriteLine("\n" + "Please input your package Lenth without a unit");
                float packageLength = Convert.ToSingle(Console.ReadLine()); //declare packageLenth and assign it with a input number
                if (packageWidth > 50 ||  packageHeight > 50 || packageLength > 50) //execute it if any of dimensions are greater than 50
                {
                    Console.WriteLine("\n" + "Package too big to be shipped via Package Express.");
                }
                else if(packageWidth > 0 && packageWidth <= 50 && packageHeight > 0 && packageHeight <= 50 && packageLength > 0 && packageLength <= 50)
                {  //execute this if none of the dimensions is greater than 50 meanwhile they all greater than 0
                    Console.WriteLine("\n" + "Thank you for your cooperation. Your package is not oversized");

                    float quote = packageWeight * packageWidth * packageHeight * packageLength / 100; //calculate total quote based on all input infomation
                    Console.WriteLine("\n" + "Your estimated total for shipping this package is: $" + quote + "\n" + "Thank you!");
                }
                else //execute this if a negative number is entered
                {
                    Console.WriteLine("Oops, something went wrong...You may have entered a wrong number");
                }
            }
            else //execute this if a negative number is entered
            {
                Console.WriteLine("Oops, Something went wrong...You may have entered a wrong number");               
            }
            Console.ReadLine();
        }
    }
}
