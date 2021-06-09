using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {

    public class Schedule {

        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule(Guid courseID, Guid professorID, DateTime callendar) {

            ID = Guid.NewGuid();
            CourseID = courseID;
            ProfessorID = professorID;
            Callendar = callendar;

        }
    }
}
