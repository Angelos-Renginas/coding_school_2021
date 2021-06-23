using Session_11_Exercises.Impl;
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

namespace Session_11_Exercises.WUI {
    public partial class MdiMainForm : Form {

        private University CodingSchool = new University();

        private const string _JsonFile = "UniversityData.json";

        public MdiMainForm() {
            InitializeComponent();
          
        }

        private void MdiMainForm_Load(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

       
        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            DeserializeFromJson();
        }

        private void MdiMainForm_Save(object sender, EventArgs e) {
            SerializeToJson();
        }

        private void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // TODO: SERIALIZE UNIVERSITY OBJECT INSTEAD OF STUDENTS!
            string data = serializer.Serialize(CodingSchool);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }

        private void DeserializeFromJson() {
            try {

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path)) {
                    string data = File.ReadAllText(path);
                    CodingSchool = serializer.Deserialize<University>(data);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e) {
            AddEntity(EntityTypeEnum.Student);
        }

        private void addProfessorToolStripMenuItem1_Click(object sender, EventArgs e) {
            AddEntity(EntityTypeEnum.Professor);
        }

        private void addCourseToolStripMenuItem2_Click(object sender, EventArgs e) {
            AddEntity(EntityTypeEnum.Course);
        }

        #region AddEntitiesMethods

        //private void AddStudent() {
        //    Student student = new Student();

        //    StudentForm studentForm = new StudentForm();
        //    studentForm.MdiParent = this;
        //    studentForm.MyStudent = student;

        //    studentForm.Show();
        //    CodingSchool.Students.Add(student);


        //}

        //private void AddProfessor() {
        //    Professor professor = new Professor();

        //    ProfessorForm professorForm = new ProfessorForm();
        //    professorForm.MdiParent = this;
        //    professorForm.MyProfessor = professor;

        //    professorForm.Show();
        //    CodingSchool.Professors.Add(professor);  
        //}

        //private void AddCourse() {
        //    Course course = new Course();

        //    CourseForm courseForm = new CourseForm();
        //    courseForm.MdiParent = this;
        //    courseForm.MyCourse = course;

        //    courseForm.Show();
        //    CodingSchool.Courses.Add(course);

        //}
        #endregion

        private void AddEntity(EntityTypeEnum entityType) {

            switch (entityType) {
                case EntityTypeEnum.Course:
                    Course courseEntity = new Course();
                    EditForm courseForm = new EditForm();
                    courseForm.MdiParent = this;

                    courseForm.Type = entityType;
                    courseForm.EditObject = courseEntity;
                    courseForm.Show();

                    //if (courseForm.ShowDialog() == DialogResult.OK) {
                    CodingSchool.Courses.Add(courseEntity);
                    //}
                    break;

                case EntityTypeEnum.Student:
                    Student studentEntity = new Student();
                    EditForm studentForm = new EditForm();
                    studentForm.MdiParent = this;
                    

                    studentForm.Type = entityType;
                    studentForm.EditObject = studentEntity;
                    studentForm.Show();
                    //if (studentForm.ShowDialog() == DialogResult.OK) {
                    CodingSchool.Students.Add(studentEntity);
                   // }
                    break;

                case EntityTypeEnum.Professor:
                    Professor professorEntity = new Professor();
                    EditForm professorForm = new EditForm();
                    professorForm.MdiParent = this;
                    

                    professorForm.Type = entityType;
                    professorForm.EditObject = professorEntity;
                    professorForm.Show();

                    //if (professorForm.ShowDialog() == DialogResult.OK) {
                    CodingSchool.Professors.Add(professorEntity);
                    //}
                    break;
            }

           
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Student;
            viewForm.MasterData = CodingSchool;

            viewForm.ViewData = GetStudentList();
            viewForm.Show();
        }

        private void viewProfessorsToolStripMenuItem_Click(object sender, EventArgs e) {

            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Professor;
            viewForm.MasterData = CodingSchool;

            viewForm.ViewData = GetProfessorsList();
            viewForm.Show();
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Course;
            viewForm.MasterData = CodingSchool;

            viewForm.ViewData = GetCoursesList();
            viewForm.Show();
        }


        private List<string> GetStudentList() {

            List<string> studentList = new List<string>();

            try {

                if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {
                    foreach (Student item in CodingSchool.Students) {

                        studentList.Add(string.Format("ID={3} \t Name={0} \t Surname={1} \t RegistrationNumber={2}", item.Name, item.Surname, item.RegistrationNumber, item.ID));
                    }
                }
                else {
                    MessageBox.Show("No student data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentList;
        }

       

        private List<string> GetProfessorsList() {
            List<string> professorsList = new List<string>();

            try {

                if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {


                    foreach (Professor item in CodingSchool.Professors) {

                        professorsList.Add(string.Format("ID-{3} \t Name={0} \t Surname={1} \t Rank={2}", item.Name, item.Surname, item.Rank, item.ID));
                    }
                }
                else {
                    MessageBox.Show("No course data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return professorsList;
        }


        private List<string> GetCoursesList() {

            List<string> coursesList = new List<string>();

            try {

                if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {


                    foreach (Course item in CodingSchool.Courses) {

                        coursesList.Add(string.Format("ID={2} \t Code={0} \t Subject={1} ", item.Code, item.Subject, item.ID));
                    }
                }
                else {
                    MessageBox.Show("No course data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong happened! Please send me the log file!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return coursesList;
        }

      
    }
}
