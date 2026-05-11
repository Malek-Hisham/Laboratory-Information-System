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
    public partial class ViewResultsForm : Form
    {
        public ViewResultsForm()
        {
            InitializeComponent();
        }

        private void ViewResultsForm_Load(object sender, EventArgs e)
        {
            LoadResults();
        }

        private void LoadResults()
        {
            dgvResults.DataSource = DatabaseHelper.GetAppointments();
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(search);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}