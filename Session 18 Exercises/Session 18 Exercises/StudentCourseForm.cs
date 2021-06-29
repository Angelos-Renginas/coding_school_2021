using Microsoft.EntityFrameworkCore;
using Session_18_Exercises.Entity_Framework.Context;
using Session_18_Exercises.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Session_18_Exercises.Model.enums;

namespace Session_18_Exercises {
    public partial class StudentCourseForm : Form {

        public ObjectCategoryEnum Type { get; set; }

        private StudentContext _studentContext;
        public StudentCourseForm() {
            InitializeComponent();
        }

        private void StudentCourseForm_Load(object sender, EventArgs e) {


            switch (Type) {
                case ObjectCategoryEnum.Student:


                    bindingSource1.DataSource = typeof(Student);

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Surname", HeaderText = "Surname" });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Birthdate", HeaderText = "Birth Date" });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Address", HeaderText = "Address" });
                    dataGridView1.DataSource = bindingSource1;

                    break;
                case ObjectCategoryEnum.Course:

                    label1.Text = "Title";
                    label2.Text = "Category";
                    label3.Text = "Date";
                    label4.Text = "Duration";


                    bindingSource1.DataSource = typeof(Course);

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Category" });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date", HeaderText = "Date" });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Duration", HeaderText = "Duration" });
                    dataGridView1.DataSource = bindingSource1;

                    break;
                default:
                    break;
            }
            
            SqlConnect();
        }


        private void SqlConnect() {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QGED0UI;Initial Catalog=Session18;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _studentContext = new StudentContext(optionsBuilder.Options);
            Refresh();
        }


        private void Refresh() {
            
            bindingSource1.Clear();

            _studentContext.ChangeTracker.Clear();

            switch (Type) {
                case ObjectCategoryEnum.Student:

                    foreach (var student in _studentContext.Students.ToList()) {
                        bindingSource1.Add(student);
                    }

                    break;
                case ObjectCategoryEnum.Course:

                    foreach (var course in _studentContext.Courses.ToList()) {
                        bindingSource1.Add(course);
                    }

                    break;
                default:
                    break;
            }

            
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            switch (Type) {
                case ObjectCategoryEnum.Student:

                    var student = new Student();
                    student.Name = ctrlName.Text;
                    student.Surname = ctrlSurname.Text;
                    student.BirthDate = (DateTime)ctrldateTimePicker.Value;
                    student.Address = ctrlAddress.Text;

                    bindingSource1.Insert(0, student);
                    _studentContext.Students.Add(student);

                    break;
                case ObjectCategoryEnum.Course:


                    var course = new Course();
                    course.Title = ctrlName.Text;
                    course.Category = ctrlSurname.Text;
                    course.Date = (DateTime)ctrldateTimePicker.Value;
                    course.Duration = Convert.ToInt32(ctrlAddress.Text);

                    bindingSource1.Insert(0, course);
                    _studentContext.Courses.Add(course);

                    break;
                default:
                    break;
            }

           
        }

        private void btnDelete_Click(object sender, EventArgs e) {


            switch (Type) {
                case ObjectCategoryEnum.Student:

                    var student = bindingSource1.Current as Student;
                    if (student is null)
                        return;

                    bindingSource1.RemoveCurrent();
                    _studentContext.Students.Remove(student);

                    break;

                case ObjectCategoryEnum.Course:

                    var course = bindingSource1.Current as Course;
                    if (course is null)
                        return;

                    bindingSource1.RemoveCurrent();
                    _studentContext.Courses.Remove(course);

                    break;
                default:
                    break;
            }

            
        }

        private  void btnSave_Click(object sender, EventArgs e) {
             _studentContext.SaveChangesAsync();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Refresh();
        }
    }
}
