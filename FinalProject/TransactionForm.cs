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
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();
        private void label1_Click(object sender, EventArgs e)
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to Logout?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                ManagementForm from = new ManagementForm();

                //Store the data on  the ListView for printing
                if (from.listView1.Items.Count == 0)
                {
                    string[] row = { LblName.Text, accTxt.Text, LblAccType.Text, AmountTxt.Text };
                    var listview = new ListViewItem(row);
                    from.listView1.Items.Add(listview);
                }
                else
                {
                    for (int i = 0; i < from.listView1.Items.Count; i++)
                    {

                        string[] row = { LblName.Text, accTxt.Text, LblAccType.Text, AmountTxt.Text };
                        var listview = new ListViewItem(row);
                        from.listView1.Items.Insert(i, listview);

                    }
                }

               
                this.Hide();
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblAcc_Click(object sender, EventArgs e)
        {

        }

        private void createANewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("You are about to create a new account." + "\n" + "\n" + "\n" + "Are you sure?", "New Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                PreRegForm form = new PreRegForm();
                form.Show();
                this.Hide();

                ManagementForm from = new ManagementForm();
                if (from.listView1.Items.Count == 0)
                {
                    string[] row = { LblName.Text, accTxt.Text, LblAccType.Text, AmountTxt.Text };
                    var listview = new ListViewItem(row);
                    from.listView1.Items.Add(listview);
                }
                else
                {
                    for (int i = 0; i < from.listView1.Items.Count; i++)
                    {

                        string[] row = { LblName.Text, accTxt.Text, LblAccType.Text, AmountTxt.Text };
                        var listview = new ListViewItem(row);
                        from.listView1.Items.Insert(i, listview);

                    }
                }

                
                this.Hide();
            }
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            
           
        }
        
        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form updateForm = new frmAddUpdateScore();
            //updateForm.Text = "Update Score";
            //updateForm.Tag = lstStudentScores.SelectedItem;
            //DialogResult button = updateForm.ShowDialog();
            //if (button == DialogResult.OK)
            //{
            //    int score = (int)updateForm.Tag;
            //    student.Scores.Insert(lstStudentScores.SelectedIndex, score);
            //    student.Scores.RemoveAt(lstStudentScores.SelectedIndex + 1);
            //    DisplayScores();
            //}
            Form depositForm = new DepositForm();
                depositForm.Text = "Deposit Amount";
            depositForm.Tag = AmountTxt.Text;
                DialogResult button = depositForm.ShowDialog();
            if (button == DialogResult.OK)
            {
                decimal deposit = (decimal)depositForm.Tag;
                customer.Balance.Add(deposit); //customer.Balance[0] 
                
            }
        }
        public List<Customer> Currentcustomer = new List<Customer>();
        private void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawForm withdraw = new WithdrawForm();
            DialogResult button = withdraw.ShowDialog();
            if (button == DialogResult.OK)
            {
                decimal newAmount;
                newAmount = Convert.ToDecimal(AmountTxt) - Convert.ToDecimal(withdraw.WithdrawTxt.Text);
                AmountTxt.Text = newAmount.ToString("C");
            }
        }
        
        private void managementFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please note that this section is for iBSB Employees only!" + "\n" + "\n" + "Are you an iBSB Employee?", "iBSB Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                EmployeeForm form = new EmployeeForm();
                form.Show();
                this.Hide();
            }
            ManagementForm from = new ManagementForm();
            if (from.listView1.Items.Count == 0)
            {
                string[] row = { LblName.Text, accTxt.Text, LblAccType.Text, AmountTxt.Text };
                var listview = new ListViewItem(row);
                from.listView1.Items.Add(listview);
            }
            else
            {
                for (int i = 0; i < from.listView1.Items.Count; i++)
                {

                    string[] row = { LblName.Text, accTxt.Text, LblAccType.Text, AmountTxt.Text };
                    var listview = new ListViewItem(row);
                    from.listView1.Items.Insert(i, listview);

                }
            }
           
            from.Show();
            this.Hide();

        }
    }
    }

