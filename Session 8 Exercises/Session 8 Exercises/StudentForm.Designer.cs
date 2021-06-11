
namespace Session_8_Exercises {
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
            this.components = new System.ComponentModel.Container();
            this.AddStudentLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.RegistrationNumberLabel = new System.Windows.Forms.Label();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.AgeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RegistrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OkStudentButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentLabel
            // 
            this.AddStudentLabel.AutoSize = true;
            this.AddStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddStudentLabel.ForeColor = System.Drawing.Color.White;
            this.AddStudentLabel.Location = new System.Drawing.Point(274, 28);
            this.AddStudentLabel.Name = "AddStudentLabel";
            this.AddStudentLabel.Size = new System.Drawing.Size(190, 29);
            this.AddStudentLabel.TabIndex = 5;
            this.AddStudentLabel.Text = "Add a Student..";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(206, 146);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(137, 16);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Enter Your Full Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgeLabel.ForeColor = System.Drawing.Color.White;
            this.AgeLabel.Location = new System.Drawing.Point(242, 184);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(101, 16);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Enter Your Age:";
            // 
            // RegistrationNumberLabel
            // 
            this.RegistrationNumberLabel.AutoSize = true;
            this.RegistrationNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RegistrationNumberLabel.ForeColor = System.Drawing.Color.White;
            this.RegistrationNumberLabel.Location = new System.Drawing.Point(158, 224);
            this.RegistrationNumberLabel.Name = "RegistrationNumberLabel";
            this.RegistrationNumberLabel.Size = new System.Drawing.Size(185, 16);
            this.RegistrationNumberLabel.TabIndex = 8;
            this.RegistrationNumberLabel.Text = "Enter Your RegistrationName:";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.EditValue = "";
            this.NameTextEdit.Location = new System.Drawing.Point(360, 143);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.NameTextEdit.Size = new System.Drawing.Size(169, 22);
            this.NameTextEdit.TabIndex = 10;
            this.NameTextEdit.EditValueChanged += new System.EventHandler(this.NameTextEdit_EditValueChanged);
            // 
            // AgeTextEdit
            // 
            this.AgeTextEdit.Location = new System.Drawing.Point(360, 184);
            this.AgeTextEdit.Name = "AgeTextEdit";
            this.AgeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgeTextEdit.Properties.Appearance.Options.UseFont = true;
            this.AgeTextEdit.Size = new System.Drawing.Size(169, 22);
            this.AgeTextEdit.TabIndex = 11;
            // 
            // RegistrationTextEdit
            // 
            this.RegistrationTextEdit.Location = new System.Drawing.Point(360, 224);
            this.RegistrationTextEdit.Name = "RegistrationTextEdit";
            this.RegistrationTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RegistrationTextEdit.Properties.Appearance.Options.UseFont = true;
            this.RegistrationTextEdit.Size = new System.Drawing.Size(169, 22);
            this.RegistrationTextEdit.TabIndex = 12;
            // 
            // OkStudentButton
            // 
            this.OkStudentButton.BackColor = System.Drawing.Color.White;
            this.OkStudentButton.Location = new System.Drawing.Point(482, 407);
            this.OkStudentButton.Name = "OkStudentButton";
            this.OkStudentButton.Size = new System.Drawing.Size(109, 32);
            this.OkStudentButton.TabIndex = 3;
            this.OkStudentButton.Text = "OK";
            this.OkStudentButton.UseVisualStyleBackColor = false;
            this.OkStudentButton.Click += new System.EventHandler(this.OkStudentButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(597, 407);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 32);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.RegistrationTextEdit);
            this.Controls.Add(this.AgeTextEdit);
            this.Controls.Add(this.NameTextEdit);
            this.Controls.Add(this.RegistrationNumberLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddStudentLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkStudentButton);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddStudentLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label RegistrationNumberLabel;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit AgeTextEdit;
        private DevExpress.XtraEditors.TextEdit RegistrationTextEdit;
        private System.Windows.Forms.Button OkStudentButton;
        private System.Windows.Forms.Button CancelButton;
    }
}