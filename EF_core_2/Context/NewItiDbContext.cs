using EF_core_2.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_2.Context
{
    internal class NewItiDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOPp-ND54KPV ; Database = NewIti ; Trusted_Connection = True ; Encrypt = False ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
              new Department { Id = 3, Name = "C#", HiringDate = new DateTime(2000, 1, 1) }
);

            modelBuilder.Entity<Student>()
                   .HasOne(s => s.Departments)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentID);

            modelBuilder.Entity<Course>()
                   .HasOne(c => c.Departments)
                   .WithMany(d => d.Courses)
                   .HasForeignKey(c => c.DepartmentID);
            modelBuilder.Entity<Course_inst>()
                .HasKey(ci => new { ci.ins_ID, ci.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_Id, sc.Course_Id });

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_inst> Course_insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}
