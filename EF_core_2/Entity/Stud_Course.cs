using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_2.Entity
{
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public double Grade { get; set; }
        public Student? Students { get; set; }
        public Course? Courses { get; set; }
    }
}
