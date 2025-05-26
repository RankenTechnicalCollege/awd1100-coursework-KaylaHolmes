namespace EX2
{
    partial class frmAverage
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
            this.lblReal1 = new System.Windows.Forms.Label();
            this.lblReal2 = new System.Windows.Forms.Label();
            this.lblReal3 = new System.Windows.Forms.Label();
            this.txtReal1 = new System.Windows.Forms.TextBox();
            this.txtReal2 = new System.Windows.Forms.TextBox();
            this.txtReal3 = new System.Windows.Forms.TextBox();
            this.btnFindAverage = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReal1
            // 
            this.lblReal1.AutoSize = true;
            this.lblReal1.Location = new System.Drawing.Point(247, 97);
            this.lblReal1.Name = "lblReal1";
            this.lblReal1.Size = new System.Drawing.Size(100, 16);
            this.lblReal1.TabIndex = 0;
            this.lblReal1.Text = "Real Number 1:";
            // 
            // lblReal2
            // 
            this.lblReal2.AutoSize = true;
            this.lblReal2.Location = new System.Drawing.Point(247, 132);
            this.lblReal2.Name = "lblReal2";
            this.lblReal2.Size = new System.Drawing.Size(100, 16);
            this.lblReal2.TabIndex = 1;
            this.lblReal2.Text = "Real Number 2:";
            // 
            // lblReal3
            // 
            this.lblReal3.AutoSize = true;
            this.lblReal3.Location = new System.Drawing.Point(247, 169);
            this.lblReal3.Name = "lblReal3";
            this.lblReal3.Size = new System.Drawing.Size(100, 16);
            this.lblReal3.TabIndex = 2;
            this.lblReal3.Text = "Real Number 3:";
            // 
            // txtReal1
            // 
            this.txtReal1.Location = new System.Drawing.Point(448, 97);
            this.txtReal1.Name = "txtReal1";
            this.txtReal1.Size = new System.Drawing.Size(100, 22);
            this.txtReal1.TabIndex = 3;
            // 
            // txtReal2
            // 
            this.txtReal2.Location = new System.Drawing.Point(448, 132);
            this.txtReal2.Name = "txtReal2";
            this.txtReal2.Size = new System.Drawing.Size(100, 22);
            this.txtReal2.TabIndex = 4;
            // 
            // txtReal3
            // 
            this.txtReal3.Location = new System.Drawing.Point(448, 169);
            this.txtReal3.Name = "txtReal3";
            this.txtReal3.Size = new System.Drawing.Size(100, 22);
            this.txtReal3.TabIndex = 5;
            // 
            // btnFindAverage
            // 
            this.btnFindAverage.Location = new System.Drawing.Point(250, 235);
            this.btnFindAverage.Name = "btnFindAverage";
            this.btnFindAverage.Size = new System.Drawing.Size(298, 23);
            this.btnFindAverage.TabIndex = 6;
            this.btnFindAverage.Text = "Find Average";
            this.btnFindAverage.UseVisualStyleBackColor = true;
            this.btnFindAverage.Click += new System.EventHandler(this.btnFindAverage_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(247, 288);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 16);
            this.lblResults.TabIndex = 7;
            // 
            // frmAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnFindAverage);
            this.Controls.Add(this.txtReal3);
            this.Controls.Add(this.txtReal2);
            this.Controls.Add(this.txtReal1);
            this.Controls.Add(this.lblReal3);
            this.Controls.Add(this.lblReal2);
            this.Controls.Add(this.lblReal1);
            this.Name = "frmAverage";
            this.Text = "EX2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReal1;
        private System.Windows.Forms.Label lblReal2;
        private System.Windows.Forms.Label lblReal3;
        private System.Windows.Forms.TextBox txtReal1;
        private System.Windows.Forms.TextBox txtReal2;
        private System.Windows.Forms.TextBox txtReal3;
        private System.Windows.Forms.Button btnFindAverage;
        private System.Windows.Forms.Label lblResults;
    }
}

