
using System.Drawing;
using System.Windows.Forms;

namespace Session_8_Exercises {
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.EpsilonNetLabel = new System.Windows.Forms.Label();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.AddProfessorButton = new System.Windows.Forms.Button();
            this.Exercises8Label = new System.Windows.Forms.Label();
            this.CourseListView = new System.Windows.Forms.ListView();
            this.StudentListView = new System.Windows.Forms.ListView();
            this.ProfessorListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(670, 443);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 38);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EpsilonNetLabel
            // 
            this.EpsilonNetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EpsilonNetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EpsilonNetLabel.ForeColor = System.Drawing.Color.White;
            this.EpsilonNetLabel.Location = new System.Drawing.Point(190, 31);
            this.EpsilonNetLabel.Name = "EpsilonNetLabel";
            this.EpsilonNetLabel.Size = new System.Drawing.Size(471, 39);
            this.EpsilonNetLabel.TabIndex = 6;
            this.EpsilonNetLabel.Text = "EpsilonNet Coding School";
            this.EpsilonNetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCourseButton.BackColor = System.Drawing.Color.White;
            this.AddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddCourseButton.Location = new System.Drawing.Point(172, 150);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(139, 83);
            this.AddCourseButton.TabIndex = 7;
            this.AddCourseButton.Text = "Add\r\nCourse";
            this.AddCourseButton.UseVisualStyleBackColor = false;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStudentButton.BackColor = System.Drawing.Color.White;
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddStudentButton.Location = new System.Drawing.Point(356, 150);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(139, 83);
            this.AddStudentButton.TabIndex = 8;
            this.AddStudentButton.Text = "Add\r\nStudent";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // AddProfessorButton
            // 
            this.AddProfessorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProfessorButton.BackColor = System.Drawing.Color.White;
            this.AddProfessorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddProfessorButton.Location = new System.Drawing.Point(547, 150);
            this.AddProfessorButton.Name = "AddProfessorButton";
            this.AddProfessorButton.Size = new System.Drawing.Size(139, 83);
            this.AddProfessorButton.TabIndex = 9;
            this.AddProfessorButton.Text = "Add\r\nProfessor\r\n";
            this.AddProfessorButton.UseVisualStyleBackColor = false;
            this.AddProfessorButton.Click += new System.EventHandler(this.AddProfessorButton_Click);
            // 
            // Exercises8Label
            // 
            this.Exercises8Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exercises8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Exercises8Label.ForeColor = System.Drawing.Color.White;
            this.Exercises8Label.Location = new System.Drawing.Point(259, 90);
            this.Exercises8Label.Name = "Exercises8Label";
            this.Exercises8Label.Size = new System.Drawing.Size(330, 37);
            this.Exercises8Label.TabIndex = 10;
            this.Exercises8Label.Text = "Session 8 Exercises";
            this.Exercises8Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseListView
            // 
            this.CourseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CourseListView.HideSelection = false;
            this.CourseListView.Location = new System.Drawing.Point(172, 274);
            this.CourseListView.Name = "CourseListView";
            this.CourseListView.Size = new System.Drawing.Size(138, 151);
            this.CourseListView.TabIndex = 11;
            this.CourseListView.UseCompatibleStateImageBehavior = false;
            this.CourseListView.View = System.Windows.Forms.View.List;
            // 
            // StudentListView
            // 
            this.StudentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StudentListView.HideSelection = false;
            this.StudentListView.Location = new System.Drawing.Point(356, 274);
            this.StudentListView.Name = "StudentListView";
            this.StudentListView.Size = new System.Drawing.Size(139, 151);
            this.StudentListView.TabIndex = 12;
            this.StudentListView.UseCompatibleStateImageBehavior = false;
            this.StudentListView.View = System.Windows.Forms.View.List;
            this.StudentListView.SelectedIndexChanged += new System.EventHandler(this.StudentListView_SelectedIndexChanged);
            // 
            // ProfessorListView
            // 
            this.ProfessorListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProfessorListView.HideSelection = false;
            this.ProfessorListView.Location = new System.Drawing.Point(547, 274);
            this.ProfessorListView.Name = "ProfessorListView";
            this.ProfessorListView.Size = new System.Drawing.Size(139, 151);
            this.ProfessorListView.TabIndex = 13;
            this.ProfessorListView.UseCompatibleStateImageBehavior = false;
            this.ProfessorListView.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(856, 504);
            this.Controls.Add(this.ProfessorListView);
            this.Controls.Add(this.StudentListView);
            this.Controls.Add(this.CourseListView);
            this.Controls.Add(this.Exercises8Label);
            this.Controls.Add(this.AddProfessorButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.EpsilonNetLabel);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label EpsilonNetLabel;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button AddProfessorButton;
        private System.Windows.Forms.Label Exercises8Label;
        private System.Windows.Forms.ListView CourseListView;
        private System.Windows.Forms.ListView StudentListView;
        private System.Windows.Forms.ListView ProfessorListView;
    }
}

