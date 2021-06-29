
namespace Session_18_Exercises {
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
            this.ctrlStudents = new System.Windows.Forms.Button();
            this.ctrlCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlStudents
            // 
            this.ctrlStudents.Location = new System.Drawing.Point(150, 131);
            this.ctrlStudents.Name = "ctrlStudents";
            this.ctrlStudents.Size = new System.Drawing.Size(177, 113);
            this.ctrlStudents.TabIndex = 0;
            this.ctrlStudents.Text = "Students";
            this.ctrlStudents.UseVisualStyleBackColor = true;
            this.ctrlStudents.Click += new System.EventHandler(this.ctrlStudents_Click);
            // 
            // ctrlCourses
            // 
            this.ctrlCourses.Location = new System.Drawing.Point(433, 131);
            this.ctrlCourses.Name = "ctrlCourses";
            this.ctrlCourses.Size = new System.Drawing.Size(177, 113);
            this.ctrlCourses.TabIndex = 1;
            this.ctrlCourses.Text = "Courses";
            this.ctrlCourses.UseVisualStyleBackColor = true;
            this.ctrlCourses.Click += new System.EventHandler(this.ctrlCourses_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCourses);
            this.Controls.Add(this.ctrlStudents);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctrlStudents;
        private System.Windows.Forms.Button ctrlCourses;
    }
}