using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class Validation
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool FieldCheck(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("This filed is required. Please enter the correct value below", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool DepositCheck(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("This filed is required. Please enter your deposit amount", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool ComboCheck(ComboBox combobox)
        {
            if (combobox.Text == "")
            {
                MessageBox.Show("This field is required. Please select the type of account.", Title);
                combobox.Focus();
                return false;
            }
            return true;
        }
        public static void Exit()
        {
            DialogResult res = MessageBox.Show("Do you want to exit the Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public static bool DecimalVaidate(TextBox textBox)
        {
            decimal number = 0m;
            if (decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show("This must be a decimal value. Try again.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool DecimalAmount(TextBox textbox, decimal amount)
        {
            decimal deposit = Convert.ToDecimal(textbox.Text);
            if (deposit == 0)
            {
                MessageBox.Show("You cannot create an account with " + deposit.ToString("C") + ". Please try again.", Title);
                textbox.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidateString(string string1)
        {
            //Look for invalid characters
            List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", ".", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
           

            foreach (string s in invalidChars)
            {
                if (string1.Contains(s))
                {
                    MessageBox.Show("String contains invalid characters. Please try again.", Title);
                    return false;
                    
                }
            }
            return true;
        }
    }
}
