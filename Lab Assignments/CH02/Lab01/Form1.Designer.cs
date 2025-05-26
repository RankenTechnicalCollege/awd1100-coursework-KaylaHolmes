namespace Lab01
{
    partial class Form1
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblKiloResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(193, 62);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(39, 16);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Miles";
            this.lblMiles.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(196, 81);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 22);
            this.txtMiles.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(196, 127);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(284, 36);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(193, 193);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(70, 16);
            this.lblKilometers.TabIndex = 5;
            this.lblKilometers.Text = "Kilometers";
            // 
            // lblKiloResults
            // 
            this.lblKiloResults.AutoSize = true;
            this.lblKiloResults.Location = new System.Drawing.Point(196, 213);
            this.lblKiloResults.Name = "lblKiloResults";
            this.lblKiloResults.Size = new System.Drawing.Size(0, 16);
            this.lblKiloResults.TabIndex = 6;
            this.lblKiloResults.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKiloResults);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblKiloResults;
    }
}

