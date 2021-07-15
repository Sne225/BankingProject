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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void createAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreRegForm register = new PreRegForm();
            register.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iBSB@gmail.com", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void adressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Baxter Rd, Rondebosch, Cape Town, 8000", "Address", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
