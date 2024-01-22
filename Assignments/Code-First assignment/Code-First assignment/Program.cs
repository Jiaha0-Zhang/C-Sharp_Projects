using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Code_First_assignment
{
    internal class Program
    {
        static void Main()
        {

            using (var context = new StudentContext())
            {
                var newStudent = new Student
                {
                    Id = 1,
                    FirstName = "Joe",
                    LastName = "Smith",
                    Scores = new List<StudentScore>
                    {
                        new StudentScore { MathScore = 95.5f, HistoryScore = 82, EnglishScore = 89.5f }
                    }
                };

                context.Students.Add(newStudent);

                context.SaveChanges();
            }

            Console.WriteLine("Student and scores has added to the database.");
            Console.ReadLine();
        }
    }
}
