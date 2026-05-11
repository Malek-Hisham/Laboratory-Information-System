using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class PatientDashboardForm : Form
    {
        public PatientDashboardForm()
        {
            InitializeComponent();
        }

        private void btnBookTest_Click(object sender, EventArgs e)
        {
            BookTestForm bookTestForm = new BookTestForm();
            bookTestForm.ShowDialog();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            ViewResultsForm viewResultsForm = new ViewResultsForm();
            viewResultsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}