namespace Lab04
{
    partial class frmLab04
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
            this.lblDaysRented = new System.Windows.Forms.Label();
            this.txtDaysRented = new System.Windows.Forms.TextBox();
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDaysResults = new System.Windows.Forms.Label();
            this.lblMilesResults = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDaysRented
            // 
            this.lblDaysRented.AutoSize = true;
            this.lblDaysRented.Location = new System.Drawing.Point(13, 13);
            this.lblDaysRented.Name = "lblDaysRented";
            this.lblDaysRented.Size = new System.Drawing.Size(112, 16);
            this.lblDaysRented.TabIndex = 0;
            this.lblDaysRented.Text = "# Of Days Rented";
            // 
            // txtDaysRented
            // 
            this.txtDaysRented.Location = new System.Drawing.Point(131, 13);
            this.txtDaysRented.Name = "txtDaysRented";
            this.txtDaysRented.Size = new System.Drawing.Size(100, 22);
            this.txtDaysRented.TabIndex = 1;
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(18, 72);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(107, 16);
            this.lblMilesDriven.TabIndex = 2;
            this.lblMilesDriven.Text = "# Of Miles Driven";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(131, 66);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 22);
            this.txtMiles.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(21, 134);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(210, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Amount Due";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDaysResults
            // 
            this.lblDaysResults.AutoSize = true;
            this.lblDaysResults.Location = new System.Drawing.Point(18, 196);
            this.lblDaysResults.Name = "lblDaysResults";
            this.lblDaysResults.Size = new System.Drawing.Size(0, 16);
            this.lblDaysResults.TabIndex = 5;
            // 
            // lblMilesResults
            // 
            this.lblMilesResults.AutoSize = true;
            this.lblMilesResults.Location = new System.Drawing.Point(18, 234);
            this.lblMilesResults.Name = "lblMilesResults";
            this.lblMilesResults.Size = new System.Drawing.Size(0, 16);
            this.lblMilesResults.TabIndex = 6;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(18, 270);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(0, 16);
            this.lblAmountDue.TabIndex = 7;
            // 
            // frmLab04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.lblMilesResults);
            this.Controls.Add(this.lblDaysResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMilesDriven);
            this.Controls.Add(this.txtDaysRented);
            this.Controls.Add(this.lblDaysRented);
            this.Name = "frmLab04";
            this.Text = "Lab04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysRented;
        private System.Windows.Forms.TextBox txtDaysRented;
        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDaysResults;
        private System.Windows.Forms.Label lblMilesResults;
        private System.Windows.Forms.Label lblAmountDue;
    }
}

