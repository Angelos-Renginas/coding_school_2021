using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {
    class Professor : Person {

        public string Rank { get; set; }
        public Course[] Courses { get; set; }

        public Professor() {
            //constructor for Professor Class
        }

        public void Teach(Course course, DateTime dateTime) {
            //method to represent a Professor teaching a course at a specific time
        }

        public void SetGrade(Guid studentID, Guid courseID, int grade) {
            //method to set a student's grade for a specific course
            new Grade(studentID,courseID,grade);
        }

        public override string GetName() {
            return "Dr." + base.GetName();
        }
    }
}
