namespace Lab_2
{
    partial class frmTestScores
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
            this.lblInputScore = new System.Windows.Forms.Label();
            this.txtEnterScore = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputScore
            // 
            this.lblInputScore.AutoSize = true;
            this.lblInputScore.Location = new System.Drawing.Point(12, 9);
            this.lblInputScore.Name = "lblInputScore";
            this.lblInputScore.Size = new System.Drawing.Size(155, 16);
            this.lblInputScore.TabIndex = 0;
            this.lblInputScore.Text = "Please enter a test score";
            // 
            // txtEnterScore
            // 
            this.txtEnterScore.Location = new System.Drawing.Point(15, 28);
            this.txtEnterScore.Name = "txtEnterScore";
            this.txtEnterScore.Size = new System.Drawing.Size(152, 22);
            this.txtEnterScore.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(15, 56);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmTestScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnterScore);
            this.Controls.Add(this.lblInputScore);
            this.Name = "frmTestScores";
            this.Text = "Test Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputScore;
        private System.Windows.Forms.TextBox txtEnterScore;
        private System.Windows.Forms.Button btnEnter;
    }
}

