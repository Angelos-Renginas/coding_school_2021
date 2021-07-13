using CoursesScheduler.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesScheduler.Impl {
    public class Professor : Person {
        
        public string Rank { get; set; }
        public List<CoursesCategoryEnum> CanTeach { get; set; }
        public string FullName {
            get {
                return Name + " " + Surname + " | " + Rank;
            }
        }
        
    }
}
