using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {

    public class University : Institute {

        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourse { get; set; }

        public University() {
            //constructor for University Class
        }

        public Student[] GetStudent() {
            return Students;
        }

        public Course[] GetCourses() {
            return Courses;
        }

        public Grade[] GetGrades() {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime dateTime) {
            //method to set a professor teach a specific course at a specific time
        }

    }
}
