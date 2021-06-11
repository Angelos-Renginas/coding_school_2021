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
    public partial class ProfessorForm : Form {

        public Professor MyProfessor { get; set; }
        public MainForm MyMainForm { get; set; }

        public ProfessorForm() {
            InitializeComponent();
        }


        private void OkProfessorButton_Click(object sender, EventArgs e) {
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
            else {

                MyProfessor.Name = Convert.ToString(ctrlNameTextEdit.EditValue);
                MyProfessor.Surname = Convert.ToString(ctrlLastNameTextEdit.EditValue);
                MyProfessor.Age = Convert.ToInt32(ctrlAgeTextEdit.EditValue);
                MyProfessor.Rank = Convert.ToString(ctrlRankTextEdit.EditValue);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelProfessorButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }
    }
}
