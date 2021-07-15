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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (IsValidData())
            {
                decimal withdraw = decimal.Parse(WithdrawTxt.Text);
                this.DialogResult = DialogResult.OK;
                decimal newAmount;
                TransactionForm form = new TransactionForm();

                newAmount = Convert.ToDecimal(form.AmountTxt.Text) - withdraw;

                MessageBox.Show("Withdrawal successful!" + "\n" + "You have deposited " + withdraw.ToString("") + "\n" + "\n" + "Your new balance is " + newAmount.ToString("C"), "Withdrawal Successful!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        private bool IsValidData()
        {
            return
                // Validate the withdraw textbox
                Validation.FieldCheck(WithdrawTxt) &&
            Validation.DecimalVaidate(WithdrawTxt);
        }
    }
    }

