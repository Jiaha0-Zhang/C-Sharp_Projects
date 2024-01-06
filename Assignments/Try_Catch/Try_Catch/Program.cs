using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            try
            {
                List<int> numberList = new List<int>() { 88, 20, 25, 36, 45, 60 };
                Console.WriteLine("Please enter a number as divisor.");
                int divisor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numberList.Count; i++)
                {
                    Console.WriteLine(numberList[i] + " divided by " + divisor + " equals " +numberList[i] / divisor);
                }

            }
            catch(DivideByZeroException) //print off this if a zero input happened
            {
                Console.WriteLine("Please input other whole numbers as divisor instead of Zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // print off error messages in case of an exception
            }
            finally
            {
                Console.WriteLine("Program has emerged from the try/catch block and continued on with program execution.");
            }
            Console.ReadLine();
        }
    }
}
