
namespace Session_8_Exercises {
    partial class ProfessorForm {
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
            this.AddProfessorLabel = new System.Windows.Forms.Label();
            this.RankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AgeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RankLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CancelProfessorButton = new System.Windows.Forms.Button();
            this.OkProfessorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProfessorLabel
            // 
            this.AddProfessorLabel.AutoSize = true;
            this.AddProfessorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddProfessorLabel.ForeColor = System.Drawing.Color.White;
            this.AddProfessorLabel.Location = new System.Drawing.Point(285, 33);
            this.AddProfessorLabel.Name = "AddProfessorLabel";
            this.AddProfessorLabel.Size = new System.Drawing.Size(221, 29);
            this.AddProfessorLabel.TabIndex = 0;
            this.AddProfessorLabel.Text = "Add a Professor...";
            // 
            // RankTextEdit
            // 
            this.RankTextEdit.Location = new System.Drawing.Point(376, 199);
            this.RankTextEdit.Name = "RankTextEdit";
            this.RankTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RankTextEdit.Properties.Appearance.Options.UseFont = true;
            this.RankTextEdit.Size = new System.Drawing.Size(169, 22);
            this.RankTextEdit.TabIndex = 18;
            // 
            // AgeTextEdit
            // 
            this.AgeTextEdit.Location = new System.Drawing.Point(376, 159);
            this.AgeTextEdit.Name = "AgeTextEdit";
            this.AgeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgeTextEdit.Properties.Appearance.Options.UseFont = true;
            this.AgeTextEdit.Size = new System.Drawing.Size(169, 22);
            this.AgeTextEdit.TabIndex = 17;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.EditValue = "";
            this.NameTextEdit.Location = new System.Drawing.Point(376, 118);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.NameTextEdit.Size = new System.Drawing.Size(169, 22);
            this.NameTextEdit.TabIndex = 16;
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RankLabel.ForeColor = System.Drawing.Color.White;
            this.RankLabel.Location = new System.Drawing.Point(251, 202);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(108, 16);
            this.RankLabel.TabIndex = 15;
            this.RankLabel.Text = "Enter Your Rank:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgeLabel.ForeColor = System.Drawing.Color.White;
            this.AgeLabel.Location = new System.Drawing.Point(258, 159);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(101, 16);
            this.AgeLabel.TabIndex = 14;
            this.AgeLabel.Text = "Enter Your Age:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(222, 121);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(137, 16);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Enter Your Full Name:";
            // 
            // CancelProfessorButton
            // 
            this.CancelProfessorButton.BackColor = System.Drawing.Color.White;
            this.CancelProfessorButton.Location = new System.Drawing.Point(668, 392);
            this.CancelProfessorButton.Name = "CancelProfessorButton";
            this.CancelProfessorButton.Size = new System.Drawing.Size(109, 32);
            this.CancelProfessorButton.TabIndex = 20;
            this.CancelProfessorButton.Text = "Cancel";
            this.CancelProfessorButton.UseVisualStyleBackColor = false;
            this.CancelProfessorButton.Click += new System.EventHandler(this.CancelProfessorButton_Click);
            // 
            // OkProfessorButton
            // 
            this.OkProfessorButton.BackColor = System.Drawing.Color.White;
            this.OkProfessorButton.Location = new System.Drawing.Point(553, 392);
            this.OkProfessorButton.Name = "OkProfessorButton";
            this.OkProfessorButton.Size = new System.Drawing.Size(109, 32);
            this.OkProfessorButton.TabIndex = 19;
            this.OkProfessorButton.Text = "OK";
            this.OkProfessorButton.UseVisualStyleBackColor = false;
            this.OkProfessorButton.Click += new System.EventHandler(this.OkProfessorButton_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelProfessorButton);
            this.Controls.Add(this.OkProfessorButton);
            this.Controls.Add(this.RankTextEdit);
            this.Controls.Add(this.AgeTextEdit);
            this.Controls.Add(this.NameTextEdit);
            this.Controls.Add(this.RankLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddProfessorLabel);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.RankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProfessorLabel;
        private DevExpress.XtraEditors.TextEdit RankTextEdit;
        private DevExpress.XtraEditors.TextEdit AgeTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private new System.Windows.Forms.Button CancelProfessorButton;
        private System.Windows.Forms.Button OkProfessorButton;
    }
}