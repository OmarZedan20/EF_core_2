using EF_core_2.Context;
using EF_core_2.Entity;
using Microsoft.EntityFrameworkCore;

namespace EF_core_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new NewItiDbContext())
            {
                // Create
                var student = new Student
                {
                    FName = "Omar",
                    LName = "Zedan",
                    Age = 24,
                    DepartmentID = 1
                };
                context.Students.Add(student);
                context.SaveChanges();

                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"Student: {s.FName}, Age: {s.Age}");
                }

                NewItiDbContext dbContext = new NewItiDbContext();

                dbContext.Students.Where(S => S.Id == 1);

                // dbContext.Database.Migrate();
            }

        }

    }
}
