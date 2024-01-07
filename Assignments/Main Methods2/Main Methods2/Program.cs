using System;


namespace Main_Methods2
{
    internal class Program
    {
        static void Main()
        {
            Math math = new Math();

            Console.WriteLine("Please input the first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number or press 'Enter' button if you don't want to input the second number.");
            string secondNum = Console.ReadLine();

            if(string.IsNullOrEmpty(secondNum))
            {
                int result = math.AdditionOperation(firstNum);
                Console.WriteLine("The result of first number plus nothing is: " + result);
            }
            else
            {
                int result = math.AdditionOperation(firstNum, int.Parse(secondNum));
                Console.WriteLine("The result of first number plus second number is: " + result);
            }

           
            Console.ReadLine();
        }
    }
}
