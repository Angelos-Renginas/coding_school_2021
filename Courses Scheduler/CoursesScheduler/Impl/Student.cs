using CoursesScheduler.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesScheduler.Impl {
    public class Student : Person {

        public string RegistrationNumber { get; set; }
        public int Age { get; set; }

        public string FullName {
            get {
                return Name + " " + Surname + " | " + RegistrationNumber;
            }
        }
        public List<CoursesCategoryEnum> CanLearn { get; set; }
        
    }
}
