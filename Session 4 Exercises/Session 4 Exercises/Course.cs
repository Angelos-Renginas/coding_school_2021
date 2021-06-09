using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {

    public class Course {

        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }


        public Course(Guid courseID, string code, string subject) {

            ID = courseID;
            Code = code;
            Subject = subject;

        }
    }

    
}
