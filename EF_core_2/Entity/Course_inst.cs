using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_2.Entity
{
    internal class Course_inst
    {
        public int Ins_ID { get; set; }
        public int Course_ID { get; set; }
        public string? Evaluation { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
