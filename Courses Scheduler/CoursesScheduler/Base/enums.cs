using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesScheduler.Base {
    
    public enum CoursesCategoryEnum {
        Physics = 0,
        Chemistry = 1,
        Financial = 2,
        Mathematics = 3
    }


    public class ItemType {
        public Int16 Value { get; set; }
        public string Description { get; set; }
    }

    public enum EntityTypeEnum { 
        Student,
        Professor,
        Course
    }

}
