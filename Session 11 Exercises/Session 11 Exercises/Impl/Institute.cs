using Session_11_Exercises.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11_Exercises.Impl {

    public class Institute : Entity {
        public string Name { get; set; }
        public int YearsInService { get; set; }


        public Institute(string name,int years) : base() {
            Name = name;
            YearsInService = years;
        }

        public Institute(): base() {

        }
    }
}
