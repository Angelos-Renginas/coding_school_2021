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
    public partial class ProfessorForm : Form {

        public Professor MyProfessor { get; set; }
        public MainForm MyMainForm { get; set; }

        public ProfessorForm() {
            InitializeComponent();
        }

        public ProfessorForm(MainForm mainForm, Professor professor) {
            InitializeComponent();
            MyMainForm = mainForm;
            MyProfessor = professor;
        }

        private void OkProfessorButton_Click(object sender, EventArgs e) {
            // todo: MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!
            MyProfessor.Name = this.NameTextEdit.Text;
            MyProfessor.Age = Convert.ToInt32(this.AgeTextEdit.Text);
            MyProfessor.Rank = this.RankTextEdit.Text;

            this.MyMainForm.PassValue(MyProfessor);
            this.Close();
        }

        private void CancelProfessorButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }
    }
}
