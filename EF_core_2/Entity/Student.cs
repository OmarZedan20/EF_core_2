﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_2.Entity
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        public int DepartmentID { get; set; }
        public Department Departments { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; }

    }
}
