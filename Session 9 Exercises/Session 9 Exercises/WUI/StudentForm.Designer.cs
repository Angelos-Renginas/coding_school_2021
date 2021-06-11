
namespace Session_9_Exercises {
    partial class StudentForm {
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
            this.ctrlAddStudent = new System.Windows.Forms.Label();
            this.ctrlNameLabel = new System.Windows.Forms.Label();
            this.ctrlAgeLabel = new System.Windows.Forms.Label();
            this.ctrlRegistrationNumberLabel = new System.Windows.Forms.Label();
            this.ctrlNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ctrlAgeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ctrlRegistrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ctrlOkStudent = new System.Windows.Forms.Button();
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlLastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ctrlLastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAgeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegistrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlLastNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.AutoSize = true;
            this.ctrlAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddStudent.ForeColor = System.Drawing.Color.White;
            this.ctrlAddStudent.Location = new System.Drawing.Point(274, 28);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(190, 29);
            this.ctrlAddStudent.TabIndex = 5;
            this.ctrlAddStudent.Text = "Add a Student..";
            // 
            // ctrlNameLabel
            // 
            this.ctrlNameLabel.AutoSize = true;
            this.ctrlNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlNameLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlNameLabel.Location = new System.Drawing.Point(244, 104);
            this.ctrlNameLabel.Name = "ctrlNameLabel";
            this.ctrlNameLabel.Size = new System.Drawing.Size(82, 16);
            this.ctrlNameLabel.TabIndex = 6;
            this.ctrlNameLabel.Text = "Enter Name:";
            // 
            // ctrlAgeLabel
            // 
            this.ctrlAgeLabel.AutoSize = true;
            this.ctrlAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAgeLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlAgeLabel.Location = new System.Drawing.Point(256, 187);
            this.ctrlAgeLabel.Name = "ctrlAgeLabel";
            this.ctrlAgeLabel.Size = new System.Drawing.Size(70, 16);
            this.ctrlAgeLabel.TabIndex = 7;
            this.ctrlAgeLabel.Text = "Enter Age:";
            // 
            // ctrlRegistrationNumberLabel
            // 
            this.ctrlRegistrationNumberLabel.AutoSize = true;
            this.ctrlRegistrationNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlRegistrationNumberLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlRegistrationNumberLabel.Location = new System.Drawing.Point(158, 227);
            this.ctrlRegistrationNumberLabel.Name = "ctrlRegistrationNumberLabel";
            this.ctrlRegistrationNumberLabel.Size = new System.Drawing.Size(168, 16);
            this.ctrlRegistrationNumberLabel.TabIndex = 8;
            this.ctrlRegistrationNumberLabel.Text = "Enter Registration Number:";
            // 
            // ctrlNameTextEdit
            // 
            this.ctrlNameTextEdit.EditValue = "";
            this.ctrlNameTextEdit.Location = new System.Drawing.Point(360, 101);
            this.ctrlNameTextEdit.Name = "ctrlNameTextEdit";
            this.ctrlNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlNameTextEdit.Size = new System.Drawing.Size(169, 22);
            this.ctrlNameTextEdit.TabIndex = 10;
            // 
            // ctrlAgeTextEdit
            // 
            this.ctrlAgeTextEdit.Location = new System.Drawing.Point(360, 184);
            this.ctrlAgeTextEdit.Name = "ctrlAgeTextEdit";
            this.ctrlAgeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAgeTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlAgeTextEdit.Size = new System.Drawing.Size(169, 22);
            this.ctrlAgeTextEdit.TabIndex = 11;
            // 
            // ctrlRegistrationTextEdit
            // 
            this.ctrlRegistrationTextEdit.Location = new System.Drawing.Point(360, 224);
            this.ctrlRegistrationTextEdit.Name = "ctrlRegistrationTextEdit";
            this.ctrlRegistrationTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlRegistrationTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlRegistrationTextEdit.Size = new System.Drawing.Size(169, 22);
            this.ctrlRegistrationTextEdit.TabIndex = 12;
            // 
            // ctrlOkStudent
            // 
            this.ctrlOkStudent.BackColor = System.Drawing.Color.White;
            this.ctrlOkStudent.Location = new System.Drawing.Point(482, 407);
            this.ctrlOkStudent.Name = "ctrlOkStudent";
            this.ctrlOkStudent.Size = new System.Drawing.Size(109, 32);
            this.ctrlOkStudent.TabIndex = 3;
            this.ctrlOkStudent.Text = "OK";
            this.ctrlOkStudent.UseVisualStyleBackColor = false;
            this.ctrlOkStudent.Click += new System.EventHandler(this.OkStudentButton_Click);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.BackColor = System.Drawing.Color.White;
            this.ctrlCancel.Location = new System.Drawing.Point(597, 407);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(109, 32);
            this.ctrlCancel.TabIndex = 4;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = false;
            this.ctrlCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ctrlLastNameTextEdit
            // 
            this.ctrlLastNameTextEdit.EditValue = "";
            this.ctrlLastNameTextEdit.Location = new System.Drawing.Point(360, 143);
            this.ctrlLastNameTextEdit.Name = "ctrlLastNameTextEdit";
            this.ctrlLastNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLastNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlLastNameTextEdit.Size = new System.Drawing.Size(169, 22);
            this.ctrlLastNameTextEdit.TabIndex = 14;
            // 
            // ctrlLastNameLabel
            // 
            this.ctrlLastNameLabel.AutoSize = true;
            this.ctrlLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLastNameLabel.ForeColor = System.Drawing.Color.White;
            this.ctrlLastNameLabel.Location = new System.Drawing.Point(216, 146);
            this.ctrlLastNameLabel.Name = "ctrlLastNameLabel";
            this.ctrlLastNameLabel.Size = new System.Drawing.Size(110, 16);
            this.ctrlLastNameLabel.TabIndex = 13;
            this.ctrlLastNameLabel.Text = "Enter Last Name:";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.ctrlLastNameTextEdit);
            this.Controls.Add(this.ctrlLastNameLabel);
            this.Controls.Add(this.ctrlRegistrationTextEdit);
            this.Controls.Add(this.ctrlAgeTextEdit);
            this.Controls.Add(this.ctrlNameTextEdit);
            this.Controls.Add(this.ctrlRegistrationNumberLabel);
            this.Controls.Add(this.ctrlAgeLabel);
            this.Controls.Add(this.ctrlNameLabel);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOkStudent);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAgeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegistrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlLastNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ctrlAddStudent;
        private System.Windows.Forms.Label ctrlNameLabel;
        private System.Windows.Forms.Label ctrlAgeLabel;
        private System.Windows.Forms.Label ctrlRegistrationNumberLabel;
        private DevExpress.XtraEditors.TextEdit ctrlNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ctrlAgeTextEdit;
        private DevExpress.XtraEditors.TextEdit ctrlRegistrationTextEdit;
        private System.Windows.Forms.Button ctrlOkStudent;
        private System.Windows.Forms.Button ctrlCancel;
        private DevExpress.XtraEditors.TextEdit ctrlLastNameTextEdit;
        private System.Windows.Forms.Label ctrlLastNameLabel;
    }
}