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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Patient");
            cmbRole.SelectedIndex = 1;
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = DatabaseHelper.GetUsers();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = DatabaseHelper.AddUser(txtName.Text, txtUsername.Text,
                                                   txtPassword.Text, cmbRole.SelectedItem.ToString());
            if (success)
            {
                MessageBox.Show("User added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Username already exists!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteUser(username);
                MessageBox.Show("User deleted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = 1;
            txtName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}