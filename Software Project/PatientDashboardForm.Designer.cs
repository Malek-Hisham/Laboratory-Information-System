namespace Software_Project
{
    partial class PatientDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBookTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(534, 76);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(393, 52);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Patient!";
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnViewResults.Location = new System.Drawing.Point(543, 249);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(384, 53);
            this.btnViewResults.TabIndex = 1;
            this.btnViewResults.Text = "View My Results";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Location = new System.Drawing.Point(646, 332);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 33);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBookTest
            // 
            this.btnBookTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnBookTest.Location = new System.Drawing.Point(543, 162);
            this.btnBookTest.Name = "btnBookTest";
            this.btnBookTest.Size = new System.Drawing.Size(384, 54);
            this.btnBookTest.TabIndex = 3;
            this.btnBookTest.Text = "Book a Test";
            this.btnBookTest.UseVisualStyleBackColor = false;
            this.btnBookTest.Click += new System.EventHandler(this.btnBookTest_Click);
            // 
            // PatientDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1403, 549);
            this.Controls.Add(this.btnBookTest);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PatientDashboardForm";
            this.Text = "PatientDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBookTest;
    }
}