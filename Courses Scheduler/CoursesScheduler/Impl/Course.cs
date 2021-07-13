using CoursesScheduler.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesScheduler.Impl {
    public class Course : Entity {
        public string Code { get; set; }
        public string Subject { get; set; }

        public string Description {
            get {
                return Subject + " | " + Category.ToString();
            }
        }

        public int Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }

    }
}
