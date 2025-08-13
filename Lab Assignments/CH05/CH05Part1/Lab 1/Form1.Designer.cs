namespace Lab_1
{
    partial class frmCollegeAdmission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblAdmissionTestScore = new System.Windows.Forms.Label();
            this.txtAdmissionTestScore = new System.Windows.Forms.TextBox();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(12, 9);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(35, 16);
            this.lblGPA.TabIndex = 0;
            this.lblGPA.Text = "GPA";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(15, 28);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 22);
            this.txtGPA.TabIndex = 1;
            // 
            // lblAdmissionTestScore
            // 
            this.lblAdmissionTestScore.AutoSize = true;
            this.lblAdmissionTestScore.Location = new System.Drawing.Point(189, 9);
            this.lblAdmissionTestScore.Name = "lblAdmissionTestScore";
            this.lblAdmissionTestScore.Size = new System.Drawing.Size(139, 16);
            this.lblAdmissionTestScore.TabIndex = 2;
            this.lblAdmissionTestScore.Text = "Admission Test Score";
            // 
            // txtAdmissionTestScore
            // 
            this.txtAdmissionTestScore.Location = new System.Drawing.Point(192, 28);
            this.txtAdmissionTestScore.Name = "txtAdmissionTestScore";
            this.txtAdmissionTestScore.Size = new System.Drawing.Size(100, 22);
            this.txtAdmissionTestScore.TabIndex = 3;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(15, 96);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdmit.TabIndex = 4;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(189, 103);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 16);
            this.lblResults.TabIndex = 5;
            // 
            // frmCollegeAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.txtAdmissionTestScore);
            this.Controls.Add(this.lblAdmissionTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGPA);
            this.Name = "frmCollegeAdmission";
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblAdmissionTestScore;
        private System.Windows.Forms.TextBox txtAdmissionTestScore;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Label lblResults;
    }
}

