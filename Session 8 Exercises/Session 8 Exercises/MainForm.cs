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

    public partial class MainForm : Form {

        public List<Student> Students = new List<Student>();
        public List<Course> Courses = new List<Course>();
        public List<Professor> Professors = new List<Professor>();


        public MainForm() {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e) {

            Student student = new Student();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!
            // TODO: OPEN FORM ...

            StudentForm studentForm = new StudentForm(this, student);
            studentForm.ShowDialog();
            
        }

        private void AddCourseButton_Click(object sender, EventArgs e) {
            Course course = new Course();

            CourseForm courseForm = new CourseForm(this, course);
            courseForm.ShowDialog();


        }

        private void AddProfessorButton_Click(object sender, EventArgs e) {
            Professor professor = new Professor();
            ProfessorForm professorForm = new ProfessorForm(this, professor);
            professorForm.ShowDialog();
        }



        public void PassValue(Student student) {
            
            Students.Add(student);
            string message = string.Format("{0}, {1}, {2} \n", student.Name, student.Age, student.RegistrationNumber);
            ListViewItem listViewItem = new ListViewItem(message);
            StudentListView.Items.Add(listViewItem);

        }

        public void PassValue(Professor professor) {
           
            Professors.Add(professor);
            string message = string.Format("{0}, {1}, {2} \n", professor.Name, professor.Age, professor.Rank);
            ListViewItem listViewItem = new ListViewItem(message);
            ProfessorListView.Items.Add(listViewItem);

        }

        public void PassValue(Course course) {
            
            Courses.Add(course);
            string message = string.Format("{0}, {1} \n", course.Subject, course.Category.ToString());
            ListViewItem listViewItem = new ListViewItem(message);
            CourseListView.Items.Add(listViewItem);

        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

      

      

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
