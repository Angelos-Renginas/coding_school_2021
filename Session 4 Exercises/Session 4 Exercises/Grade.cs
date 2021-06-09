using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {

    public class Grade {

        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }

        public Grade(Guid studentID, Guid courseID, int gradeValue) {

            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            GradeValue = gradeValue;

        }

    }
}
