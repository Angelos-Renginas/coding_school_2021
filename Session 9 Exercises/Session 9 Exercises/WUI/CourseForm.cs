using Session_9_Exercises.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_9_Exercises {
    public partial class CourseForm : Form {

        public Course MyCourse { get; set; }

        public CourseForm() {
            InitializeComponent();
           
        }
     

        private void OkCourseButton_Click(object sender, EventArgs e) {
           
            MyCourse.Subject = Convert.ToString(ctrlSubjectTextEdit.EditValue);
            MyCourse.Category = ((CoursesCategoryEnum)ctrlCategoryComboBox.SelectedIndex);
            MyCourse.Hours = Convert.ToInt32(ctrlHoursNumeric.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelCourseButton_Click(object sender, EventArgs e) {
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
