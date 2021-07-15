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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        Customer currentCustomer = new Customer();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }
        TransactionForm form = new TransactionForm();
        decimal deposit;
        private void createTheAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                deposit = decimal.Parse(balanceTxt.Text);
                currentCustomer.Name = nameSurnameTxt.Text;
                currentCustomer.Balance.Add(Convert.ToDecimal(balanceTxt.Text));
                currentCustomer.TypeAcc = accTypeComboTxt.SelectedItem.ToString();
                

                //public static decimal Add(decimal d1, decimal d2);
                form.LblName.Text = nameSurnameTxt.Text;
                form.LblAccType.Text = accTypeComboTxt.SelectedItem.ToString();

                for (int i = 0; i < currentCustomer.Balance.Count; i++)
                {
                    form.AmountTxt.Text = currentCustomer.Balance[i].ToString("C");
                }

               
               
                //From.LblName.Text = LblName.Text;
                //From.LblAccType.Text = LblAccType.Text;
                //From.AmountTxt.Text = AmountTxt.Text;
                
                form.accTxt.Text = Convert.ToString(currentCustomer.AccNo);
                MessageBox.Show("Your account has been created successfully!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

                form.Show();
                this.Hide();


                



            }
        }
        private bool IsValidData()
        {
            return
                // Validate the name textbox, Combobox, acc type texbox, and deposit textbox
                Validation.FieldCheck(nameSurnameTxt)&&
             Validation.ValidateString(nameSurnameTxt.Text) &&
            Validation.ComboCheck(accTypeComboTxt) &&
            Validation.DepositCheck(balanceTxt) &&
            Validation.DecimalVaidate(balanceTxt) &&
                    Validation.DecimalAmount(balanceTxt, deposit);
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            accTypeComboTxt.Items.AddRange(new string[] { "Current Account", "Savings Account", "Fixed Deposit Account" });

            if (form.AmountTxt.Text != "")
            {
                currentCustomer.AccNo = Convert.ToDecimal(form.AmountTxt.Text);
                currentCustomer.AccNo++;
                accNumberTxt.Text = Convert.ToString(currentCustomer.AccNo);
            }
            else
            {
                accNumberTxt.Text = Convert.ToString(currentCustomer.AccNo);
            }
        }
    }
}
