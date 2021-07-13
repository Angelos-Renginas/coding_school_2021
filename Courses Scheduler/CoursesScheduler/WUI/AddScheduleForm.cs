using CoursesScheduler.Base;
using CoursesScheduler.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursesScheduler {
    public partial class AddScheduleForm : Form {

        public University UniversityData { get; set; }

        public Schedule MySchedule { get; set; }

        private Course SelectedCourse { get; set; }

        public Student SelectedStudent { get; set; }

        public Professor SelectedProfessor { get; set; }

        public AddScheduleForm() {
            InitializeComponent();
        }

        private void AddScheduleForm_Load(object sender, EventArgs e) {
            SelectCourse();
        }

        public struct HourZone {
            public int StartHour;
            public string FinishHour;
        }

        #region Event Handlers

        private void ctrlCourseComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedCourseChanged();
        }

        private void ctrlProfessorComboBox_MouseClick(object sender, MouseEventArgs e) {
            MessageBoxShow(ctrlCourseComboBox, "course");

        }

        private void ctrlStudentComboBox_MouseClick(object sender, MouseEventArgs e) {
            MessageBoxShow(ctrlCourseComboBox, "course");
        }

        private void ctrlProfessorComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedProfessorChanged();
        }

        private void ctrlStudentComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedStudentChanged();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            CheckValues();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        #endregion


        #region Student Methods
        private void SelectStudent() {

            List<Student> studentsFromCourse = new List<Student>();

            CoursesCategoryEnum categoryEnum = SelectedCourse.Category;

            foreach (Student student in UniversityData.Students) {

                if (student.CanLearn.Contains(categoryEnum)) {
                    studentsFromCourse.Add(student);
                }
            }

            ctrlStudentComboBox.DataSource = studentsFromCourse;
            ctrlStudentComboBox.DisplayMember = "FullName";
            ctrlStudentComboBox.Text = "";
        }


        private void SelectedStudentChanged() {
            SelectedStudent = (Student)ctrlStudentComboBox.SelectedItem;
        }

        #endregion


        #region Professor Methods

        private void SelectProfessor() {

            List<Professor> professorsFromCourse = new List<Professor>();

            CoursesCategoryEnum categoryEnum = SelectedCourse.Category;

            foreach (Professor professor in UniversityData.Professors) {

                if (professor.CanTeach.Contains(categoryEnum)) {
                    professorsFromCourse.Add(professor);
                }

            }

            ctrlProfessorComboBox.DataSource = professorsFromCourse;
            ctrlProfessorComboBox.DisplayMember = "FullName";
            ctrlProfessorComboBox.Text = "";
        }

        private void SelectedProfessorChanged() {
            SelectedProfessor = (Professor)ctrlProfessorComboBox.SelectedItem;
        }

        #endregion


        #region Course Methods
        private void SelectCourse() {
            ctrlCourseComboBox.DataSource = UniversityData.Courses;
            ctrlCourseComboBox.DisplayMember = "Description";
            ctrlCourseComboBox.Text = "";
            ctrlCourseComboBox.SelectedItem = null;

        }

        private void SelectedCourseChanged() {
            if (ctrlCourseComboBox.SelectedItem != null) {
                SelectedCourse = (Course)ctrlCourseComboBox.SelectedItem;

                SelectProfessor();
                SelectStudent();
            }
        }


        #endregion


        #region Check Values to Add Schedule

        private void CheckValues() {
            MySchedule.StudentID = SelectedStudent.Id;
            MySchedule.CourseID = SelectedCourse.Id;
            MySchedule.ProfessorID = SelectedProfessor.Id;
            MySchedule.Calendar = ctrlScheduleDateTimePicker.Value.ToString();

            if (string.IsNullOrEmpty(ctrlCourseComboBox.Text)) {
                MessageBox.Show("You have to select a course.");
            }
            else if (string.IsNullOrEmpty(ctrlProfessorComboBox.Text)) {
                MessageBox.Show("You have to select a professor.");
            }
            else if (string.IsNullOrEmpty(ctrlStudentComboBox.Text)) {
                MessageBox.Show("You have to select a sudent.");
            }
            else if (StudentAttendsACourseAtDate(MySchedule)) {
                MessageBox.Show("Students cannot attend two courses at the same time");
            }
            else if (StudentAttendsMoreThanThreeCoursesPerDay(MySchedule)) {
                MessageBox.Show("Students cannot attend more than three courses per day");
            }
            else if (ProfessorTeachesCourseAtDate(MySchedule)) {
                MessageBox.Show("Professors cannot teach two courses at the same time");
            }
            else if (ProfessorTeachesMoreThanFourCoursesPerDay(MySchedule)) {
                MessageBox.Show("Professors cannot teach more than four courses per day");
            }
            else {

                DialogResult = DialogResult.OK;
            }
        }

        private bool StudentAttendsMoreThanThreeCoursesPerDay(Schedule mySchedule) {
            bool flag = false;
            int coursesAttended = 0;
            foreach (Schedule schedule in UniversityData.ScheduleList) {

                DateTime myDate = Convert.ToDateTime(mySchedule.Calendar);
                DateTime scheduleDate = Convert.ToDateTime(schedule.Calendar);
                Student student = UniversityData.Students.Find(x => x.Id == mySchedule.StudentID);

                if (student.Id == schedule.StudentID && myDate.Date == scheduleDate.Date) {
                    coursesAttended++;
                }
                if (coursesAttended == 3) {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private bool StudentAttendsACourseAtDate(Schedule mySchedule) {
            bool flag = false;
            foreach (Schedule schedule in UniversityData.ScheduleList) {

                Student student = UniversityData.Students.Find(x => x.Id == mySchedule.StudentID);

                DateTime myDate = Convert.ToDateTime(mySchedule.Calendar);
                DateTime scheduleDate = Convert.ToDateTime(schedule.Calendar);

                TimeSpan timeDifference = myDate - scheduleDate;
                Tuple<int, int> myDateTuple = ConvertToTimeHours(myDate);
                Tuple<int, int> scheduleDateTuple = ConvertToTimeHours(scheduleDate);

                if (student.Id == schedule.StudentID && myDate.Date == scheduleDate.Date && myDateTuple.Equals(scheduleDateTuple)) {
                    flag = true;
                    break;
                }

            }
            return flag;
        }



        private bool ProfessorTeachesCourseAtDate(Schedule mySchedule) {
            bool flag = false;
            foreach (Schedule schedule in UniversityData.ScheduleList) {

                Professor professor = UniversityData.Professors.Find(x => x.Id == mySchedule.ProfessorID);
                DateTime myDate = Convert.ToDateTime(mySchedule.Calendar);
                DateTime scheduleDate = Convert.ToDateTime(schedule.Calendar);

                TimeSpan timeDifference = myDate - scheduleDate;
                Tuple<int, int> myDateTuple = ConvertToTimeHours(myDate);
                Tuple<int, int> scheduleDateTuple = ConvertToTimeHours(scheduleDate);

                if (professor.Id == schedule.ProfessorID && schedule.CourseID != mySchedule.CourseID && myDateTuple.Equals(scheduleDateTuple)) {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

       

        private bool ProfessorTeachesMoreThanFourCoursesPerDay(Schedule mySchedule) {
            bool flag = false;
            int coursestaught= 0;
            foreach (Schedule schedule in UniversityData.ScheduleList) {

                DateTime myDate = Convert.ToDateTime(mySchedule.Calendar);
                DateTime scheduleDate = Convert.ToDateTime(schedule.Calendar);

                Professor professor = UniversityData.Professors.Find(x => x.Id == mySchedule.ProfessorID);

                Tuple<int, int> myDateTuple = ConvertToTimeHours(myDate);
                Tuple<int, int> scheduleDateTuple = ConvertToTimeHours(scheduleDate);

                if (professor.Id == schedule.ProfessorID && myDate.Date == scheduleDate.Date && ((schedule.CourseID != mySchedule.CourseID)||(schedule.CourseID == mySchedule.CourseID && !myDateTuple.Equals(scheduleDateTuple))) ) {
                    coursestaught++;
                }
                if (coursestaught == 4) {
                    flag = true;
                    break;
                }
            }
            return flag;
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

        #endregion

        private void MessageBoxShow(ComboBox comboBox, string type) {
            if (string.IsNullOrEmpty(comboBox.Text)) {
                MessageBox.Show(string.Format("You have to select a {0} first", type));
            }
        }
       
    }
}
