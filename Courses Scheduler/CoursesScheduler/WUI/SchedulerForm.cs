using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using CoursesScheduler.Base;
using CoursesScheduler.Impl;

namespace CoursesScheduler.WUI {

    public partial class SchedulerForm : Form {

        private University UniveristyObject = new University();
        private JsonHandler MyJsonHandler { get; set; }

        public SchedulerForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }

        private void SchedulerForm_Load(object sender, EventArgs e) {
            DeserializeData();
            PopulateListView();
            
        }

        #region JsonHandler
        private void DeserializeData() {
            UniveristyObject = MyJsonHandler.DeserializeFromJson();
        }

        private void SerializeData() {
            MyJsonHandler.SerializeToJson(UniveristyObject);
        }
        #endregion


        #region Event Handling


        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e) {
            SerializeData();
        }


        private void tabControlScheduler_SelectedIndexChanged(object sender, EventArgs e) {
            PopulateListView();
        }

        private void ctrlSchedulerListVIew_MouseDoubleClick(object sender, MouseEventArgs e) {
            DoubleClickToEditListItem();

        }


        private void btnDeleteRecord_Click(object sender, EventArgs e) {
            DeleteRecord();
        }


        private void addToScheduleToolStripMenuItem_Click(object sender, EventArgs e) {
            AddNewSchedule();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e) {
            AddNewSchedule();
        }


        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e) {
            AddStudent();
        }

        private void addProfessorToolStripMenuItem_Click(object sender, EventArgs e) {
            AddProfessor();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e) {
            AddCourse();
        }

        #endregion


        #region Student Methods
        private void AddStudent() {
            Student student = new Student();
            DialogResult returned = EditStudent(student);
            if (returned == DialogResult.OK) {
                UniveristyObject.Students.Add(student);
                SerializeData();
            }

            PopulateListView();
        }

        private DialogResult EditStudent(Student student) {
            EditForm studentForm = new EditForm();

            studentForm.EditObject = student;
            studentForm.Type = EntityTypeEnum.Student;

            DialogResult result = studentForm.ShowDialog();
            if (result == DialogResult.OK) {
                SerializeData();
                PopulateListView();
                
            }
            return result;
        }
        #endregion


        #region Professor Methods

        private void AddProfessor() {

            Professor professor = new Professor();
            DialogResult returned = EditProfessor(professor);

            if (returned == DialogResult.OK) {
                UniveristyObject.Professors.Add(professor);
                SerializeData();
            }
            PopulateListView();

        }

        private DialogResult EditProfessor(Professor professor) {
            EditForm professorForm = new EditForm();

            professorForm.EditObject = professor;
            professorForm.Type = EntityTypeEnum.Professor;

            DialogResult result = professorForm.ShowDialog();
            if (result == DialogResult.OK) {
                SerializeData();
                PopulateListView();
            }
            return result;
        }

        #endregion


        #region Course Methods

        private void AddCourse() {
            Course course = new Course();
            DialogResult returned = EditCourse(course);

            if (returned == DialogResult.OK) {
                UniveristyObject.Courses.Add(course);
                SerializeData();
            }
            PopulateListView();

        }

        private DialogResult EditCourse(Course course) {
            EditForm courseForm = new EditForm();

            courseForm.EditObject = course;
            courseForm.Type = EntityTypeEnum.Course;

            DialogResult result = courseForm.ShowDialog();
            if (result == DialogResult.OK) {
                SerializeData();
                PopulateListView();
            }
            return result;
        }
        #endregion


        #region ListView Methods

        private void PopulateListView() {

            if (tabControlScheduler.SelectedTab == tabPageStudents) {

                LoadListColumns();
                foreach (Student student in UniveristyObject.Students) {

                    string[] studentDataArray = new string[] { student.Name, student.Surname, student.Age.ToString(), student.RegistrationNumber, string.Join(", ", student.CanLearn.ToArray()) };
                    ctrlTabbedListView.Items.Add(new ListViewItem(studentDataArray));
                }
                tabPageStudents.Controls.Add(ctrlTabbedListView);
            }
            else if (tabControlScheduler.SelectedTab == tabPageProfessors) {
                LoadListColumns();
                foreach (Professor professor in UniveristyObject.Professors) {

                    string[] professorDataArray = new string[] { professor.Name, professor.Surname, professor.Rank, string.Join(", ", professor.CanTeach.ToArray()) };
                    ctrlTabbedListView.Items.Add(new ListViewItem(professorDataArray));
                }
                tabPageProfessors.Controls.Add(ctrlTabbedListView);
            }
            else if (tabControlScheduler.SelectedTab == tabPageCourses) {
                LoadListColumns();
                foreach (Course course in UniveristyObject.Courses) {
                    string[] coursesDataArray = new string[] { course.Subject, course.Category.ToString(), course.Hours.ToString() };
                    ctrlTabbedListView.Items.Add(new ListViewItem(coursesDataArray));
                }
                tabPageCourses.Controls.Add(ctrlTabbedListView);
            }

            foreach (Schedule schedule in UniveristyObject.ScheduleList) {

                Student student = UniveristyObject.Students.Find(x => x.Id == schedule.StudentID);
                Course course = UniveristyObject.Courses.Find(x => x.Id == schedule.CourseID);
                Professor professor = UniveristyObject.Professors.Find(x => x.Id == schedule.ProfessorID);

                string date = schedule.Calendar;
                string studentFullName = student.Name + " " + student.Surname;
                string professorFullName = professor.Name + " " + professor.Surname;

                Tuple<int, int> myDateTuple = ConvertToTimeHours(Convert.ToDateTime(date));
                string dateFormat = string.Format(" {0},  {1}-{2}", Convert.ToDateTime(date).ToShortDateString(), myDateTuple.Item1 , myDateTuple.Item2);
                string[] scheduleDataArray = new string[] { studentFullName, professorFullName, course.Subject, dateFormat };
                ctrlScheduleListView.Items.Add(new ListViewItem(scheduleDataArray));
            }
           

        }

        private Tuple<int, int> ConvertToTimeHours(DateTime myDate) {

            int first;
            int last;
            if (myDate.Hour % 2 == 0) {
                first = myDate.Hour - 1;
                last = myDate.Hour + 1;
            }
            else {
                first = myDate.Hour;
                last = myDate.Hour + 2;
            }
            return new Tuple<int, int>(first, last);
        }

        private void LoadListColumns() {


            if (tabControlScheduler.SelectedTab == tabPageStudents) {

                ctrlTabbedListView.Items.Clear();
                ctrlTabbedListView.Columns.Clear();
                ctrlTabbedListView.View = View.Details;
                ctrlTabbedListView.Columns.Add("Name", 150);
                ctrlTabbedListView.Columns.Add("Surname", 200);
                ctrlTabbedListView.Columns.Add("Age", 50);
                ctrlTabbedListView.Columns.Add("Registration Number", 150);
                ctrlTabbedListView.Columns.Add("Can Learn", 200);
            }
            else if (tabControlScheduler.SelectedTab == tabPageProfessors) {

                ctrlTabbedListView.Items.Clear();
                ctrlTabbedListView.Columns.Clear();
                ctrlTabbedListView.View = View.Details;
                ctrlTabbedListView.Columns.Add("Name", 200);
                ctrlTabbedListView.Columns.Add("Surname", 250);
                ctrlTabbedListView.Columns.Add("Rank", 50);
                ctrlTabbedListView.Columns.Add("Can Teach", 250);
            }
            else if (tabControlScheduler.SelectedTab == tabPageCourses) {

                ctrlTabbedListView.Items.Clear();
                ctrlTabbedListView.Columns.Clear();
                ctrlTabbedListView.View = View.Details;
                ctrlTabbedListView.Columns.Add("Subject", 250);
                ctrlTabbedListView.Columns.Add("Category", 250);
                ctrlTabbedListView.Columns.Add("Hours", 250);
            }

            ctrlScheduleListView.Items.Clear();
            ctrlScheduleListView.View = View.Details;
            ctrlScheduleListView.Columns.Add("Student Name", 250);
            ctrlScheduleListView.Columns.Add("Professor Name", 200);
            ctrlScheduleListView.Columns.Add("Course", 150);
            ctrlScheduleListView.Columns.Add("Date", 150);
            

        }

        
        private void DoubleClickToEditListItem() {
            int index = ctrlTabbedListView.SelectedIndices[0];

            if (ctrlTabbedListView.Columns.Count == 3) {
                Course course = UniveristyObject.Courses[index];
                EditCourse(course);

            }
            else if (ctrlTabbedListView.Columns.Count == 4) {
                Professor professor = UniveristyObject.Professors[index];
                EditProfessor(professor);
            }
            else if (ctrlTabbedListView.Columns.Count == 5) {
                Student student = UniveristyObject.Students[index];
                EditStudent(student);
            }
        }

        private void DeleteRecord() {
            int index = ctrlTabbedListView.SelectedIndices[0];

            if (ctrlTabbedListView.Columns.Count == 3) {
                Course course = UniveristyObject.Courses[index];
                UniveristyObject.Courses.RemoveAll(x => x.Id == course.Id);


            }
            else if (ctrlTabbedListView.Columns.Count == 4) {
                Professor professor = UniveristyObject.Professors[index];
                UniveristyObject.Professors.RemoveAll(x => x.Id == professor.Id);

            }
            else if (ctrlTabbedListView.Columns.Count == 5) {
                Student student = UniveristyObject.Students[index];
                UniveristyObject.Students.RemoveAll(x => x.Id == student.Id);

            }
            SerializeData();
            PopulateListView();
        }

        #endregion


        #region Schedule Methods
        private void AddNewSchedule() {
            AddScheduleForm addSchedule = new AddScheduleForm();
            Schedule schedule = new Schedule();
            addSchedule.UniversityData = UniveristyObject;
            addSchedule.MySchedule = schedule;


            DialogResult result = addSchedule.ShowDialog();
            if (result == DialogResult.OK) {
                UniveristyObject.ScheduleList.Add(schedule);
                SerializeData();
            }
            PopulateListView();
        }

        #endregion

    }
}

