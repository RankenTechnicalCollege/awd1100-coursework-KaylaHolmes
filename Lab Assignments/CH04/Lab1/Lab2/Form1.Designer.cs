namespace Lab2
{
    partial class frmChickenFarmer
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
            this.lblEnterNumbers = new System.Windows.Forms.Label();
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterNumbers
            // 
            this.lblEnterNumbers.AutoSize = true;
            this.lblEnterNumbers.Location = new System.Drawing.Point(264, 93);
            this.lblEnterNumbers.Name = "lblEnterNumbers";
            this.lblEnterNumbers.Size = new System.Drawing.Size(262, 16);
            this.lblEnterNumbers.TabIndex = 0;
            this.lblEnterNumbers.Text = "Enter number of eggs laid by each chicken:";
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(185, 122);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(100, 22);
            this.txtChicken1.TabIndex = 1;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(291, 122);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(100, 22);
            this.txtChicken2.TabIndex = 2;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(397, 122);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(100, 22);
            this.txtChicken3.TabIndex = 3;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(503, 122);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(100, 22);
            this.txtChicken4.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(349, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(93, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(264, 212);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 16);
            this.lblResults.TabIndex = 6;
            // 
            // frmChickenFarmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.lblEnterNumbers);
            this.Name = "frmChickenFarmer";
            this.Text = "Chicken Farmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumbers;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResults;
    }
}

