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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
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

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}