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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void proceedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerRad.Checked)
            {

                AboutForm about = new AboutForm();
                about.Show();
                this.Hide();
            }

            if (employeeRad.Checked)
            {
                DialogResult res = MessageBox.Show("Please note that this section is for iBSB Employees only!" + "\n" + "\n" +"Are you an iBSB Employee?","iBSB Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                {
                    EmployeeForm form = new EmployeeForm();
                    form.Show();
                    this.Hide();
                }
            
            }
        }
    }
}
