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
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Validation.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       Customer customer = new Customer();
        
        
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            //TransactionForm form = new TransactionForm();
            ////customer.Name =;
            ////customer.TypeAcc = ;
            //// string[] row = { customer.Name, customer.AccNo.ToString(), customer.TypeAcc, customer.Balance.("C") };
            //string[] row = { form.LblName.AccessibleDescription, form.LblAccType.ToString(), customer.AccNo.ToString(), form.AmountTxt.ToString() };
            //var listview = new ListViewItem(row);
            //listView1.Items.Add(listview);

            //RegisterForm from = new RegisterForm();
            //string[] row = { from.nameSurnameTxt.Text, from.accNumberTxt.Text, from.accTypeComboTxt.Text, from.balanceTxt.Text };
            //var listview = new ListViewItem(row);
            //listView1.Items.Add(listview);
            label2.Text = DateTime.Now.ToLongDateString();

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
                
            }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void suammaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1 printDocument = ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font PrintFont = new System.Drawing.Font("Arial", 12);
            Single LineHeightSingle = PrintFont.GetHeight() + 2;
            Single HorizontalPrintLocationSingle = e.MarginBounds.Left;
            Single VerticalPrintLocationSingle = e.MarginBounds.Top;
            string PrintLineString;

            using (Font HeadingFont = new Font("Arial", 14, FontStyle.Bold))
            {

                PrintLineString = "Today Summary Accounts \n";
                e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black,
               HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;

                PrintLineString = "by: iBank –Student Banks (iBSB) ";
                e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black,
               HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;

            }

            VerticalPrintLocationSingle += LineHeightSingle * 2;


            using (Font subHeadingFont = new Font("Arial", 12, FontStyle.Bold))
            {
                PrintLineString = listView1 .SelectedItems.ToString() + "Summery";
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
               HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

            VerticalPrintLocationSingle += LineHeightSingle;

            foreach (string sports in listView1.Items)
            {
                PrintLineString = sports;
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
               HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }
        }
    }
    }

