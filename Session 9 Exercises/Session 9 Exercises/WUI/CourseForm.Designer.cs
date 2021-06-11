
namespace Session_9_Exercises {
    partial class CourseForm {
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
            this.ctrlCancelCourse = new System.Windows.Forms.Button();
            this.ctrlOkCourse = new System.Windows.Forms.Button();
            this.ctrlSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCategoryLabel = new System.Windows.Forms.Label();
            this.ctrlSubjectLabel = new System.Windows.Forms.Label();
            this.ctrlCourseLabel = new System.Windows.Forms.Label();
            this.ctrlCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ctrlHours = new System.Windows.Forms.Label();
            this.ctrlHoursNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHoursNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCancelCourse
            // 
            this.ctrlCancelCourse.BackColor = System.Drawing.Color.White;
            this.ctrlCancelCourse.Location = new System.Drawing.Point(662, 391);
            this.ctrlCancelCourse.Name = "ctrlCancelCourse";
            this.ctrlCancelCourse.Size = new System.Drawing.Size(109, 32);
            this.ctrlCancelCourse.TabIndex = 29;
            this.ctrlCancelCourse.Text = "Cancel";
            this.ctrlCancelCourse.UseVisualStyleBackColor = false;
            this.ctrlCancelCourse.Click += new System.EventHandler(this.CancelCourseButton_Click);
            // 
            // ctrlOkCourse
            // 
            this.ctrlOkCourse.BackColor = System.Drawing.Color.White;
            this.ctrlOkCourse.Location = new System.Drawing.Point(547, 391);
            this.ctrlOkCourse.Name = "ctrlOkCourse";
            this.ctrlOkCourse.Size = new System.Drawing.Size(109, 32);
            this.ctrlOkCourse.TabIndex = 28;
            this.ctrlOkCourse.Text = "OK";
            this.ctrlOkCourse.UseVisualStyleBackColor = false;
            this.ctrlOkCourse.Click += new System.EventHandler(this.OkCourseButton_Click);
            // 
            // ctrlSubjectTextEdit
            // 
            this.ctrlSubjectTextEdit.EditValue = "";
            this.ctrlSubjectTextEdit.Location = new System.Drawing.Point(370, 117);
            this.ctrlSubjectTextEdit.Name = "ctrlSubjectTextEdit";
            this.ctrlSubjectTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ctrlSubjectTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSubjectTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlSubjectTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlSubjectTextEdit.Size = new System.Drawing.Size(169, 22);
            this.ctrlSubjectTextEdit.TabIndex = 25;
            // 
            // ctrlCategoryLabel
            // 
            this.ctrlCategoryLabel.AutoSize = true;
            this.ctrlCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCategoryLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlCategoryLabel.Location = new System.Drawing.Point(242, 159);
            this.ctrlCategoryLabel.Name = "ctrlCategoryLabel";
            this.ctrlCategoryLabel.Size = new System.Drawing.Size(116, 16);
            this.ctrlCategoryLabel.TabIndex = 23;
            this.ctrlCategoryLabel.Text = "Choose Category:";
            // 
            // ctrlSubjectLabel
            // 
            this.ctrlSubjectLabel.AutoSize = true;
            this.ctrlSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSubjectLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlSubjectLabel.Location = new System.Drawing.Point(268, 120);
            this.ctrlSubjectLabel.Name = "ctrlSubjectLabel";
            this.ctrlSubjectLabel.Size = new System.Drawing.Size(90, 16);
            this.ctrlSubjectLabel.TabIndex = 22;
            this.ctrlSubjectLabel.Text = "Enter Subject:";
            // 
            // ctrlCourseLabel
            // 
            this.ctrlCourseLabel.AutoSize = true;
            this.ctrlCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCourseLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlCourseLabel.Location = new System.Drawing.Point(279, 32);
            this.ctrlCourseLabel.Name = "ctrlCourseLabel";
            this.ctrlCourseLabel.Size = new System.Drawing.Size(192, 29);
            this.ctrlCourseLabel.TabIndex = 21;
            this.ctrlCourseLabel.Text = "Add a Course...";
            // 
            // ctrlCategoryComboBox
            // 
            this.ctrlCategoryComboBox.FormattingEnabled = true;
            this.ctrlCategoryComboBox.Items.AddRange(new object[] {
            "Physics",
            "Mathematic",
            "Sociology",
            "Chemistry",
            "Financial",
            "CivilEngineering"});
            this.ctrlCategoryComboBox.Location = new System.Drawing.Point(370, 158);
            this.ctrlCategoryComboBox.Name = "ctrlCategoryComboBox";
            this.ctrlCategoryComboBox.Size = new System.Drawing.Size(169, 21);
            this.ctrlCategoryComboBox.TabIndex = 31;
            // 
            // ctrlHours
            // 
            this.ctrlHours.AutoSize = true;
            this.ctrlHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlHours.ForeColor = System.Drawing.Color.White;
            this.ctrlHours.Location = new System.Drawing.Point(261, 200);
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(97, 16);
            this.ctrlHours.TabIndex = 32;
            this.ctrlHours.Text = "Choose Hours:";
            // 
            // ctrlHoursNumeric
            // 
            this.ctrlHoursNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlHoursNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ctrlHoursNumeric.Location = new System.Drawing.Point(370, 198);
            this.ctrlHoursNumeric.Name = "ctrlHoursNumeric";
            this.ctrlHoursNumeric.Size = new System.Drawing.Size(169, 22);
            this.ctrlHoursNumeric.TabIndex = 33;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlHoursNumeric);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.ctrlCategoryComboBox);
            this.Controls.Add(this.ctrlCancelCourse);
            this.Controls.Add(this.ctrlOkCourse);
            this.Controls.Add(this.ctrlSubjectTextEdit);
            this.Controls.Add(this.ctrlCategoryLabel);
            this.Controls.Add(this.ctrlSubjectLabel);
            this.Controls.Add(this.ctrlCourseLabel);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHoursNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlCancelCourse;
        private System.Windows.Forms.Button ctrlOkCourse;
        private DevExpress.XtraEditors.TextEdit ctrlSubjectTextEdit;
        private System.Windows.Forms.Label ctrlCategoryLabel;
        private System.Windows.Forms.Label ctrlSubjectLabel;
        private System.Windows.Forms.Label ctrlCourseLabel;
        private System.Windows.Forms.ComboBox ctrlCategoryComboBox;
        private System.Windows.Forms.Label ctrlHours;
        private System.Windows.Forms.NumericUpDown ctrlHoursNumeric;
    }
}