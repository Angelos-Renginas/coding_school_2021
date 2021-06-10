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

    public partial class StudentForm : Form {

        // PROPERTIES ????
        public Student MyStudent { get; set; }
        public MainForm MyMainForm { get; set; }

        // CONSTRUCTOR
        public StudentForm() {
            InitializeComponent();
        }


        public StudentForm(MainForm mainForm, Student student) {
            InitializeComponent();
            MyMainForm = mainForm;
            MyStudent = student;
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {

        }

        private void OkStudentButton_Click(object sender, EventArgs e) {

            // todo: MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!
            MyStudent.Name = this.NameTextEdit.Text;
            MyStudent.Age = Convert.ToInt32(this.AgeTextEdit.Text);
            MyStudent.RegistrationNumber = Convert.ToInt32(this.RegistrationTextEdit.Text);
            
            this.MyMainForm.PassValue(MyStudent);
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e) {

            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!
            this.DialogResult = DialogResult.OK;
        }

      
    }
}
