
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Session_11_Exercises.WUI {
    partial class MdiMainForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.universityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.professorsToolStripMenuItem,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // universityToolStripMenuItem
            // 
            this.universityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.universityToolStripMenuItem.Name = "universityToolStripMenuItem";
            this.universityToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.universityToolStripMenuItem.Text = "University";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MdiMainForm_Save);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripMenuItem2,
            this.viewStudentsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.viewStudentsToolStripMenuItem.Text = "View";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.viewToolStripMenuItem1});
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.professorsToolStripMenuItem.Text = "Professors";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addProfessorToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(96, 6);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewProfessorsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.toolStripMenuItem5,
            this.viewToolStripMenuItem2});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem4.Text = "Courses";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem2.Text = "Add...";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addCourseToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(102, 6);
            // 
            // viewToolStripMenuItem2
            // 
            this.viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            this.viewToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.viewToolStripMenuItem2.Text = "View";
            this.viewToolStripMenuItem2.Click += new System.EventHandler(this.viewCoursesToolStripMenuItem_Click);
            // 
            // MdiMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1344, 747);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem universityToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem professorsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem viewToolStripMenuItem2;
    }
}