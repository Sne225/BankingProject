using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  


    public class Customer 
    {

        private string name;
        private decimal accNo;
        private string typeAcc;
        private List<decimal> DepositAmount = new List<decimal>();
        private decimal accGenerator = 000000000;

        public Customer ShallowCopy()
        {
            return (Customer)this.MemberwiseClone();
        }
        public Customer() { }

        public Customer(string aName, List<decimal> aAmount, decimal aAccNo, string aTypeAcc)
        {
            this.name = aName;
            this.DepositAmount = aAmount;
            this.accNo = aAccNo;
            this.typeAcc = aTypeAcc;

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



        public string TypeAcc
        {
            get
            {
                return typeAcc;
            }
            set
            {
                name = value;

            }
        }
        Random random = new Random();
        public decimal AccNo
        {
            get
            {
                accGenerator = random.Next();
                accNo = accGenerator;
                return accNo;
            }
            set
            {
                accNo = value;
            }
        }

        public List<decimal> Balance
        {
            get
            {
                return DepositAmount;
            }
            set
            {
                DepositAmount = value;
            }
        }
        public string GetAmountString()
        {
            string amountString = "";
            foreach (int i in DepositAmount)
                amountString += i.ToString();
            return amountString;
        }

        public override string ToString()
        { return name + this.GetAmountString(); }
    }


    //public object Clone()
    //{
    //    Customer s = new Customer();
    //    s.Name = this.Name;
    //    foreach (int i in this.DepositAmount)
    //        s.Scores.Add(i);
    //    s.Sep = this.Sep;
    //    return s;
    //}




}


