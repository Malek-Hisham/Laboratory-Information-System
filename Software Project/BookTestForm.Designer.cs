namespace Software_Project
{
    partial class BookTestForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.cmbTestType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(565, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book a Laboratory Test";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.lblPatientName.Location = new System.Drawing.Point(487, 156);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(148, 25);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.lblTestType.Location = new System.Drawing.Point(518, 234);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(117, 25);
            this.lblTestType.TabIndex = 2;
            this.lblTestType.Text = "Test Type:";
            
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.lblDate.Location = new System.Drawing.Point(444, 303);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(191, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Appointment Date:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.btnClear.Location = new System.Drawing.Point(750, 453);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnBook.Location = new System.Drawing.Point(556, 393);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(307, 48);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(196)))));
            this.btnBack.Location = new System.Drawing.Point(556, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.txtPatientName.Location = new System.Drawing.Point(641, 184);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 37);
            this.txtPatientName.TabIndex = 7;
            // 
            // cmbTestType
            // 
            this.cmbTestType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.cmbTestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.cmbTestType.FormattingEnabled = true;
            this.cmbTestType.Location = new System.Drawing.Point(641, 262);
            this.cmbTestType.Name = "cmbTestType";
            this.cmbTestType.Size = new System.Drawing.Size(200, 24);
            this.cmbTestType.TabIndex = 8;
            
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.dtpDate.Location = new System.Drawing.Point(641, 344);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 9;
            
            // 
            // BookTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1348, 545);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbTestType);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblTitle);
            this.Name = "BookTestForm";
            this.Text = "BookTestForm";
            this.Load += new System.EventHandler(this.BookTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ComboBox cmbTestType;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}