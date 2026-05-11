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
    public partial class BookTestForm : Form
    {
        public BookTestForm()
        {
            InitializeComponent();
        }

        private void BookTestForm_Load(object sender, EventArgs e)
        {
            cmbTestType.Items.Add("Blood Test");
            cmbTestType.Items.Add("Urine Test");
            cmbTestType.Items.Add("X-Ray");
            cmbTestType.Items.Add("MRI");
            cmbTestType.Items.Add("ECG");
            cmbTestType.SelectedIndex = 0;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientName.Text) || cmbTestType.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = DatabaseHelper.AddAppointment(
                txtPatientName.Text,
                cmbTestType.SelectedItem.ToString(),
                dtpDate.Value.ToShortDateString()
            );

            if (success)
            {
                MessageBox.Show("Appointment booked successfully!\n" +
                                "Patient: " + txtPatientName.Text + "\n" +
                                "Test: " + cmbTestType.SelectedItem.ToString() + "\n" +
                                "Date: " + dtpDate.Value.ToShortDateString(),
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to book appointment!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = "";
            cmbTestType.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtPatientName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}