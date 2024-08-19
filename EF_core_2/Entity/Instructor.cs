using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_2.Entity
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Bouns { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public DateTime HourRate { get; set; }
        public Department Dep_id { get; set; }
    }
}
