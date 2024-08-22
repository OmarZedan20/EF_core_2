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
            optionsBuilder.UseSqlServer("server = . ; Database = NewIti ; Trusted_Connection = True ; Encrypt = False ");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                   .HasOne(s => s.Departments)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentID);

            modelBuilder.Entity<Course>()
                   .HasOne(c => c.Topics)
                   .WithMany(d => d.Courses)
                   .HasForeignKey(c => c.Topic_Id);
            modelBuilder.Entity<Course_inst>()
                .HasKey(ci => new { ci.Ins_ID, ci.Course_ID });
            modelBuilder.Entity<Course_inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Insts)
                .HasForeignKey(ci => ci.Ins_ID);
            modelBuilder.Entity<Course_inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Insts)
                .HasForeignKey(ci => ci.Course_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_Id, sc.Course_Id });
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Students)
                .WithMany(s => s.Stud_Courses)
                .HasForeignKey(sc => sc.Stud_Id);
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Courses)
                .WithMany(c => c.Stud_Courses)
                .HasForeignKey(sc => sc.Course_Id);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Dep_id)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID);


           // modelBuilder.Entity<Department>()
                //.HasOne(d => d.Instructor)
                //.WithMany()
                //.HasForeignKey(d => d.Ins_id);




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
