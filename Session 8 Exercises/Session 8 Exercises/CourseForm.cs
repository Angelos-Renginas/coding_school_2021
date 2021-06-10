using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_8_Exercises {
    public partial class CourseForm : Form {

        public Course MyCourse { get; set; }
        public MainForm MyMainForm { get; set; }
        public object EnumUtil { get; private set; }

        public CourseForm() {
            InitializeComponent();
           
        }

        public CourseForm(MainForm mainForm, Course course) {
            InitializeComponent();
            
           
            MyMainForm = mainForm;
            MyCourse = course;
        }

     

        private void OkCourseButton_Click(object sender, EventArgs e) {
           
            MyCourse.Subject = this.SubjectTextEdit.Text;
            MyCourse.Category = ((CoursesCategoryEnum)this.CategoryComboBox.SelectedIndex);

            this.MyMainForm.PassValue(MyCourse);
            this.Close();
        }

        private void CancelCourseButton_Click(object sender, EventArgs e) {
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
