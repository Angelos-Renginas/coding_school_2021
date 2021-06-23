
using System.Drawing;
using System.Windows.Forms;

namespace Session_11_Exercises {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlExit = new System.Windows.Forms.Button();
            this.ctrlEpsilonLabel = new System.Windows.Forms.Label();
            this.ctrlAddCourse = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.ctrlAddProfessor = new System.Windows.Forms.Button();
            this.ctrlExerciseLabel = new System.Windows.Forms.Label();
            this.ctrlCourseList = new System.Windows.Forms.ListView();
            this.ctrlStudentList = new System.Windows.Forms.ListView();
            this.ctrlProfessorList = new System.Windows.Forms.ListView();
            this.ctrlDeserialize = new System.Windows.Forms.Button();
            this.ctrlSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlExit
            // 
            this.ctrlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlExit.BackColor = System.Drawing.Color.White;
            this.ctrlExit.ForeColor = System.Drawing.Color.Black;
            this.ctrlExit.Location = new System.Drawing.Point(670, 443);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(156, 38);
            this.ctrlExit.TabIndex = 2;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = false;
            this.ctrlExit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ctrlEpsilonLabel
            // 
            this.ctrlEpsilonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlEpsilonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEpsilonLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlEpsilonLabel.Location = new System.Drawing.Point(190, 31);
            this.ctrlEpsilonLabel.Name = "ctrlEpsilonLabel";
            this.ctrlEpsilonLabel.Size = new System.Drawing.Size(471, 39);
            this.ctrlEpsilonLabel.TabIndex = 6;
            this.ctrlEpsilonLabel.Text = "EpsilonNet Coding School";
            this.ctrlEpsilonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlAddCourse
            // 
            this.ctrlAddCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlAddCourse.BackColor = System.Drawing.Color.White;
            this.ctrlAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddCourse.Location = new System.Drawing.Point(172, 150);
            this.ctrlAddCourse.Name = "ctrlAddCourse";
            this.ctrlAddCourse.Size = new System.Drawing.Size(139, 69);
            this.ctrlAddCourse.TabIndex = 7;
            this.ctrlAddCourse.Text = "Add\r\nCourse";
            this.ctrlAddCourse.UseVisualStyleBackColor = false;
            this.ctrlAddCourse.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlAddStudent.BackColor = System.Drawing.Color.White;
            this.ctrlAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddStudent.Location = new System.Drawing.Point(356, 150);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(139, 69);
            this.ctrlAddStudent.TabIndex = 8;
            this.ctrlAddStudent.Text = "Add\r\nStudent";
            this.ctrlAddStudent.UseVisualStyleBackColor = false;
            this.ctrlAddStudent.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // ctrlAddProfessor
            // 
            this.ctrlAddProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlAddProfessor.BackColor = System.Drawing.Color.White;
            this.ctrlAddProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddProfessor.Location = new System.Drawing.Point(547, 150);
            this.ctrlAddProfessor.Name = "ctrlAddProfessor";
            this.ctrlAddProfessor.Size = new System.Drawing.Size(139, 69);
            this.ctrlAddProfessor.TabIndex = 9;
            this.ctrlAddProfessor.Text = "Add\r\nProfessor\r\n";
            this.ctrlAddProfessor.UseVisualStyleBackColor = false;
            this.ctrlAddProfessor.Click += new System.EventHandler(this.AddProfessorButton_Click);
            // 
            // ctrlExerciseLabel
            // 
            this.ctrlExerciseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlExerciseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlExerciseLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlExerciseLabel.Location = new System.Drawing.Point(259, 90);
            this.ctrlExerciseLabel.Name = "ctrlExerciseLabel";
            this.ctrlExerciseLabel.Size = new System.Drawing.Size(330, 37);
            this.ctrlExerciseLabel.TabIndex = 10;
            this.ctrlExerciseLabel.Text = "Session 9 Exercises";
            this.ctrlExerciseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlCourseList
            // 
            this.ctrlCourseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCourseList.HideSelection = false;
            this.ctrlCourseList.Location = new System.Drawing.Point(172, 254);
            this.ctrlCourseList.Name = "ctrlCourseList";
            this.ctrlCourseList.Size = new System.Drawing.Size(138, 151);
            this.ctrlCourseList.TabIndex = 11;
            this.ctrlCourseList.UseCompatibleStateImageBehavior = false;
            this.ctrlCourseList.View = System.Windows.Forms.View.List;
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlStudentList.HideSelection = false;
            this.ctrlStudentList.Location = new System.Drawing.Point(356, 254);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(139, 151);
            this.ctrlStudentList.TabIndex = 12;
            this.ctrlStudentList.UseCompatibleStateImageBehavior = false;
            this.ctrlStudentList.View = System.Windows.Forms.View.List;
            // 
            // ctrlProfessorList
            // 
            this.ctrlProfessorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlProfessorList.HideSelection = false;
            this.ctrlProfessorList.Location = new System.Drawing.Point(547, 254);
            this.ctrlProfessorList.Name = "ctrlProfessorList";
            this.ctrlProfessorList.Size = new System.Drawing.Size(139, 151);
            this.ctrlProfessorList.TabIndex = 13;
            this.ctrlProfessorList.UseCompatibleStateImageBehavior = false;
            this.ctrlProfessorList.View = System.Windows.Forms.View.List;
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlDeserialize.BackColor = System.Drawing.Color.White;
            this.ctrlDeserialize.ForeColor = System.Drawing.Color.Black;
            this.ctrlDeserialize.Location = new System.Drawing.Point(505, 443);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(156, 38);
            this.ctrlDeserialize.TabIndex = 14;
            this.ctrlDeserialize.Text = "Deserialize";
            this.ctrlDeserialize.UseVisualStyleBackColor = false;
            this.ctrlDeserialize.Click += new System.EventHandler(this.ctrlDeserialize_Click);
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlSerialize.BackColor = System.Drawing.Color.White;
            this.ctrlSerialize.ForeColor = System.Drawing.Color.Black;
            this.ctrlSerialize.Location = new System.Drawing.Point(339, 443);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(156, 38);
            this.ctrlSerialize.TabIndex = 15;
            this.ctrlSerialize.Text = "Serialize";
            this.ctrlSerialize.UseVisualStyleBackColor = false;
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(856, 504);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlProfessorList);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.ctrlCourseList);
            this.Controls.Add(this.ctrlExerciseLabel);
            this.Controls.Add(this.ctrlAddProfessor);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.ctrlAddCourse);
            this.Controls.Add(this.ctrlEpsilonLabel);
            this.Controls.Add(this.ctrlExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.Label ctrlEpsilonLabel;
        private System.Windows.Forms.Button ctrlAddCourse;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button ctrlAddProfessor;
        private System.Windows.Forms.Label ctrlExerciseLabel;
        private System.Windows.Forms.ListView ctrlCourseList;
        private System.Windows.Forms.ListView ctrlStudentList;
        private System.Windows.Forms.ListView ctrlProfessorList;
        private Button ctrlDeserialize;
        private Button ctrlSerialize;
    }
}

