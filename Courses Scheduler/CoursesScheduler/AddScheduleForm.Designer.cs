
namespace CoursesScheduler {
    partial class AddScheduleForm {
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
            this.components = new System.ComponentModel.Container();
            this.ctrlTitleLabel = new System.Windows.Forms.Label();
            this.ctrlCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlProfessorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlStudentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlScheduleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitleLabel
            // 
            this.ctrlTitleLabel.AutoSize = true;
            this.ctrlTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ctrlTitleLabel.Location = new System.Drawing.Point(52, 9);
            this.ctrlTitleLabel.Name = "ctrlTitleLabel";
            this.ctrlTitleLabel.Size = new System.Drawing.Size(244, 31);
            this.ctrlTitleLabel.TabIndex = 37;
            this.ctrlTitleLabel.Text = "Add New Schedule";
            // 
            // ctrlCourseComboBox
            // 
            this.ctrlCourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCourseComboBox.FormattingEnabled = true;
            this.ctrlCourseComboBox.Location = new System.Drawing.Point(58, 105);
            this.ctrlCourseComboBox.Name = "ctrlCourseComboBox";
            this.ctrlCourseComboBox.Size = new System.Drawing.Size(366, 28);
            this.ctrlCourseComboBox.TabIndex = 58;
            this.ctrlCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.ctrlCourseComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(54, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Select A Course";
            // 
            // ctrlProfessorComboBox
            // 
            this.ctrlProfessorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlProfessorComboBox.FormattingEnabled = true;
            this.ctrlProfessorComboBox.Location = new System.Drawing.Point(58, 202);
            this.ctrlProfessorComboBox.Name = "ctrlProfessorComboBox";
            this.ctrlProfessorComboBox.Size = new System.Drawing.Size(366, 28);
            this.ctrlProfessorComboBox.TabIndex = 60;
            this.ctrlProfessorComboBox.SelectedIndexChanged += new System.EventHandler(this.ctrlProfessorComboBox_SelectedIndexChanged);
            this.ctrlProfessorComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlProfessorComboBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(54, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Select a Professor who can teach that course";
            // 
            // ctrlStudentComboBox
            // 
            this.ctrlStudentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlStudentComboBox.FormattingEnabled = true;
            this.ctrlStudentComboBox.Location = new System.Drawing.Point(58, 297);
            this.ctrlStudentComboBox.Name = "ctrlStudentComboBox";
            this.ctrlStudentComboBox.Size = new System.Drawing.Size(366, 28);
            this.ctrlStudentComboBox.TabIndex = 62;
            this.ctrlStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.ctrlStudentComboBox_SelectedIndexChanged);
            this.ctrlStudentComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlStudentComboBox_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(54, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Select a Student who can learn that course";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(650, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(546, 510);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 37);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "Add";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctrlScheduleDateTimePicker
            // 
            this.ctrlScheduleDateTimePicker.CustomFormat = "ddMMMMyyyy  |  HH:mm";
            this.ctrlScheduleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlScheduleDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlScheduleDateTimePicker.Location = new System.Drawing.Point(58, 391);
            this.ctrlScheduleDateTimePicker.Name = "ctrlScheduleDateTimePicker";
            this.ctrlScheduleDateTimePicker.Size = new System.Drawing.Size(366, 26);
            this.ctrlScheduleDateTimePicker.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(54, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Select a Date";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(CoursesScheduler.Impl.Course);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlScheduleDateTimePicker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlStudentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlProfessorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCourseComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctrlTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddScheduleForm";
            this.Text = "AddScheduleForm";
            this.Load += new System.EventHandler(this.AddScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctrlTitleLabel;
        private System.Windows.Forms.ComboBox ctrlCourseComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ctrlProfessorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ctrlStudentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker ctrlScheduleDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}