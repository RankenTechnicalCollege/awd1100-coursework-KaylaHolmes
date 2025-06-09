namespace Lab1
{
    partial class frmDistanceConverter
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
            this.lblKilometers = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.btnConvertToKM = new System.Windows.Forms.Button();
            this.btnConvertToMiles = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(218, 122);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(108, 16);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Distance in Miles";
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(455, 122);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(139, 16);
            this.lblKilometers.TabIndex = 1;
            this.lblKilometers.Text = "Distance in Kilometers";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(218, 141);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 22);
            this.txtMiles.TabIndex = 2;
            // 
            // txtKilometers
            // 
            this.txtKilometers.Location = new System.Drawing.Point(458, 141);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(100, 22);
            this.txtKilometers.TabIndex = 3;
            // 
            // btnConvertToKM
            // 
            this.btnConvertToKM.Location = new System.Drawing.Point(218, 192);
            this.btnConvertToKM.Name = "btnConvertToKM";
            this.btnConvertToKM.Size = new System.Drawing.Size(126, 23);
            this.btnConvertToKM.TabIndex = 4;
            this.btnConvertToKM.Text = "Convert to KM";
            this.btnConvertToKM.UseVisualStyleBackColor = true;
            this.btnConvertToKM.Click += new System.EventHandler(this.btnConvertToKM_Click);
            // 
            // btnConvertToMiles
            // 
            this.btnConvertToMiles.Location = new System.Drawing.Point(458, 192);
            this.btnConvertToMiles.Name = "btnConvertToMiles";
            this.btnConvertToMiles.Size = new System.Drawing.Size(136, 23);
            this.btnConvertToMiles.TabIndex = 5;
            this.btnConvertToMiles.Text = "Convert to Miles";
            this.btnConvertToMiles.UseVisualStyleBackColor = true;
            this.btnConvertToMiles.Click += new System.EventHandler(this.btnConvertToMiles_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(218, 254);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 16);
            this.lblResults.TabIndex = 6;
            // 
            // frmDistanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnConvertToMiles);
            this.Controls.Add(this.btnConvertToKM);
            this.Controls.Add(this.txtKilometers);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.lblMiles);
            this.Name = "frmDistanceConverter";
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.Button btnConvertToKM;
        private System.Windows.Forms.Button btnConvertToMiles;
        private System.Windows.Forms.Label lblResults;
    }
}

