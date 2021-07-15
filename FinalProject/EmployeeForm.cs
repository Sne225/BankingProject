using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementForm form = new ManagementForm();
            form.Show();
            this.Hide();
        }
    }
}
