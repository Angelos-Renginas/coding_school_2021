using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18_Exercises.Model {
    public class Course : Entity{

        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }

    }
}
