using Session_9_Exercises.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9_Exercises.Impl {

    public class Schedule : Entity {


        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        // CONSTRUCTOR
        public Schedule()
            : base() {

        }
    }
}
