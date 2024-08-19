using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_2.Entity
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public string Description { get; set; }
        public int Topic_Id { get; set; }
        public int DepartmentID { get; set; }
        public Department Departments { get; set; }

    }
}
