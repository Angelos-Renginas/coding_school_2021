
namespace CoursesScheduler {
    partial class EditForm {
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
            this.ctrlRankTextBox = new System.Windows.Forms.TextBox();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.ctrlSelectedCoursesListView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlAvailableCoursesListView = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTitleLabel = new System.Windows.Forms.Label();
            this.ctrlRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlAgeNumericDropDown = new System.Windows.Forms.NumericUpDown();
            this.ctrlCategoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAgeNumericDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlRankTextBox
            // 
            this.ctrlRankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlRankTextBox.Location = new System.Drawing.Point(47, 193);
            this.ctrlRankTextBox.Name = "ctrlRankTextBox";
            this.ctrlRankTextBox.Size = new System.Drawing.Size(99, 26);
            this.ctrlRankTextBox.TabIndex = 50;
            this.ctrlRankTextBox.Visible = false;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(285, 380);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(107, 31);
            this.btnRemoveCourse.TabIndex = 49;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(285, 321);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(107, 31);
            this.btnAddCourse.TabIndex = 48;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // ctrlSelectedCoursesListView
            // 
            this.ctrlSelectedCoursesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSelectedCoursesListView.FullRowSelect = true;
            this.ctrlSelectedCoursesListView.HideSelection = false;
            this.ctrlSelectedCoursesListView.Location = new System.Drawing.Point(409, 286);
            this.ctrlSelectedCoursesListView.Name = "ctrlSelectedCoursesListView";
            this.ctrlSelectedCoursesListView.Size = new System.Drawing.Size(223, 168);
            this.ctrlSelectedCoursesListView.TabIndex = 47;
            this.ctrlSelectedCoursesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(409, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Selected Courses Categories";
            // 
            // ctrlAvailableCoursesListView
            // 
            this.ctrlAvailableCoursesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAvailableCoursesListView.FullRowSelect = true;
            this.ctrlAvailableCoursesListView.HideSelection = false;
            this.ctrlAvailableCoursesListView.Location = new System.Drawing.Point(43, 286);
            this.ctrlAvailableCoursesListView.Name = "ctrlAvailableCoursesListView";
            this.ctrlAvailableCoursesListView.Size = new System.Drawing.Size(227, 168);
            this.ctrlAvailableCoursesListView.TabIndex = 45;
            this.ctrlAvailableCoursesListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(625, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(521, 496);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 37);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "Add";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(43, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Available Courses Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(42, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Rank";
            // 
            // ctrlSurnameTextBox
            // 
            this.ctrlSurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSurnameTextBox.Location = new System.Drawing.Point(409, 115);
            this.ctrlSurnameTextBox.Name = "ctrlSurnameTextBox";
            this.ctrlSurnameTextBox.Size = new System.Drawing.Size(223, 26);
            this.ctrlSurnameTextBox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(406, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Surname";
            // 
            // ctrlNameTextBox
            // 
            this.ctrlNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlNameTextBox.Location = new System.Drawing.Point(47, 115);
            this.ctrlNameTextBox.Name = "ctrlNameTextBox";
            this.ctrlNameTextBox.Size = new System.Drawing.Size(223, 26);
            this.ctrlNameTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(43, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
            // 
            // ctrlTitleLabel
            // 
            this.ctrlTitleLabel.AutoSize = true;
            this.ctrlTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ctrlTitleLabel.Location = new System.Drawing.Point(37, 25);
            this.ctrlTitleLabel.Name = "ctrlTitleLabel";
            this.ctrlTitleLabel.Size = new System.Drawing.Size(248, 31);
            this.ctrlTitleLabel.TabIndex = 36;
            this.ctrlTitleLabel.Text = "Add New Professor";
            // 
            // ctrlRegistrationNumberTextBox
            // 
            this.ctrlRegistrationNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlRegistrationNumberTextBox.Location = new System.Drawing.Point(408, 196);
            this.ctrlRegistrationNumberTextBox.Name = "ctrlRegistrationNumberTextBox";
            this.ctrlRegistrationNumberTextBox.Size = new System.Drawing.Size(222, 26);
            this.ctrlRegistrationNumberTextBox.TabIndex = 52;
            this.ctrlRegistrationNumberTextBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(405, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Registration Number";
            this.label5.Visible = false;
            // 
            // ctrlAgeNumericDropDown
            // 
            this.ctrlAgeNumericDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAgeNumericDropDown.Location = new System.Drawing.Point(47, 193);
            this.ctrlAgeNumericDropDown.Name = "ctrlAgeNumericDropDown";
            this.ctrlAgeNumericDropDown.Size = new System.Drawing.Size(99, 26);
            this.ctrlAgeNumericDropDown.TabIndex = 53;
            this.ctrlAgeNumericDropDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // ctrlCategoryComboBox
            // 
            this.ctrlCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCategoryComboBox.FormattingEnabled = true;
            this.ctrlCategoryComboBox.Location = new System.Drawing.Point(409, 196);
            this.ctrlCategoryComboBox.Name = "ctrlCategoryComboBox";
            this.ctrlCategoryComboBox.Size = new System.Drawing.Size(221, 28);
            this.ctrlCategoryComboBox.TabIndex = 55;
            this.ctrlCategoryComboBox.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 559);
            this.Controls.Add(this.ctrlCategoryComboBox);
            this.Controls.Add(this.ctrlAgeNumericDropDown);
            this.Controls.Add(this.ctrlRegistrationNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctrlRankTextBox);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.ctrlSelectedCoursesListView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctrlAvailableCoursesListView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlSurnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAgeNumericDropDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlRankTextBox;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ListView ctrlSelectedCoursesListView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView ctrlAvailableCoursesListView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctrlSurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ctrlTitleLabel;
        private System.Windows.Forms.TextBox ctrlRegistrationNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ctrlAgeNumericDropDown;
        private System.Windows.Forms.ComboBox ctrlCategoryComboBox;
    }
}