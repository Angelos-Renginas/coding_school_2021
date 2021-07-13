
namespace CoursesScheduler.WUI {
    partial class SchedulerForm {
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
            this.ctrlRemoveSchedule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlScheduler = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.tabPageProfessors = new System.Windows.Forms.TabPage();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.ctrlTabbedListView = new System.Windows.Forms.ListView();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.ctrlScheduleListView = new System.Windows.Forms.ListView();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlScheduler.SuspendLayout();
            this.tabPageCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlRemoveSchedule
            // 
            this.ctrlRemoveSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlRemoveSchedule.Location = new System.Drawing.Point(185, 409);
            this.ctrlRemoveSchedule.Name = "ctrlRemoveSchedule";
            this.ctrlRemoveSchedule.Size = new System.Drawing.Size(143, 32);
            this.ctrlRemoveSchedule.TabIndex = 9;
            this.ctrlRemoveSchedule.Text = "Remove from Schedule";
            this.ctrlRemoveSchedule.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(22, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToScheduleToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // addToScheduleToolStripMenuItem
            // 
            this.addToScheduleToolStripMenuItem.Name = "addToScheduleToolStripMenuItem";
            this.addToScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToScheduleToolStripMenuItem.Text = "Add To Schedule...";
            this.addToScheduleToolStripMenuItem.Click += new System.EventHandler(this.addToScheduleToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.addProfessorToolStripMenuItem,
            this.addCourseToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // addProfessorToolStripMenuItem
            // 
            this.addProfessorToolStripMenuItem.Name = "addProfessorToolStripMenuItem";
            this.addProfessorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addProfessorToolStripMenuItem.Text = "Add Professor";
            this.addProfessorToolStripMenuItem.Click += new System.EventHandler(this.addProfessorToolStripMenuItem_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // tabControlScheduler
            // 
            this.tabControlScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlScheduler.Controls.Add(this.tabPageStudents);
            this.tabControlScheduler.Controls.Add(this.tabPageProfessors);
            this.tabControlScheduler.Controls.Add(this.tabPageCourses);
            this.tabControlScheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControlScheduler.Location = new System.Drawing.Point(28, 79);
            this.tabControlScheduler.Name = "tabControlScheduler";
            this.tabControlScheduler.SelectedIndex = 0;
            this.tabControlScheduler.Size = new System.Drawing.Size(763, 287);
            this.tabControlScheduler.TabIndex = 16;
            this.tabControlScheduler.SelectedIndexChanged += new System.EventHandler(this.tabControlScheduler_SelectedIndexChanged);
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabPageStudents.Location = new System.Drawing.Point(4, 29);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(755, 254);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // tabPageProfessors
            // 
            this.tabPageProfessors.Location = new System.Drawing.Point(4, 29);
            this.tabPageProfessors.Name = "tabPageProfessors";
            this.tabPageProfessors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfessors.Size = new System.Drawing.Size(755, 254);
            this.tabPageProfessors.TabIndex = 1;
            this.tabPageProfessors.Text = "Professors";
            this.tabPageProfessors.UseVisualStyleBackColor = true;
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Controls.Add(this.ctrlTabbedListView);
            this.tabPageCourses.Location = new System.Drawing.Point(4, 29);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Size = new System.Drawing.Size(755, 254);
            this.tabPageCourses.TabIndex = 2;
            this.tabPageCourses.Text = "Courses";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // ctrlTabbedListView
            // 
            this.ctrlTabbedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTabbedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctrlTabbedListView.FullRowSelect = true;
            this.ctrlTabbedListView.HideSelection = false;
            this.ctrlTabbedListView.Location = new System.Drawing.Point(3, -3);
            this.ctrlTabbedListView.MultiSelect = false;
            this.ctrlTabbedListView.Name = "ctrlTabbedListView";
            this.ctrlTabbedListView.Size = new System.Drawing.Size(749, 260);
            this.ctrlTabbedListView.TabIndex = 0;
            this.ctrlTabbedListView.UseCompatibleStateImageBehavior = false;
            this.ctrlTabbedListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctrlSchedulerListVIew_MouseDoubleClick);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSchedule.Location = new System.Drawing.Point(28, 409);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(143, 32);
            this.btnAddSchedule.TabIndex = 17;
            this.btnAddSchedule.Text = "Add to Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // ctrlScheduleListView
            // 
            this.ctrlScheduleListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlScheduleListView.HideSelection = false;
            this.ctrlScheduleListView.Location = new System.Drawing.Point(32, 459);
            this.ctrlScheduleListView.Name = "ctrlScheduleListView";
            this.ctrlScheduleListView.Size = new System.Drawing.Size(759, 274);
            this.ctrlScheduleListView.TabIndex = 18;
            this.ctrlScheduleListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(662, 73);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(122, 29);
            this.btnDeleteRecord.TabIndex = 19;
            this.btnDeleteRecord.Text = "Delete";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // SchedulerForm
            // 
            this.ClientSize = new System.Drawing.Size(811, 792);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.ctrlScheduleListView);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.tabControlScheduler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctrlRemoveSchedule);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SchedulerForm";
            this.Text = "Univerity Courses Scheduler";
            this.Load += new System.EventHandler(this.SchedulerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlScheduler.ResumeLayout(false);
            this.tabPageCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        
        private System.Windows.Forms.Button button6;
 
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
  
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ctrlRemoveSchedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlScheduler;
        private System.Windows.Forms.TabPage tabPageProfessors;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.ListView ctrlTabbedListView;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ListView ctrlScheduleListView;
        private System.Windows.Forms.Button btnDeleteRecord;
    }
}