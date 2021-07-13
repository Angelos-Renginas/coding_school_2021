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
    public partial class EditForm : Form {

        public object EditObject { get; set; }

        public EntityTypeEnum Type { get; set; }

        public EditForm() {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e) {
            LoadData();
        }

        #region eventHandling

        private void btnAddCourse_Click(object sender, EventArgs e) {
            AddCourseToSelectedCourses();
        }
        private void btnRemoveCourse_Click(object sender, EventArgs e) {
            RemoveCourseFromSelectedCourses();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            CheckValues();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        #endregion


        #region Student Methods

        private void LoadStudentData() {

            ctrlTitleLabel.Text = "Add new Student..";
            label3.Text = "Age";
            ctrlAgeNumericDropDown.Visible = true;
            label5.Visible = true;
            ctrlRegistrationNumberTextBox.Visible = true;

            Student student = EditObject as Student;

            SetListsProperties();

            foreach (string category in Enum.GetNames(typeof(CoursesCategoryEnum)).ToList()) {
                ctrlAvailableCoursesListView.Items.Add(category);
            }

            if (!string.IsNullOrWhiteSpace(student.Name)) {

                ctrlNameTextBox.Text = student.Name;
                ctrlSurnameTextBox.Text = student.Surname;
                ctrlAgeNumericDropDown.Value = student.Age;
                ctrlRegistrationNumberTextBox.Text = student.RegistrationNumber;

                foreach (CoursesCategoryEnum categoryEnum in student.CanLearn) {
                    ctrlSelectedCoursesListView.Items.Add(categoryEnum.ToString());
                }

            }

        }

        private void CheckStudentValues() {
            if (string.IsNullOrWhiteSpace(ctrlNameTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Name!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlSurnameTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Surname!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlAgeNumericDropDown.Text.ToString())) {
                MessageBox.Show("Please insert Age!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlRegistrationNumberTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Registration Number!");
            }
            else if (ctrlSelectedCoursesListView.Items.Count == 0) {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to add Courses? ", "No courses Selected.", buttons);
                if (result == DialogResult.No) {
                    InitializeNewStudent();
                }
            }
            else {
                InitializeNewStudent();
            }
        }

        private void InitializeNewStudent() {

            Student student = EditObject as Student;

            student.Name = Convert.ToString(ctrlNameTextBox.Text);
            student.Surname = Convert.ToString(ctrlSurnameTextBox.Text);
            student.Age = (int)ctrlAgeNumericDropDown.Value;
            student.RegistrationNumber = Convert.ToString(ctrlRegistrationNumberTextBox.Text);
            List<CoursesCategoryEnum> canLearn = new List<CoursesCategoryEnum>();

            foreach (ListViewItem courseToLearn in ctrlSelectedCoursesListView.Items) {
                canLearn.Add((CoursesCategoryEnum)Enum.Parse(typeof(CoursesCategoryEnum), courseToLearn.Text));
            }

            student.CanLearn = canLearn;
            DialogResult = DialogResult.OK;
        }

        #endregion


        #region Professor Methods

        private void LoadProfessorData() {

            ctrlAgeNumericDropDown.Visible = false;
            ctrlRankTextBox.Visible = true;
            this.Text = "Add New Professor";

            Professor professor = EditObject as Professor;

            SetListsProperties();
            foreach (string category in Enum.GetNames(typeof(CoursesCategoryEnum)).ToList()) {
                ctrlAvailableCoursesListView.Items.Add(category);
            }

            if (!string.IsNullOrWhiteSpace(professor.Name)) {

                ctrlNameTextBox.Text = professor.Name;
                ctrlSurnameTextBox.Text = professor.Surname;
                ctrlRankTextBox.Text = professor.Rank;


                foreach (CoursesCategoryEnum categoryEnum in professor.CanTeach) {
                    ctrlSelectedCoursesListView.Items.Add(categoryEnum.ToString());
                }

            }
        }

        private void CheckProfessorValues() {
            if (string.IsNullOrWhiteSpace(ctrlNameTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Name!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlSurnameTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Surname!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlRankTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Rank!");
            }
            else if (ctrlSelectedCoursesListView.Items.Count == 0) {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to add Courses? ", "No courses Selected.", buttons);
                if (result == DialogResult.No) {
                    InitializeNewProfessor();
                }
            }
            else {
                InitializeNewProfessor();
            }
        }



        private void InitializeNewProfessor() {
            Professor professor = EditObject as Professor;

            professor.Name = Convert.ToString(ctrlNameTextBox.Text);
            professor.Surname = Convert.ToString(ctrlSurnameTextBox.Text);
            professor.Rank = Convert.ToString(ctrlRankTextBox.Text);

            List<CoursesCategoryEnum> canTeach = new List<CoursesCategoryEnum>();

            foreach (ListViewItem courseToLearn in ctrlSelectedCoursesListView.Items) {
                canTeach.Add((CoursesCategoryEnum)Enum.Parse(typeof(CoursesCategoryEnum), courseToLearn.Text));
            }

            professor.CanTeach = canTeach;
            //MessageBox.Show(string.Format("Name: {0} \nSurname: {1} \nAge: {2}", name, surname, age), "The Student added successfully");
            DialogResult = DialogResult.OK;
        }


        #endregion


        #region Course Methods

        private void LoadCourseData() {
            ctrlTitleLabel.Text = "Add New Course";
            this.Text = "Add New Course";
            label1.Text = "Code";
            label2.Text = "Subject";
            label3.Text = "Hours";
            ctrlAgeNumericDropDown.Value = 0;
            label5.Visible = true;
            label5.Text = "Category";
            ctrlCategoryComboBox.Visible = true;

            ctrlAvailableCoursesListView.Visible = false;
            ctrlSelectedCoursesListView.Visible = false;
            btnAddCourse.Visible = false;
            btnRemoveCourse.Visible = false;
            label4.Visible = false;
            label6.Visible = false;


            Course course = EditObject as Course;

            foreach (string category in Enum.GetNames(typeof(CoursesCategoryEnum)).ToList()) {
                ctrlCategoryComboBox.Items.Add(category);
            }

            if (!string.IsNullOrWhiteSpace(course.Code)) {

                ctrlNameTextBox.Text = course.Code;
                ctrlSurnameTextBox.Text = course.Subject;
                ctrlAgeNumericDropDown.Value = course.Hours;
                ctrlCategoryComboBox.Text = course.Category.ToString();

            }
        }

        private void CheckCourseValues() {
            if (string.IsNullOrWhiteSpace(ctrlNameTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Code!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlSurnameTextBox.Text.ToString())) {
                MessageBox.Show("Please insert Subject!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlAgeNumericDropDown.Text.ToString())) {
                MessageBox.Show("Please insert Hours!");
            }
            else if (string.IsNullOrWhiteSpace(ctrlCategoryComboBox.Text.ToString())) {
                MessageBox.Show("Please insert Category!");
            }
            else {
                InitializeNewCourse();
            }
        }

        private void InitializeNewCourse() {
            Course course = EditObject as Course;


            course.Code = Convert.ToString(ctrlNameTextBox.Text);
            course.Subject = Convert.ToString(ctrlSurnameTextBox.Text);
            course.Hours = Convert.ToInt32(ctrlAgeNumericDropDown.Value);
            course.Category = (CoursesCategoryEnum)Enum.Parse(typeof(CoursesCategoryEnum), ctrlCategoryComboBox.Text);

            //MessageBox.Show(string.Format("Name: {0} \nSurname: {1} \nAge: {2}", name, surname, age), "The Student added successfully");
            DialogResult = DialogResult.OK;
        }

        #endregion


        #region ListViews 
        private void SetListsProperties() {

            ctrlAvailableCoursesListView.Items.Clear();
            ctrlAvailableCoursesListView.Columns.Clear();
            ctrlAvailableCoursesListView.View = View.Details;
            ctrlAvailableCoursesListView.Columns.Add("Categories", 300);

            ctrlSelectedCoursesListView.Items.Clear();
            ctrlSelectedCoursesListView.Columns.Clear();
            ctrlSelectedCoursesListView.View = View.Details;
            ctrlSelectedCoursesListView.Columns.Add("Categories", 300);
        }


        private void AddCourseToSelectedCourses() {
            if (ctrlAvailableCoursesListView.SelectedItems.Count == 0) {
                MessageBox.Show("You have to select a course to learn");
            }
            else {

                string courseCategory = ctrlAvailableCoursesListView.SelectedItems[0].Text;
                ListViewItem item = null;
                item = ctrlSelectedCoursesListView.FindItemWithText(courseCategory);

                if (item == null) {
                    ctrlSelectedCoursesListView.Items.Add(courseCategory);
                }
                else {
                    MessageBox.Show("You have already selected that course");
                }
            }
        }


        private void RemoveCourseFromSelectedCourses() {
            if (ctrlSelectedCoursesListView.Items.Count == 0) {
                MessageBox.Show("There are not courses left to remove");
            }
            else if (ctrlSelectedCoursesListView.SelectedItems.Count == 0) {
                MessageBox.Show("You have to select a course to remove");
            }
            else {
                ListViewItem item = ctrlSelectedCoursesListView.SelectedItems[0];
                ctrlSelectedCoursesListView.Items.Remove(item);

            }
        }

        #endregion


        #region Switches

        private void LoadData() {
            switch (Type) {
                case EntityTypeEnum.Student:

                    LoadStudentData();

                    break;
                case EntityTypeEnum.Professor:

                    LoadProfessorData();

                    break;
                case EntityTypeEnum.Course:

                    LoadCourseData();
                    break;
                default:
                    break;
            }
        }
  

        private void CheckValues() {
            switch (Type) {
                case EntityTypeEnum.Student:

                    CheckStudentValues();

                    break;
                case EntityTypeEnum.Professor:

                    CheckProfessorValues();

                    break;
                case EntityTypeEnum.Course:

                    CheckCourseValues();

                    break;
                default:
                    break;
            }

        }

        #endregion


    }
}
