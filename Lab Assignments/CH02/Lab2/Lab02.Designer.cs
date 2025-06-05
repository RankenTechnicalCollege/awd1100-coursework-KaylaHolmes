namespace Lab2
{
    partial class Lab02
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
            this.txtScoreOne = new System.Windows.Forms.TextBox();
            this.txtScoreTwo = new System.Windows.Forms.TextBox();
            this.txtScoreThree = new System.Windows.Forms.TextBox();
            this.txtScoreFour = new System.Windows.Forms.TextBox();
            this.lblScoreOne = new System.Windows.Forms.Label();
            this.lblScoreTwo = new System.Windows.Forms.Label();
            this.lblScoreThree = new System.Windows.Forms.Label();
            this.lblScoreFour = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnFindAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScoreOne
            // 
            this.txtScoreOne.Location = new System.Drawing.Point(40, 37);
            this.txtScoreOne.Name = "txtScoreOne";
            this.txtScoreOne.Size = new System.Drawing.Size(100, 22);
            this.txtScoreOne.TabIndex = 0;
            // 
            // txtScoreTwo
            // 
            this.txtScoreTwo.Location = new System.Drawing.Point(40, 101);
            this.txtScoreTwo.Name = "txtScoreTwo";
            this.txtScoreTwo.Size = new System.Drawing.Size(100, 22);
            this.txtScoreTwo.TabIndex = 1;
            // 
            // txtScoreThree
            // 
            this.txtScoreThree.Location = new System.Drawing.Point(40, 170);
            this.txtScoreThree.Name = "txtScoreThree";
            this.txtScoreThree.Size = new System.Drawing.Size(100, 22);
            this.txtScoreThree.TabIndex = 2;
            // 
            // txtScoreFour
            // 
            this.txtScoreFour.Location = new System.Drawing.Point(40, 238);
            this.txtScoreFour.Name = "txtScoreFour";
            this.txtScoreFour.Size = new System.Drawing.Size(100, 22);
            this.txtScoreFour.TabIndex = 3;
            this.txtScoreFour.TextChanged += new System.EventHandler(this.txtScoreFour_TextChanged_1);
            // 
            // lblScoreOne
            // 
            this.lblScoreOne.AutoSize = true;
            this.lblScoreOne.Location = new System.Drawing.Point(37, 18);
            this.lblScoreOne.Name = "lblScoreOne";
            this.lblScoreOne.Size = new System.Drawing.Size(120, 16);
            this.lblScoreOne.TabIndex = 4;
            this.lblScoreOne.Text = "Enter Test Score 1:";
            // 
            // lblScoreTwo
            // 
            this.lblScoreTwo.AutoSize = true;
            this.lblScoreTwo.Location = new System.Drawing.Point(37, 82);
            this.lblScoreTwo.Name = "lblScoreTwo";
            this.lblScoreTwo.Size = new System.Drawing.Size(120, 16);
            this.lblScoreTwo.TabIndex = 5;
            this.lblScoreTwo.Text = "Enter Test Score 2:";
            // 
            // lblScoreThree
            // 
            this.lblScoreThree.AutoSize = true;
            this.lblScoreThree.Location = new System.Drawing.Point(37, 151);
            this.lblScoreThree.Name = "lblScoreThree";
            this.lblScoreThree.Size = new System.Drawing.Size(120, 16);
            this.lblScoreThree.TabIndex = 6;
            this.lblScoreThree.Text = "Enter Test Score 3:";
            // 
            // lblScoreFour
            // 
            this.lblScoreFour.AutoSize = true;
            this.lblScoreFour.Location = new System.Drawing.Point(37, 219);
            this.lblScoreFour.Name = "lblScoreFour";
            this.lblScoreFour.Size = new System.Drawing.Size(120, 16);
            this.lblScoreFour.TabIndex = 7;
            this.lblScoreFour.Text = "Enter Test Score 4:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(37, 345);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 16);
            this.lblResults.TabIndex = 9;
            // 
            // btnFindAverage
            // 
            this.btnFindAverage.Location = new System.Drawing.Point(40, 276);
            this.btnFindAverage.Name = "btnFindAverage";
            this.btnFindAverage.Size = new System.Drawing.Size(146, 23);
            this.btnFindAverage.TabIndex = 10;
            this.btnFindAverage.Text = "Find Average";
            this.btnFindAverage.UseVisualStyleBackColor = true;
            this.btnFindAverage.Click += new System.EventHandler(this.btnFindAverage_Click);
            // 
            // Lab02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindAverage);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblScoreFour);
            this.Controls.Add(this.lblScoreThree);
            this.Controls.Add(this.lblScoreTwo);
            this.Controls.Add(this.lblScoreOne);
            this.Controls.Add(this.txtScoreFour);
            this.Controls.Add(this.txtScoreThree);
            this.Controls.Add(this.txtScoreTwo);
            this.Controls.Add(this.txtScoreOne);
            this.Name = "Lab02";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScoreOne;
        private System.Windows.Forms.TextBox txtScoreTwo;
        private System.Windows.Forms.TextBox txtScoreThree;
        private System.Windows.Forms.TextBox txtScoreFour;
        private System.Windows.Forms.Label lblScoreOne;
        private System.Windows.Forms.Label lblScoreTwo;
        private System.Windows.Forms.Label lblScoreThree;
        private System.Windows.Forms.Label lblScoreFour;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnFindAverage;
    }
}

