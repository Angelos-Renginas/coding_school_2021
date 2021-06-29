using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_18_Exercises {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void ctrlStudents_Click(object sender, EventArgs e) {
            StudentCourseForm sf = new StudentCourseForm();
            sf.Type = Model.enums.ObjectCategoryEnum.Student;
            sf.Show();
        }

        private void ctrlCourses_Click(object sender, EventArgs e) {
            StudentCourseForm sf = new StudentCourseForm();
            sf.Type = Model.enums.ObjectCategoryEnum.Course;
            sf.Show();
        }
    }
}
