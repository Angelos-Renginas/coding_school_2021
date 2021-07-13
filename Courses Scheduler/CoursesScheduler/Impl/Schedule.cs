using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesScheduler.Impl {
    public class Schedule : Entity{

        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public Guid StudentID { get; set; }
        public string Calendar { get; set; }

        ~Schedule() {

        }
    }
}
