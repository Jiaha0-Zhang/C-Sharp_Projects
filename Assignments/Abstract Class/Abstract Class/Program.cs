using System;


namespace Abstract_Class
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" }; //Instantiation

            employee.SayName(); // Call method SayName() from superclass

            Console.Read();

        }
    }
}
