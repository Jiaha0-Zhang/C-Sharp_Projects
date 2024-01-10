using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> //instantiation
            {
                new Employee { Id = 1, FirstName = "Sam", LastName = "Smith" }, 
                new Employee { Id = 2, FirstName = "John", LastName = "Johnson" }, 
                new Employee { Id = 3, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 4, FirstName = "Cindy", LastName= "Martinez" },
                new Employee { Id = 5, FirstName = "Joe", LastName= "Brown" },
                new Employee { Id = 6, FirstName = "Joe", LastName= "Miller" },
                new Employee { Id = 7, FirstName = "Peggy", LastName= "Hill" },
                new Employee { Id = 8, FirstName = "Sue", LastName= "Green" },
                new Employee { Id = 9, FirstName = "luke", LastName= "Shaw" },
                new Employee { Id = 10, FirstName = "Fred", LastName= "Evans" },
            };

            //List<Employee> nameJoe = new List<Employee>(); 
            foreach (Employee employee in employees) //normal foreach loop
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine("Employees with first name Joe are: " + employee.FirstName + " . " + employee.LastName);
                }
            }
            

            List<Employee> firstNameJoe = employees.Where(x => x.FirstName == "Joe").ToList(); //lambda expression
            //Console.WriteLine(firstNameJoe); 

            //PLEASE SEE HERE
            //I don't know why I can't find properties in firstNameJoe, unlike normal foreach loop, "employee" does have ID,FirstName and  LastName property
            //PLEASE SEE HERE

            List<Employee> idGreaterThan5 = employees.Where(x => x.Id == 5).ToList(); //lambda expression

            Console.ReadLine();
        }
        
    }
}
