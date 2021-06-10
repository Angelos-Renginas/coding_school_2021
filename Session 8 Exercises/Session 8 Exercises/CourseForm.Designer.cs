
namespace Session_8_Exercises {
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
            this.CancelCourseButton = new System.Windows.Forms.Button();
            this.OkCourseButton = new System.Windows.Forms.Button();
            this.SubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.AddCourseLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelCourseButton
            // 
            this.CancelCourseButton.BackColor = System.Drawing.Color.White;
            this.CancelCourseButton.Location = new System.Drawing.Point(662, 391);
            this.CancelCourseButton.Name = "CancelCourseButton";
            this.CancelCourseButton.Size = new System.Drawing.Size(109, 32);
            this.CancelCourseButton.TabIndex = 29;
            this.CancelCourseButton.Text = "Cancel";
            this.CancelCourseButton.UseVisualStyleBackColor = false;
            this.CancelCourseButton.Click += new System.EventHandler(this.CancelCourseButton_Click);
            // 
            // OkCourseButton
            // 
            this.OkCourseButton.BackColor = System.Drawing.Color.White;
            this.OkCourseButton.Location = new System.Drawing.Point(547, 391);
            this.OkCourseButton.Name = "OkCourseButton";
            this.OkCourseButton.Size = new System.Drawing.Size(109, 32);
            this.OkCourseButton.TabIndex = 28;
            this.OkCourseButton.Text = "OK";
            this.OkCourseButton.UseVisualStyleBackColor = false;
            this.OkCourseButton.Click += new System.EventHandler(this.OkCourseButton_Click);
            // 
            // SubjectTextEdit
            // 
            this.SubjectTextEdit.EditValue = "";
            this.SubjectTextEdit.Location = new System.Drawing.Point(370, 117);
            this.SubjectTextEdit.Name = "SubjectTextEdit";
            this.SubjectTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.SubjectTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubjectTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.SubjectTextEdit.Properties.Appearance.Options.UseFont = true;
            this.SubjectTextEdit.Size = new System.Drawing.Size(169, 22);
            this.SubjectTextEdit.TabIndex = 25;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.White;
            this.CategoryLabel.Location = new System.Drawing.Point(242, 159);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(116, 16);
            this.CategoryLabel.TabIndex = 23;
            this.CategoryLabel.Text = "Choose Category:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubjectLabel.ForeColor = System.Drawing.Color.White;
            this.SubjectLabel.Location = new System.Drawing.Point(268, 120);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(90, 16);
            this.SubjectLabel.TabIndex = 22;
            this.SubjectLabel.Text = "Enter Subject:";
            // 
            // AddCourseLabel
            // 
            this.AddCourseLabel.AutoSize = true;
            this.AddCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddCourseLabel.ForeColor = System.Drawing.Color.White;
            this.AddCourseLabel.Location = new System.Drawing.Point(279, 32);
            this.AddCourseLabel.Name = "AddCourseLabel";
            this.AddCourseLabel.Size = new System.Drawing.Size(192, 29);
            this.AddCourseLabel.TabIndex = 21;
            this.AddCourseLabel.Text = "Add a Course...";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            " Physics",
            "Mathematic",
            "Sociology",
            "Chemistry",
            "Financial",
            "CivilEngineering"});
            this.CategoryComboBox.Location = new System.Drawing.Point(370, 158);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(169, 21);
            this.CategoryComboBox.TabIndex = 31;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CancelCourseButton);
            this.Controls.Add(this.OkCourseButton);
            this.Controls.Add(this.SubjectTextEdit);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.AddCourseLabel);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelCourseButton;
        private System.Windows.Forms.Button OkCourseButton;
        private DevExpress.XtraEditors.TextEdit SubjectTextEdit;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label AddCourseLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}