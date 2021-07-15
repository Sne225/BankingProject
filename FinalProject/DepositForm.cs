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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void nameSurnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Customer customer = new Customer();
      
        decimal deposits;
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {

                   deposits = decimal.Parse(depositTxt.Text);
                this.DialogResult = DialogResult.OK;
                this.Tag = Convert.ToDecimal(depositTxt.Text);

                MessageBox.Show("Deposit successful!" + "\n" + "\n" + "You have deposited " + deposits.ToString("C"), "Deposit Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                //for (int i = 0; i < customer.Balance.Count; i++)
                //{
                //    newAmount = Convert.ToDecimal(customer.Balance[i]) + deposits;

                //    MessageBox.Show("Deposit successful!" + "\n" + "You have deposited " + deposits.ToString("C") + "\n" + "\n" + "Your new balance is " + newAmount.ToString("C"), "Deposit Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    form.AmountTxt.Text = newAmount.ToString("C");
                //}

            }
        }
        private bool IsValidData()
        {
            return
                // Validate the deposit amount textbox
                Validation.DepositCheck(depositTxt) &&
            Validation.DecimalVaidate(depositTxt);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }
    }
}
