using Session_11_Exercises.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11_Exercises.Impl {

    public class Course : Entity {

        // PROPERTIES
        public string Code { get; set; }
        public string Subject { get; set; }
        public int Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }

        // CONSTRUCTOR
        public Course()
            : base() {

        }

        // METHODS
    }
}
