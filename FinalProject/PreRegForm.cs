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
    public partial class PreRegForm : Form
    {
        public PreRegForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                termsConditionsForm form = new termsConditionsForm();
                DialogResult agree = form.ShowDialog();
                if (agree == DialogResult.OK)
                {
                    button4.Enabled = true;
                }
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
            this.Close();

        }
    }
}
