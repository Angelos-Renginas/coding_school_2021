using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {

    public class Student: Person {

        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public Student() {
            //constructor for Student Class
        }

        public void Attend(Course course, DateTime dateTime) {
            //method to represent a student attending to a course at a specific time
        }

        public void WriteExam(Course course, DateTime dateTime) {
            //method to represent a student having an examination of a course at a specific time
        }

    }
}
