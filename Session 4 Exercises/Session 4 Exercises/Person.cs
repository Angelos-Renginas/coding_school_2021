using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {

    public class Person {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() {
            //constructor for Person Class
        }

        public virtual string GetName() {
            return Name;
        }

        public void SetName(string name) {
            Name = name;
        }

    }
}
