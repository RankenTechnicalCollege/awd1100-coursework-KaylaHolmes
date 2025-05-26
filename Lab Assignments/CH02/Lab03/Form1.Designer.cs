namespace Lab03
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
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblRentalFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(283, 93);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(88, 16);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "# Days * $100";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(283, 155);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(91, 16);
            this.lblMiles.TabIndex = 1;
            this.lblMiles.Text = "# Miles * $0.50";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(422, 87);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 2;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(422, 149);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 22);
            this.txtMiles.TabIndex = 3;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(286, 210);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 23);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Find Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // lblRentalFee
            // 
            this.lblRentalFee.AutoSize = true;
            this.lblRentalFee.Location = new System.Drawing.Point(425, 217);
            this.lblRentalFee.Name = "lblRentalFee";
            this.lblRentalFee.Size = new System.Drawing.Size(0, 16);
            this.lblRentalFee.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRentalFee);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblRentalFee;
    }
}

