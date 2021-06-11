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

    public partial class StudentForm : Form {

        public Student MyStudent { get; set; }

        public StudentForm() {
            InitializeComponent();
        }


        private void OkStudentButton_Click(object sender, EventArgs e) {
             
            CheckValues();
        }

        private void CheckValues() {
            int j = -1;

            if (ctrlNameTextEdit.EditValue.ToString().Length == 0 || ctrlLastNameTextEdit.EditValue.ToString().Length == 0) {
                MessageBox.Show("Please insert Name!");
            }
            else if (!int.TryParse(ctrlAgeTextEdit.EditValue.ToString(), out j)) {
                MessageBox.Show("Age must be a Number!");
            }
            else if (!int.TryParse(ctrlRegistrationTextEdit.EditValue.ToString(), out j)) {
                MessageBox.Show("Registration Number must be a Number");
            }
            else {

                MyStudent.Name = Convert.ToString(ctrlNameTextEdit.EditValue);
                MyStudent.Surname = Convert.ToString(ctrlLastNameTextEdit.EditValue);
                MyStudent.Age = Convert.ToInt32(ctrlAgeTextEdit.EditValue);
                MyStudent.RegistrationNumber = Convert.ToInt32(ctrlRegistrationTextEdit.EditValue);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {

            this.DialogResult = DialogResult.OK;
            Close();
        }

      
    }
}
