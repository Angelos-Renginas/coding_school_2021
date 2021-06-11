using Session_9_Exercises.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Session_9_Exercises {


    public partial class MainForm : Form {

        University CodingSchool = new University("EpsilonNet Coding School", 1);
        private const string _JsonFile = "UniversityData.json";


        public MainForm() {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e) {

            AddStudent();
            RefreshStudentList();
            
        }

        private void AddCourseButton_Click(object sender, EventArgs e) {

            AddCourse();
            RefreshCourseList();

        }

        private void AddProfessorButton_Click(object sender, EventArgs e) {

            AddProfessor();
            RefreshProfessorList();
            
        }


        private void AddCourse() {
            Course course = new Course();

            CourseForm courseForm = new CourseForm();
            courseForm.MyCourse = course;

            DialogResult result = courseForm.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Courses.Add(course);
                    break;

                default:
                    // messagge  ?
                    break;
            }

        }

        private void AddStudent() {

            Student student = new Student();
           
            StudentForm studentForm = new StudentForm();
            studentForm.MyStudent = student;

            DialogResult result = studentForm.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Students.Add(student);
                    break;

                default:
                    // messagge  ?
                    break;
            }
        }

        private void AddProfessor() {
            Professor professor = new Professor();

            ProfessorForm professorForm = new ProfessorForm();
            professorForm.MyProfessor = professor;

            DialogResult result = professorForm.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Professors.Add(professor);
                    break;

                default:
                    // messagge  ?
                    break;
            }
        }


        private void RefreshCourseList() {
            ctrlCourseList.Items.Clear();
            foreach (Course item in CodingSchool.Courses) {

                ctrlCourseList.Items.Add(string.Format("{0}, {1}, {2}", item.Subject, item.Category.ToString(), item.Hours));
            }
        }

        private void RefreshStudentList() {
            ctrlStudentList.Items.Clear();
            foreach (Student item in CodingSchool.Students) {

                ctrlStudentList.Items.Add(string.Format("{0}, {1}, {2}, {3}", item.Name, item.Surname, item.Age, item.RegistrationNumber));
            }
        }

        private void RefreshProfessorList() {
            ctrlProfessorList.Items.Clear();
            foreach (Professor item in CodingSchool.Professors) {

                ctrlProfessorList.Items.Add(string.Format("{0}, {1}, {2}, {3}", item.Name, item.Surname, item.Age, item.Rank));
            }
        }


        private void ctrlSerialize_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

        private void SerializeToJson() {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // TODO: SERIALIZE UNIVERSITY OBJECT INSTEAD OF STUDENTS!
            string data = serializer.Serialize(CodingSchool);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);
        }

        private void ctrlDeserialize_Click(object sender, EventArgs e) {
            DeserializeFromJson();
            RefreshStudentList();
            RefreshCourseList();
            RefreshProfessorList();
        }

        private void DeserializeFromJson() {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);
            CodingSchool = serializer.Deserialize<University>(data);
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

      
    }
}
