namespace Project_1
{
    partial class frmInformationLookup
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
            this.lblAddressBook = new System.Windows.Forms.Label();
            this.lblFirstLastName = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstNameResults = new System.Windows.Forms.Label();
            this.lblLastNameResults = new System.Windows.Forms.Label();
            this.lblPhoneResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddressBook
            // 
            this.lblAddressBook.AutoSize = true;
            this.lblAddressBook.Location = new System.Drawing.Point(12, 9);
            this.lblAddressBook.Name = "lblAddressBook";
            this.lblAddressBook.Size = new System.Drawing.Size(93, 16);
            this.lblAddressBook.TabIndex = 0;
            this.lblAddressBook.Text = "Address Book";
            // 
            // lblFirstLastName
            // 
            this.lblFirstLastName.AutoSize = true;
            this.lblFirstLastName.Location = new System.Drawing.Point(12, 35);
            this.lblFirstLastName.Name = "lblFirstLastName";
            this.lblFirstLastName.Size = new System.Drawing.Size(155, 16);
            this.lblFirstLastName.TabIndex = 1;
            this.lblFirstLastName.Text = "First Name or Last Name";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(15, 64);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(180, 22);
            this.txtNameInput.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 137);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 165);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 16);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone #: ";
            // 
            // lblFirstNameResults
            // 
            this.lblFirstNameResults.AutoSize = true;
            this.lblFirstNameResults.Location = new System.Drawing.Point(110, 111);
            this.lblFirstNameResults.Name = "lblFirstNameResults";
            this.lblFirstNameResults.Size = new System.Drawing.Size(0, 16);
            this.lblFirstNameResults.TabIndex = 6;
            // 
            // lblLastNameResults
            // 
            this.lblLastNameResults.AutoSize = true;
            this.lblLastNameResults.Location = new System.Drawing.Point(110, 137);
            this.lblLastNameResults.Name = "lblLastNameResults";
            this.lblLastNameResults.Size = new System.Drawing.Size(0, 16);
            this.lblLastNameResults.TabIndex = 7;
            // 
            // lblPhoneResults
            // 
            this.lblPhoneResults.AutoSize = true;
            this.lblPhoneResults.Location = new System.Drawing.Point(110, 165);
            this.lblPhoneResults.Name = "lblPhoneResults";
            this.lblPhoneResults.Size = new System.Drawing.Size(0, 16);
            this.lblPhoneResults.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmInformationLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPhoneResults);
            this.Controls.Add(this.lblLastNameResults);
            this.Controls.Add(this.lblFirstNameResults);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.lblFirstLastName);
            this.Controls.Add(this.lblAddressBook);
            this.Name = "frmInformationLookup";
            this.Text = "Contact Information Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddressBook;
        private System.Windows.Forms.Label lblFirstLastName;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirstNameResults;
        private System.Windows.Forms.Label lblLastNameResults;
        private System.Windows.Forms.Label lblPhoneResults;
        private System.Windows.Forms.Button btnSearch;
    }
}

