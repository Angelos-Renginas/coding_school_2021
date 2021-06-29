using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18_Exercises.Model {
    public class Student : Entity{

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public Student() {

        }

    }
}
